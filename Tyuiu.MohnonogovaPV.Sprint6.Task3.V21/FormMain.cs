using Tyuiu.MohnonogovaPV.Sprint6.Task3.V21.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task3.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {26, -15, 7, 1, -4},
                                      {14, 26, 22, 17, 27},
                                      {-8, 31, 22, 34, 4},
                                      {-18, 16, -2, 16, 27},
                                      {5, 2, -4, 16, 15} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewInPutArray_DVA.ColumnCount = columns;
            dataGridViewInPutArray_DVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutArray_DVA.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutArray_DVA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void buttonDone_DVA_Click(object sender, EventArgs e)
        {
            int[,] resmatrix = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = resmatrix.Length / rows;
            dataGridViewOutPutArray_DVA.ColumnCount = columns;
            dataGridViewOutPutArray_DVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPutArray_DVA.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutArray_DVA.Rows[i].Cells[j].Value = Convert.ToString(resmatrix[i, j]);
                }
            }

        }
        private void buttonHelp_DVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы АСОиУб-24-1 Мохноногова Полина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
