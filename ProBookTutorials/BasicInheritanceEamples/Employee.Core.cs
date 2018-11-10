using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritanceEamples
{
    public abstract partial class Employee
    {
        //Fields
        private string empName;
        private int empAge;
        private string SocialSecurityNumber;
        private int id;
        private int currentPay;

        protected EmployeeBenifitPackage employeeBenifitPackage = new EmployeeBenifitPackage();

        //Methods

        public virtual void GiveBonus(int currPay)
        {
            currentPay += currPay;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee Name: {empName}");
            Console.WriteLine($"Employee Age: {empAge}");
            Console.WriteLine($"Employee SSN: {SocialSecurityNumber}");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Current Pay: {currentPay}");
        }
    }
}
