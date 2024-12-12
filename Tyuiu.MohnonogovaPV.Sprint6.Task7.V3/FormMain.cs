using Tyuiu.MohnonogovaPV.Sprint6.Task7.V3.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KDY.Filter = "Çíà÷åíèÿ, ðàçäåëåííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.* ";
            saveFileDialogMatrix_KDY.Filter = "Çíà÷åíèÿ, ðàçäåëåííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);

            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KDY_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDY.ShowDialog();
            openFilePath = openFileDialogTask_KDY.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_KDY.ColumnCount = columns;
            dataGridViewInMatrix_KDY.RowCount = rows;
            dataGridViewOutMatrix_KDY.ColumnCount = columns;
            dataGridViewOutMatrix_KDY.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_KDY.Columns[i].Width = 25;
                dataGridViewOutMatrix_KDY.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_KDY.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KDY.Enabled = true;
        }

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_KDY.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_KDY.Enabled = true;
        }

        private void buttonSaveFile_KDY_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KDY.FileName = "OutPutFileTask7V3.csv";
            saveFileDialogMatrix_KDY.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KDY.ShowDialog();

            string path = saveFileDialogMatrix_KDY.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_KDY.RowCount;
            int columns = dataGridViewOutMatrix_KDY.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutMatrix_KDY.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutMatrix_KDY.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_KDY.RowCount = 50;
            dataGridViewOutMatrix_KDY.RowCount = 50;

            dataGridViewInMatrix_KDY.ColumnCount = 50;
            dataGridViewOutMatrix_KDY.ColumnCount = 50;

            panelLeft_KDY.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_KDY.Columns[i].Width = 25;
                dataGridViewOutMatrix_KDY.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "Îòêðûòü ôàéë";
        }

        private void buttonDone_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = " Âûïîëíèòü";
        }

        private void buttonSaveFile_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = " Ñîõðàíèòü â ôàéë";
        }

        private void buttonHelp_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = " Ñïðàâêà";
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
