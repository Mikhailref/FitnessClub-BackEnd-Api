using FitnessClubApi.Interfaces;
using FitnessClubApi.Models;

namespace FitnessClubApi.Factories
{
    public interface IFactory
    {
        public IPerson CreatePerson(string personType, double parametr);
     
    }
}
