using Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private object formsPlot_FDA;

        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_FDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_FDA.Text);

                double[] valueArray;
                int len = (int)ds.GetMassFunction(startStep, stopStep);
                valueArray = new double[len];


                double[] xData = new double[len];
                double[] yData = new double[len];

                for (int i = 0; i < len; i++)
                {
                    xData[i] = startStep + i;
                    yData[i] = valueArray[i];
                }












                string strLine;

                textBoxResult_FDA.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(Convert.ToString(valueArray[i]));
                    textBoxResult_FDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà: {ex.Message}", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFile.txt" });
                File.WriteAllText(path, textBoxResult_FDA.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë " + path + " ñîõðàíåí óñïåøíî!\n Îòêðûòü åãî?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓá-24-1 Ôåäîðîâà Äàðüÿ Àðòåìîâíà", "Ñîîáùåíèå");
        }
    }
}
