namespace Tyuiu.chernyhim.sprint5.Task4.V14.Test
{
    using System.IO;
    using Tyuiu.chernyhim.sprint5.Task4.V14.Lib;
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
            FileInfo inf = new FileInfo(path);
            bool wait = true;
            bool exp = inf.Exists;
            Assert.AreEqual(wait, exp);
        }
    }
}