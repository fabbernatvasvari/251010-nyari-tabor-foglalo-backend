using MyMvvmApp.Models.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMvvmAppTests.Models;

namespace MyMvvmAppTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunTests();
        }

        static void RunTests() { 
            Camptests.CampTest();
        }
    }
}
