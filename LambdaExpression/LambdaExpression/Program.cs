using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            RetrieveRecordsLessThanForty(listPersonInCity);
        }

        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person(101, "Leenu", 25));
            listPersonInCity.Add(new Person(101, "Amit", 30));
            listPersonInCity.Add(new Person(101, "Anita", 45));
        }

        private static void RetrieveRecordsLessThanForty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll( e => (e.Age<=40)).ToList())
            {
                Console.WriteLine("Name : "+ person.Name + " \t\tAge: "+ person.Age);
            }
        }


    }


}
