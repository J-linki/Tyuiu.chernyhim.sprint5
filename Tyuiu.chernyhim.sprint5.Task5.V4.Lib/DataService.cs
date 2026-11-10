namespace Tyuiu.chernyhim.sprint5.Task5.V4.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');
            string[] x = str.Split(' ');
            for (int i = 0; i < x.Length; i++)
            {
                double y = double.Parse(x[i]);
                if (Math.Abs(y) - Math.Abs(Convert.ToInt32(y)) != 0)
                {
                    res = res * y;
                }
                
            }
            return Math.Round(res, 3);
        }
    }
}
