using Tyuiu.HaevGS.Sprint5.Task7.V4.Lib;
using System.IO;

DataService DataService = new DataService();

Console.WriteLine("***************************************************************************");

string path = $@"C:\DataSprint5\InPutDataFileTask7V4.txt";
string res = File.ReadAllText(path);
Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);

Console.WriteLine("****************************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
Console.WriteLine("****************************************************************");

string w = DataService.LoadDataAndSave(path);
Console.WriteLine("Cоздан!");
Console.ReadKey();