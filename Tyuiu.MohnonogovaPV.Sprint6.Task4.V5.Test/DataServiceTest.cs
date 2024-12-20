using Tyuiu.MohnonogovaPV.Sprint6.Task4.V5.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;

            int len = stopValue - startValue + 1;

            double[] valieWaitArray;
            valieWaitArray = new double[len];

            valieWaitArray[0] = 15.48;
            valieWaitArray[1] = 1;
            valieWaitArray[2] = -13.06;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valieWaitArray, res);
        }
    }
}