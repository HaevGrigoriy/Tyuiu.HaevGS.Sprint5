using Tyuiu.HaevGS.Sprint5.Task7.V4.Lib;
using System.IO;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");

string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V6.txt");
string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V4.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");

Console.WriteLine("Данные находятся в файле:");
pathSaveFile = ds.LoadDataAndSave(path);

Console.WriteLine(pathSaveFile);
Console.ReadKey();