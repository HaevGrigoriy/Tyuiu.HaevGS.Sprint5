using Tyuiu.HaevGS.Sprint5.Task3.V5.Lib;
using System.IO;

DataService ds = new DataService();

int x = 2;

string res = ds.SaveToFileTextData(x);
Console.WriteLine($"Файл: " + res);
Console.WriteLine("Создан!");

Console.ReadKey();