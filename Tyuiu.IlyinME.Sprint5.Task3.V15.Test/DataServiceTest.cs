﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.IlyinME.Sprint5.Task3.V15.Lib;

namespace Tyuiu.IlyinME.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.IlyinME.Sprint5\Tyuiu.IlyinME.Sprint5.Task3.V15\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
