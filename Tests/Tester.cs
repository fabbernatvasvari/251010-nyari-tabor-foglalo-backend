using ReferenceProject.Models;

namespace Tests
{
    [TestClass]
    public sealed class Tester
    {
        [TestMethod]
        public void TestCamp()
        {
            Camp c1 = new Camp();
            Camp c2 = new Camp(new DateTime(2023, 7, 1), new DateTime(2023, 7, 10));
            try
            {
                Camp c3 = Camp(new DateTime(2023, 8, 1), new DateTime(2023, 7, 31)); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Elvárt exception sikeresen elkapva: " + ex.Message);
            }
        }

        [TestMethod]
        public void TestNameAccess()
        {
            Camp c1 = new Camp();
            string appName = c1.Name;
            Assert.AreEqual("Summer Camp Booker", appName);
        }
    }
