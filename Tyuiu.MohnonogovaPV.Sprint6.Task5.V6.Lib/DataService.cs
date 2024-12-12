using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }

            }

            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }


            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double y;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    foreach (string value2 in arr)
                    {
                        bool check = false;
                        foreach (char tempchar in value2)
                        {
                            if (tempchar == '.' || tempchar == ',')
                            {
                                check = true;
                            }
                        }
                        if (check)
                        {
                            continue;
                        }
                        double value = Convert.ToInt32(value2);
                        y = Math.Round(value, 3);
                    }
                }
            }

            numsArray = numsArray.Where(n => n % 3 == 0).ToArray();
            return numsArray;
        }
    }
}