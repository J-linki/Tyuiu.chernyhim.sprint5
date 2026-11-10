namespace Tyuiu.chernyhim.sprint5.Task2.V15.Test
{
    using System.IO;
    using Tyuiu.chernyhim.sprint5.Task2.V15.Lib;
    [TestClass]
    public class DataServiceTest
    {
        DataService ds  = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Artem\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo inf = new FileInfo(path);
            bool wait = true;
            bool exp = inf.Exists;
            Assert.AreEqual(wait, exp);
        }
    }
}