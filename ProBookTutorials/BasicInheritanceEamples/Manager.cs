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

        public Manager(string name, int age, int id, int pay, string ssn, int salesCount): base(name, age, id, pay)
        {
            StockOptions = salesCount;
        }

        public Manager()
        {

        }

        public override void GiveBonus(int currPay)
        {
            int mgrBonus = 0;
            if (StockOptions >= 0 && StockOptions <= 100)
            {
                mgrBonus = 10;
            }
            else
            {
                if (StockOptions >= 101 && StockOptions <= 200)
                    mgrBonus = 15;
                else
                    mgrBonus = 20;
            }
            base.GiveBonus(currPay * mgrBonus);
        }
    }
}
