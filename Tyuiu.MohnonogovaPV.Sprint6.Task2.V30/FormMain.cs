using Tyuiu.MohnonogovaPV.Sprint6.Task2.V30.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы АСОиУб-24-1 Мохноногова Полина Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KEA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartGraf_KEA.Titles.Add("График функции");
                this.chartGraf_KEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_KEA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_KEA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartGraf_KEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_KEA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KEA.BackColor = Color.Blue;
        }

        private void buttonDone_KEA_ENTER(object sender, EventArgs e)
        {
            buttonDone_KEA.BackColor = Color.Red;
        }

        private void buttonDone_KEA_LEAVE(object sender, EventArgs e)
        {
            buttonDone_KEA.BackColor = Color.Green;
        }
    }
}
        
    

