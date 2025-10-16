using System;
namespace MyMvvmApp.Models
{
    public class Camp
    {
        private static int _nextId = 1;

        public int Guid { get; }

        private DateTime _startDate { get; set; } = DateTime.Today;
        private DateTime _endDate { get; set; } = DateTime.Today.AddDays(7);

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
            Guid = _nextId++;
            _startDate = startDate;
            _endDate = endDate;
        }

        public static void ResetIdCounter()
        {
            _nextId = 1;
        }

        public override string ToString()
        {
            return $"Camp named {Name} between {_startDate:yyyy-MM-dd} and {_endDate:yyyy-MM-dd}";
        }
    }
}
