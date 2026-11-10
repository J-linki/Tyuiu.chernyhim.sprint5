using Tyuiu.chernyhim.sprint5.Task2.V15.Lib;

int[,] ints = { { 6, 1, 7 }, { 1, 8, 5 }, { 6, 6, 4 } };

DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Матрица:");
int rows = ints.GetUpperBound(0) + 1;
int cols = ints.Length / rows;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (ints[i, j] / 2 == 1)
        {
            Console.WriteLine();
        }
    }
}


Console.WriteLine("*************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
Console.WriteLine("*************************************************************************");

string res = ds.SaveToFileTextData(ints);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();