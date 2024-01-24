using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.OdarenkoAR.Sprint5.Task1.V9.Lib;
namespace Tyuiu.OdarenkoAR.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.OdarenkoAR.Sprint5\Tyuiu.OdarenkoAR.Sprint5.Task1.V9\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
