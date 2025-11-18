using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string text = File.ReadAllText(path).Replace('.', ',');
                string[] strings = text.Split(' ');

                double minNumber = double.MaxValue;

                foreach (string str in strings)
                {
                    if (double.TryParse(str.Trim(), out double number))
                    {
                        if (number % 1 == 0 && number % 4 == 0)
                        {
                            minNumber = number;
                        }
                    }
                }
                return minNumber;
                //    string line;
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        double number = Convert.ToDouble(line);
                //        if (number % 1 != 0)
                //        {
                //            for (int i = 0; i <= number; i++)
                //            {
                //                res = number;
                //            }
                //        }
                //    }
                //}
                //return res;
            }
        }
    }
}
