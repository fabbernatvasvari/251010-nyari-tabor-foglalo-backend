using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Shared.Models
{
    internal class Camper : Child
    {
        private List<Erzekenyseg> _erzekenysegek = new List<Erzekenyseg>();
        public Camper() : base()
        {
        }
        public Camper(string name, DateOnly birthDate) : base(name, birthDate)
        {
        }
        public List<Erzekenyseg> Erzekenysegek { get; set; }
    }
}
