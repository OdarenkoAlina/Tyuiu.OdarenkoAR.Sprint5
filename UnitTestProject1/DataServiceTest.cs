using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.OdarenkoAR.Sprint5.Task0.V2.Lib;
namespace UnitTestProject1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.OdarenkoAR.Sprint5\Tyuiu.OdarenkoAR.Sprint5.Task0.V2\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
