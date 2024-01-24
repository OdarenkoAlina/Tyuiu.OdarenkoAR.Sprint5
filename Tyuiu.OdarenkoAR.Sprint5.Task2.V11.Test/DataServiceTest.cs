using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.OdarenkoAR.Sprint5.Task2.V11.Lib;
namespace Tyuiu.OdarenkoAR.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.OdarenkoAR.Sprint5\Tyuiu.OdarenkoAR.Sprint5.Task2.V11\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
