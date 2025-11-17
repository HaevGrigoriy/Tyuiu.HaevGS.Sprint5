using Tyuiu.HaevGS.Sprint5.Task0.V6.Lib;
using System.IO;

namespace Tyuiu.HaevGS.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Studio code\Repos2\Tyuiu.HaevGS.Sprint5\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, filexists);
        }
    }
}
