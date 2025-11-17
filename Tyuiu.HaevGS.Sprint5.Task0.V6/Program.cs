using Tyuiu.HaevGS.Sprint5.Task0.V6.Lib;

int x = 3;

DataService ds = new DataService();

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл" + res);