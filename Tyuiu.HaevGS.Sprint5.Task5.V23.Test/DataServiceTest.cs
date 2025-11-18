using Tyuiu.HaevGS.Sprint5.Task5.V23.Lib;
using System.IO;


namespace Tyuiu.HaevGS.Sprint5.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempPath();
            FileInfo fileinfo = new FileInfo(path);
            bool filexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, filexist);
        }
    }
}
