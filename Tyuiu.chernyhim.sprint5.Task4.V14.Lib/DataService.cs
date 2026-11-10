namespace Tyuiu.chernyhim.sprint5.Task4.V14.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string op = File.ReadAllText(path);
            double ox = Convert.ToDouble(op);
            double res = Math.Round((Math.Sin(Math.Pow(ox, 3)) + 2 / ox), 3);
            return res;
        }
    }
}
