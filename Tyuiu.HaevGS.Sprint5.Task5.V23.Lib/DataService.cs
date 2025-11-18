using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                double res = 0;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = Convert.ToDouble(line);
                    if (number % 1 != 0)
                    {
                        for (int i = 1; i < number; i++)
                        {
                            res = number;
                        }
                    }
                }
                return res;
            }  
        }
    }
}
