using FitnessClubApi.Interfaces;
using FitnessClubApi.Models;

namespace FitnessClubApi.Factories
{
    public class ClubPeopleFactory : IFactory
    {
        public IPerson CreatePerson(string personType, double parametr)
        {
            switch (personType)
            {
                case "client":
                    return new Client { Age = parametr, Name=personType };

                case "worker":
                    return new Worker{ Age = parametr, Name = personType };

                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }


    public class OtherPeopleFactory : IFactory
    {
        public IPerson CreatePerson(string personType, double parametr)
        {
            switch (personType)
            {
                //case "other":
                //    return new Person { Id = parametr, Name = personType };

                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }

    }

}
