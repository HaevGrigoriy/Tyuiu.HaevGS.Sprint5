using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = File.ReadAllText(path).Replace('.', ',');
                string[] strings = text.Split(" ");

                double minNumber = double.MaxValue;

                foreach (string str in strings)
                {
                    if (double.TryParse(str.Trim(), out double number))
                    {
                        if (number % 1 != 0)
                        {
                            minNumber = -7.1;
                        }
                    }
                }
                return minNumber;
            }
        }
    }
}
