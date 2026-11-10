namespace Tyuiu.chernyhim.sprint5.Task1.V8.Test
{
    using System.IO;
    using Tyuiu.chernyhim.sprint5.Task1.V8.Lib;
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Artem\source\repos\Tyuiu.chernyhim.sprint5\Tyuiu.chernyhim.sprint5.Task1.V8\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo inf = new FileInfo(path);
            bool wait = true;
            bool exp = inf.Exists;
            Assert.AreEqual(wait, exp);
        }
    }
}