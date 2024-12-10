using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            double[] res = new double[11];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(i) - 2 * i == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = Math.Round(((5*x + 2.5)/(Math.Sin(x)+3)) + 2*x + Math.Cos(x), 2);
                i++;
            }

            return res;
        }
    }
}
