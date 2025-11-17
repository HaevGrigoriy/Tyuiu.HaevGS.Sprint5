using System.IO;
using Tyuiu.HaevGS.Sprint5.Task1.V21.Lib;

namespace Tyuiu.HaevGS.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, filexists);
        }
    }
}
