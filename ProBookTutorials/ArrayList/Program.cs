using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.AddRange(new string[] { "Hello", "One", "Two"});

            Console.WriteLine($"The Length of the Array is {arrayList.Count}");

            arrayList.AddRange(new int[] { 1, 2, 3, 4});

            Console.WriteLine($"The Length of the Array is {arrayList.Count}");

            arrayList.Add(true);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
