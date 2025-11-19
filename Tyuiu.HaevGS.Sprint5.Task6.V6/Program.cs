using Tyuiu.HaevGS.Sprint5.Task6.V6.Lib;
using System.IO;

DataService ds = new DataService();

string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V6.txt");
Console.WriteLine($"Данные находятся в файле: {path}");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();