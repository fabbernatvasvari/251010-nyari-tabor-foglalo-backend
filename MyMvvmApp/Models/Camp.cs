using System;
namespace MyMvvmApp.Models
{
    public class Camp
    {
        private static int _nextId = 1;

        public int Id { get; }

        private DateTime _startDate { get; set; } = DateTime.Today;
        private DateTime _endDate { get; set; } = DateTime.Today.AddDays(7);

        public Camp()
        {
            Id = _nextId++;
        }

        public Camp(DateTime startDate, DateTime endDate)
        {
            Id = _nextId++;
            _startDate = startDate;
            _endDate = endDate;
        }

        public override string ToString()
        {
            return $"{_startDate:yyyy-MM-dd} → {_endDate:yyyy-MM-dd}";
        }
    }
}
