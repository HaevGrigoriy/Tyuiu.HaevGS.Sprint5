using Tyuiu.HaevGS.Sprint5.Task3.V5.Lib;
using System.IO;

namespace Tyuiu.HaevGS.Sprint5.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask3.bin");
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, filexists);
        }
    }
}
