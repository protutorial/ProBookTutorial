using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritanceEamples
{
    partial class Employee
    {
        public string EmpName
        {
            get { return empName; }

            set
            {
                empName = value;

            }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value;
 }
        }

        public int ID
        {
            get { return id; }
            set { id = value;
 }
        }

        public int CurrentPay
        {
            get { return currentPay; }
            set { currentPay = value; }
        }

        public string SSN
        {
            get { return SocialSecurityNumber; }
        }

        public Employee(string ssn)
        {
            SocialSecurityNumber = ssn;
        }

        public Employee(string name, int age, int id, int pay, string ssn) : this(name, age, id, pay)
        {
            EmpName = name; Age = age; ID = age; CurrentPay = pay; SocialSecurityNumber = ssn;
        }

        public Employee() { }

        //public Employee(string name, int id, int pay)
        //: this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, int pay)
        {
            empName = name;
            empAge = age;
            this.id = id;
            currentPay = pay;
        }
    }
}
