using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HaevGS.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V4.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string inputText = reader.ReadToEnd();

                // Заменяем все русские буквы на #
                string outputText = Regex.Replace(inputText, @"[А-Яа-я]", "#");
                return outputText;
            }
        }

    }
}
    

