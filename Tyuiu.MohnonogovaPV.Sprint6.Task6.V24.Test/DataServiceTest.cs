using Tyuiu.MohnonogovaPV.Sprint6.Task6.V24.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\PC\Documents\InPutDataFileTask6V24.txt";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, "EovFJ Vud RgdW KwQBrOM Ewyq");
        }
    }
}