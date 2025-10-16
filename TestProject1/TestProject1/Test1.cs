// TODO should be using MyMvvmApp.Models;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public static void TestMethod1()
        {
            // sima tábor
            Camp camp = new Camp();
            Assert.AreEqual("Summer Camp Booker", camp.Name);
            Camp campValidDates = new Camp(new DateTime(2025, 06, 16), new DateTime(2025, 06, 23));
            Assert.AreEqual("Camp named Summer Camp Booker between 2025-06-16 and 2025-06-23", campValidDates.ToString());
            Camp campEqualDates = new Camp(new DateTime(2025, 06, 16), new DateTime(2025, 06, 16));
            Assert.AreEqual("Camp named Summer Camp Booker between 2025-06-16 and 2025-06-16", campEqualDates.ToString());
            // hibás dátum
            Camp campInvalidDates = null;
            try
            {
                campInvalidDates = new Camp(new DateTime(2025, 06, 23), new DateTime(2025, 06, 16));
            } catch (ArgumentException ae)
            {
                Console.Error.WriteLine("Hiba elkapva: " + ae.Message);
            }
            Assert.IsNull(campInvalidDates);
        }
    }
}
