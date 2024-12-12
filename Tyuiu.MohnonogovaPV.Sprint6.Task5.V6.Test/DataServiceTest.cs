using Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\PC\Documents\InPutDataFileTask6V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}