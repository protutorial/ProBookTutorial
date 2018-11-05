using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        public enum EmpType
        {
            Manger = 2,
            SrManager,
            ProgramManager,
            Director,
            SeniorDirector
        }

        static void Main(string[] args)
        {
            JustAMethod(); 
        }

        public static void JustAMethod()
        {
            Console.WriteLine("Please Select your Designation");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Sr. Manager");
            Console.WriteLine("3. Program Manager");
            Console.WriteLine("4. Director");
            Console.WriteLine("5. Senior Director");

            int choosedOne = Convert.ToInt32(Console.ReadLine());

            EmpType empType = (EmpType)choosedOne;

            string choosedDesignation = empType.ToString();
        }

        static void AnotherNewMethod()
        {

        }

    }

    class Car
    {

    }
}
