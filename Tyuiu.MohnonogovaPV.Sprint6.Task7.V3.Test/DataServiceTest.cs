using Tyuiu.MohnonogovaPV.Sprint6.Task7.V3.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V3.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { {-1, -16, -5, 17, -1, -2, 19, -1, -18, 1 },
                          { -1, -10, -4, 16, -1, -8, 10, -11, -14, -12 },
                          { 1, -15, 19, -12, -1, -13, 12, 7, -1, -8 },
                          { -1, 13, 7, -18, 19, -17, -12, 9, -1, -1 },
                          { -1, -19, -15, -8, 3, -1 ,-13, -8, -19, -1 },
                          { 3, -1, 11, -5, -5, -3, -13, 3, -1, 19 },
                          { 13, -1, -1, 3, -9, -12, -1, -13, -20, -3 },
                          { -15, -1, 9, -12, -6, -1, 11, 20, -1, 7 },
                          { -11, -15, -1, 17, -1, -10, -8, -6, -13, -9 },
                          { -15, -14, 17, -7, -1, -17, -3, -17, -1, 11} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}