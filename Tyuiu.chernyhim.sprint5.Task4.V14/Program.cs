using Tyuiu.chernyhim.sprint5.Task4.V14.Lib;

string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";

DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("значение Х находится в C:\\DataSprint5\\InPutDataFileTask4V14.txt");
Console.WriteLine("Sin(x^3) + 2/x");

Console.WriteLine("*************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
Console.WriteLine("*************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine($"ответ: {res}");
Console.ReadKey();