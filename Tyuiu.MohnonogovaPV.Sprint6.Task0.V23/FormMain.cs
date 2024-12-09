using Tyuiu.MohnonogovaPV.Sprint6.Task0.V23.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVarX_LED_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 2) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_LED_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_LED.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_LED.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonHelp_LED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы АСОиУб - 24-1 Мохноногова Полина Викторовна");
        }
    }
}
