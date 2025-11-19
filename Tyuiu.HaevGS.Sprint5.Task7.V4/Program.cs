using Tyuiu.HaevGS.Sprint5.Task7.V4.Lib;
using System.IO;



DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил Карпенко Н. А. | АСОиУб-23-2";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка файлов                                                  *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Карпенко Никита Андреевич | АСОиУб-23-2                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, Дан файл в котором есть набор символьных      *");
Console.WriteLine("* данных. Заменить все русские буквы на #. Полученный результат сохранить *");
Console.WriteLine("* в файл OutPutDataFileTask7V4.txt.                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";
string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V4.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Данные находятся в файле:");
pathSaveFile = ds.LoadDataAndSave(path);

Console.WriteLine(pathSaveFile);
Console.ReadKey();