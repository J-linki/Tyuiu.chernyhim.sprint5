namespace Tyuiu.chernyhim.sprint5.Task2.V15.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask2.csv";
            FileInfo inf = new FileInfo(path);
            if (inf.Exists)
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string x = "";
            for (int i = 0;i < rows;i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    if (j < cols - 1)
                    {
                        x += matrix[i, j] + ";";
                    }
                    else
                    {
                        x += matrix[i, j];
                    }
                }

                if (i < cols - 1)
                {
                    File.AppendAllText(path, x + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, x);
                }
                x = "";
            }
            return path;
        }
    }
}
