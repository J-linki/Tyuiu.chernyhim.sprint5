namespace Tyuiu.chernyhim.sprint5.Task1.V8.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask1.txt";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            File.Create(path).Dispose();

            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 2 == 0)
                {
                    y = 0;
                    File.AppendAllText(path, $"{Convert.ToString(y)}" + Environment.NewLine);
                }
                else if (2 * x - 2 != 0 || x != stopValue)
                {
                    y = 4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2));
                    y = Math.Round(y,2);
                    File.AppendAllText(path, $"{Convert.ToString(y)}" + Environment.NewLine);
                }
                else
                {
                    y = 4 - 2 * x + ((2 + Math.Cos(x)) / 2 * x - 2);
                    y = Math.Round(y, 2);
                    File.AppendAllText(path, $"{Convert.ToString(y)}");
                }
            }
            return path;
        }
    }
}
