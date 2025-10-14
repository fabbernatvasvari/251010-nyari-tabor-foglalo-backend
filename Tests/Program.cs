using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Program
    {
        public string? FullName { get; set; }

        static void Main(string[] args)
        {
            string ReferenceProject = "MyMvvmApp";
            string className = "MyClass";
            string fullName = $"{ReferenceProject}.{className}";
            if (fullName == null)
            {
                throw new ArgumentNullException(nameof(fullName), "Full name cannot be null.");
            }
            FullName = fullName;
        }
    }
}
