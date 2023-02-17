using FitnessClubApi.Factories;
using FitnessClubApi.Interfaces;
using FitnessClubApi.Models;

namespace FitnessClubApi.Utilites
{
    public class Programm
    {

        public static IPerson ReturnPerson()
        {
            IFactory PeopleFactory = new ClubPeopleFactory();
            IPerson client = PeopleFactory.CreatePerson("client", 43);
            IPerson worker = PeopleFactory.CreatePerson("worker", 23);

            PeopleFactory = new OtherPeopleFactory();
            IPerson man = PeopleFactory.CreatePerson("other", 33);


            return client;
        }

        public static List<Person> ReturnListOfPeople()
        { 
         IFactory PeopleFactory1 = new ClubPeopleFactory();
         IPerson client1 = PeopleFactory1.CreatePerson("client", 43);
         IPerson worker1 = PeopleFactory1.CreatePerson("worker", 23);

         PeopleFactory1 = new OtherPeopleFactory();
         IPerson man1 = PeopleFactory1.CreatePerson("other", 33);

            List<Person> list = new List<Person>();
            list.Add((Person)client1);
            list.Add((Person)worker1);
            list.Add((Person)man1);

            return list;

         }





}
}
