namespace Tyuiu.chernyhim.sprint5.Task0.V23.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask0.txt";
            if (Directory.Exists(path))
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();
            double y = Math.Round(((1 + Math.Pow(x, 3)) / Math.Pow(x, 2)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
