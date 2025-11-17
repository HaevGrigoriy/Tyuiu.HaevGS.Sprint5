using Tyuiu.HaevGS.Sprint5.Task2.V13.Lib;
using System.IO;

DataService ds = new DataService();

Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Console.WriteLine("***************************************************************************");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите {i}, {j} элемент массива: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Файл: " + ds.SaveToFileTextData(matrix));
Console.WriteLine("Создан!");
Console.ReadKey();