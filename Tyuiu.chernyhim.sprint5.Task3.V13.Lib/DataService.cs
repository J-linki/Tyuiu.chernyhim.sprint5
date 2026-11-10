namespace Tyuiu.chernyhim.sprint5.Task3.V13.Lib
{
    using System.IO;
    using System.Text;
    using System.Text.Unicode;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task3V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";
            FileInfo innf = new FileInfo(path);
            if (innf.Exists)
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();

            double res = (double)x / (Math.Pow((double)x, 3) + 2);
            res = Math.Round(res, 3);

            using(BinaryWriter writer = new BinaryWriter(File.Open(path,FileMode.Open), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
