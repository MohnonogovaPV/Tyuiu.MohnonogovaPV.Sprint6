using Tyuiu.MohnonogovaPV.Sprint6.Task2.V30.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = new double[11];
            res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11] { -15.4, -13.31, -11.36, -8.00, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}