namespace Tyuiu.chernyhim.sprint5.Task5.V4.Test
{
    using Tyuiu.chernyhim.sprint5.Task5.V4.Lib;
    using System.IO;
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";
            FileInfo inf = new FileInfo(path);
            bool wait = true;
            bool exp = inf.Exists;
            Assert.AreEqual(wait, exp);
        }
    }
}