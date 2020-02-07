using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void writelineTest()
        {
            Utilities utilities = new Utilities();
            string inputText = "Hello world!";
            string output = utilities.writeline(inputText);
            Assert.AreEqual(inputText, output);


        }



    }
    }
