using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMvvmApp.Models.Tests
{
    [TestClass()]
    public class CampTests
    {
        [TestMethod()]
        public static void CampTest()
        {
            Camp c1 = new Camp();
            Camp c2 = new Camp(new DateTime(2023, 7, 1), new DateTime(2023, 7, 10));
            Camp c3 = null;
            try
            {
                c3 = new Camp(new DateTime(2023, 8, 1), new DateTime(2023, 7, 31)); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Elvárt exception sikeresen elkapva: " + ex.Message);
            }

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}