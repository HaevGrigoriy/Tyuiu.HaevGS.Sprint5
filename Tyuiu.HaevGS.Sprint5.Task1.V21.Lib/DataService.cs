using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.HaevGS.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTest1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;

            if (filexists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2 * x - 3 / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x);
                stry = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
