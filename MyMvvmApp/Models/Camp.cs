using System;
namespace MyMvvmApp.Models
{
    public class Camp
    {
        private static int _nextId = 1;

        public int Guid { get; }

        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(7);

        public string Name = "Summer Camp Booker";

        public Camp()
        {
            Guid = Interlocked.Increment(ref _nextId);
        }

        public Camp(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException("Dátumhiba: A befejezés dátuma nem lehet korábbi a kezdés dátumánál.");
            }
            Guid = Interlocked.Increment(ref _nextId);
            StartDate = startDate;
            EndDate = endDate;
        }

        public static void ResetIdCounter()
        {
            _nextId = 1;
        }

        public override string ToString()
        {
            return $"Camp named {Name} between {StartDate:yyyy-MM-dd} and {EndDate:yyyy-MM-dd}";
        }
    }
}
