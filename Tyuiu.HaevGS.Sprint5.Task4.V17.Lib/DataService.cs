using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {

            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx);
            double res = Math.Round(Math.Sin(2 / (3 * x)) + x * x, 3);
            return res;

        }
    }
}
