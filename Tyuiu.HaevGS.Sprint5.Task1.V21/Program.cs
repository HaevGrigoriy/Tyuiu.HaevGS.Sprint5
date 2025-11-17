using Tyuiu.HaevGS.Sprint5.Task1.V21.Lib;

int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();

string res = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine("Файл" + res);
Console.ReadKey();