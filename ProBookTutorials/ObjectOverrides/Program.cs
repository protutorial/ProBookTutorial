using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p1 = new Person("Suri", "Thor", 50);

                Person p2 = new Person("Steve", "Rogers", 55);

                // Get stringified version of objects.
                Console.WriteLine("p1.ToString() = {0}", p1.ToString());
                Console.WriteLine("p2.ToString() = {0}", p2.ToString());

                // Test overridden Equals().
                Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

                // Test hash codes.
                Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
                Console.WriteLine();

                // Change age of p2 and test again.
                p2.Age = 45;
                Console.WriteLine("p1.ToString() = {0}", p1.ToString());
                Console.WriteLine("p2.ToString() = {0}", p2.ToString());
                Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
                Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
                Console.ReadLine();

                // Static members of System.Object.
                Person p3 = new Person("Sally", "Jones", 4);
                Person p4 = new Person("Sally", "Jones", 4);
                Console.WriteLine("P3 and P4 have same state: {0}", Equals(p3, p4));
                Console.WriteLine("P3 and P4 are pointing to same object: {0}", ReferenceEquals(p3, p3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
