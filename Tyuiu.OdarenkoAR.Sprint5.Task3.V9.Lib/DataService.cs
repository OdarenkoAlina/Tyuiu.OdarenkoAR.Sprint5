﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OdarenkoAR.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTak3.bin";
            double z = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }


            return path;
        }
    }
}
