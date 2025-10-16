namespace TestProject1
{
    public class Camp
    {
        private static int _nextId = 1;

        public int Id { get; }

        private DateTime _startDate { get; set; } = DateTime.Today;
        private DateTime _endDate { get; set; } = DateTime.Today.AddDays(7);

        public string Name = "Summer Camp Booker";

        public Camp()
        {
            Id = _nextId++;
        }

        public Camp(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException("Dátumhiba: A befejezés dátuma nem lehet korábbi a kezdés dátumánál.");
            }
            Id = _nextId++;
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