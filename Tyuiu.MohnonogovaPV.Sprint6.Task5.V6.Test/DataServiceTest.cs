using Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();
            var path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint6\DataSprint6\InPutFileTask5V6.txt";
            double[] res = dataService.LoadFromDataFile(path);
            double[] wait = new double[res.Length];
            wait[0] = -13;
            wait[1] = -19;
            wait[2] = -9.82;
            wait[3] = 13;
            wait[4] = 11.49;
            wait[5] = -9.71;
            wait[6] = 3.36;
            wait[7] = 14.52;
            wait[8] = 16;
            wait[9] = 13.66;
            wait[10] = 0.48;
            wait[11] = 4.13;
            wait[12] = -0.11;
            wait[13] = 19;
            wait[14] = -17.36;
            wait[15] = 11;
            wait[16] = 11.28;
            wait[17] = -12;
            wait[18] = -12.35;
            CollectionAssert.AreEqual(res, wait);
        }

    }
}