namespace ConsoleApp1.Shared.Models
{
    internal class User
    {
        private int _id;
        private string _name;
        private DateOnly _birthDate;
        private string _email;
        private string _password;

        private static int _nextId = 1;
        private DateOnly _createdAt = DateOnly.FromDateTime(DateTime.Now);


        public User(string name, int age, string email, string password)
        {
            _id = _nextId++;
            _name = name;
            _birthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-age)); // Addyears hozzáad `-age` évet == kivon `age` évet.
            _email = email;
            _password = password;
        }

        public User(object name, object age, object email, object password)
        {
            _id = _nextId++;
            _name = name.ToString();
            _birthDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-Convert.ToInt32(age))); // Addyears hozzáad `-age` évet == kivon `age` évet.
            _email = email.ToString();
            _password = password.ToString();
        }

        public int Id { get => _id; }
        public string Name { get => _name; set => _name = value; }
        public DateOnly BirthDate { get => _birthDate; private set => _birthDate = value; }
        public string Email { get => _email; private set => _email = value; }
        public string Password { get => _password; private set => _password = value; }
    }
}