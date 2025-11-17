using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task2V13
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.cvs");
            FileInfo fileinfo = new FileInfo(path);

            if (fileinfo.Exists)
            {
                File.Delete(path);
            }
            int[,] mtrx = new int[3, 3];

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }

            return path;
        }
    }
}
