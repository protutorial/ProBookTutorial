using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListExampleEntity;

namespace ListExample
{
    public class Program
    {
        static List<Person> lstPerson = new List<Person>();
        static string name;
        static string age;
        static string city;
        static void Main(string[] args)
        {
            for(int i = 1; i < 3; i++)
            {
                Console.WriteLine($"{i} Person.\n");
                Console.WriteLine($"Name: ");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Age: ");
                age = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"City: ");
                city = Convert.ToString(Console.ReadLine());
                lstPerson.Add(new Person() { Name = name, Age = age, City = city});
            }
            GetPersonDetails(lstPerson);
        }

        static void GetPersonDetails(List<Person> personObject)
        {
            Console.WriteLine("Name\tAge\tCity");
            foreach (Person item in lstPerson)
            {
                Console.WriteLine($"{item.Name}\t{item.Age}\t{item.City}");
            }
        }
    }
}