using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    public class Person : object
    {
        public string FirstName { get; set; } = "Surendra";

        public string LastName { get; set; } = "Reddy";

        public int Age { get; set; } = 23;

        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            string strInfo = "First Name : " + FirstName + ", " + "Last Name : " + LastName + ", " + "Age: " + Age;

            return strInfo;
        }

        public override bool Equals(object obj) => obj?.ToString() == ToString();

        public override int GetHashCode() => ToString().GetHashCode();
    }
}
