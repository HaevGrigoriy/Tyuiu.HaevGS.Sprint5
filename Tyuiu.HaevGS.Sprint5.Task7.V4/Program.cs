using Tyuiu.HaevGS.Sprint5.Task7.V4.Lib;
using System.IO;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";
string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V4.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");

Console.WriteLine("Данные находятся в файле:");
pathSaveFile = ds.LoadDataAndSave(path);

Console.WriteLine(pathSaveFile);
Console.ReadKey();