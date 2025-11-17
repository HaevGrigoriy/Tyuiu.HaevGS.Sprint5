using Tyuiu.HaevGS.Sprint5.Task4.V17.Lib;
using System.IO;

DataService ds = new DataService();


string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask4V17.txt");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();