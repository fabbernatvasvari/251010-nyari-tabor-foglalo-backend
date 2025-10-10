using System;
using MyMvvmApp.Models;
namespace MyMvvmApp.Repos
{
    public class CampRepo
    {
        private List<Camp> _camps = new List<Camp>()
        {
            new Camp(new DateTime(2024, 6, 15), new DateTime(2024, 6, 22)),
            new Camp(new DateTime(2024, 7, 1), new DateTime(2024, 7, 8)),
            new Camp(new DateTime(2024, 8, 5), new DateTime(2024, 8, 12))
        };

        public CampRepo()
        {

        }

        public IReadOnlyList<Camp> GetAll() => _camps.AsReadOnly(); // _camps.ToList();

        public void Remove(Camp camp) => _camps.Remove(camp);
    }	
}