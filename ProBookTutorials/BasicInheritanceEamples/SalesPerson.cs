using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritanceEamples
{
    class SalesPerson : Employee
    {
        public int SalesCount { get; set; }

        public SalesPerson(string name, int age, int id, int pay, string ssn, int salesCount) : base(name, age, id, pay, ssn)
        {
            SalesCount = salesCount;
        }

        public SalesPerson()
        {

        }
    }
}
