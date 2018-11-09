using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritanceEamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson salesPerson = new SalesPerson()
            {
                EmpName = "Suri", Age = 15, CurrentPay = 22_000, ID = 15, SalesCount = 15
            };

            //salesPerson.EmpName = "Suri";
            //salesPerson.Age = 20;
            //salesPerson.ID = 112;
            //salesPerson.CurrentPay = 22_000;

            salesPerson.Display();

        }
    }
}
