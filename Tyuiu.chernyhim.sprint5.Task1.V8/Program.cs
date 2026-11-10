using Tyuiu.chernyhim.sprint5.Task1.V8.Lib;

int start = -5;
int end = 5;

DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("[-5;5]");
Console.WriteLine("4 - 2 * x + ((2 + Math.Cos(x)) / 2 * x - 2)");

Console.WriteLine("*************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
Console.WriteLine("*************************************************************************");

string res = ds.SaveToFileTextData(start,end);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
