using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int len = 0;

        public int Calculate(int k)
        {
            throw new NotImplementedException();
        }

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
                    numsArray[index] = Math.Round(Convert.ToDouble(line), 3);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val % 3 == 0).ToArray();
            return numsArray;
        }
    }
}