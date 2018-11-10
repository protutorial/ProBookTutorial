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

            salesPerson.Display();

            object suri = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

            Employee newEmployee = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

            //SalesPerson newSalesPerson = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

            GivePromotion((Employee)suri);

        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine($"{emp.EmpName} is Promoted !!!");
        }
    }
}
