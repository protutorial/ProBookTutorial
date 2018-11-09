using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritanceEamples
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string name, int age, int id, int pay, string ssn, int salesCount): base(name, age, id, pay, ssn)
        {
            StockOptions = salesCount;
        }

        public Manager()
        {

        }
    }
}
