using FitnessClubApi.Interfaces;

namespace FitnessClubApi.Models
{
    public abstract class Person : IPerson
    {
        public double Id { get; set; }
        public string Name { get; set; }

        public double Age { get; set; }    
    }
}
