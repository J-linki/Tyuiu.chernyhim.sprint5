namespace Tyuiu.chernyhim.sprint5.Task3.V13.Test
{
    using Tyuiu.chernyhim.sprint5.Task3.V13.Lib;
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Artem\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo inf = new FileInfo(path);
            bool wait = true;
            bool exp = inf.Exists;
            Assert.AreEqual(wait, exp);
        }
    }
}