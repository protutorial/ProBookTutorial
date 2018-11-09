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

        public override sealed void GiveBonus(int currPay)
        {
            int salesBonus = 0;
            if(SalesCount >= 0 && SalesCount <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                    if (SalesCount >= 101 && SalesCount <= 200)
                        salesBonus = 15;
                    else
                        salesBonus = 20;
            }
            base.GiveBonus(currPay * salesBonus);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"The Sales Count is : {SalesCount}");
        }
    }
}
