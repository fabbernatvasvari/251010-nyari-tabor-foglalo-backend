using System;
namespace MyMvvmApp.Models
{
    public class Camp
    {
        private int _id;
        private static int _nextId = 1;

        public DateTime startDate = DateTime.Today;
        public DateTime endDate = DateTime.Today.AddDays(7);
        public Camp()
        {
            _id = _nextId++;
        }

        public Camp(DateTime startDate, DateTime endDate)
        {
            _id = _nextId++;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
