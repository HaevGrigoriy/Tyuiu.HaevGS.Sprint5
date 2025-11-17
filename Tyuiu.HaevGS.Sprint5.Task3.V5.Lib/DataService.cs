using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.cvs");
            FileInfo fileinfo = new FileInfo(path);

            if (fileinfo.Exists)
            {
                File.Delete(path);
            }

            double y = 2 * Math.Pow(x, 3) + 0.5 * x * x - 3.5 * x + 2;

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
