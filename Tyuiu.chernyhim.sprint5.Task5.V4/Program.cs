using System.IO;
using Tyuiu.chernyhim.sprint5.Task5.V4.Lib;

string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";

DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Ряд чисел находится в C:\\DataSprint5\\InPutDataFileTask5V4.txt");
Console.WriteLine("Найти произведение ряда чисел");

Console.WriteLine("*************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
Console.WriteLine("*************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine($"ответ: {res}");
Console.ReadKey();