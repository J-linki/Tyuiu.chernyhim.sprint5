using Tyuiu.chernyhim.sprint5.Task3.V13.Lib;

int x = 3;

DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("x = 3");
Console.WriteLine("x / (x^3 + 2)");

Console.WriteLine("*************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
Console.WriteLine("*************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
