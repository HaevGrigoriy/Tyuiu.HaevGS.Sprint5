using Tyuiu.HaevGS.Sprint5.Task7.V4.Lib;
using System.IO;

namespace Tyuiu.HaevGS.Sprint5.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = Path.GetTempPath();
            FileInfo fileinfo = new FileInfo(str);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            string str = Path.GetTempPath();
            FileInfo fileinfo = new FileInfo(str);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }
    }
}
