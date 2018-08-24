using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAInheritDrill
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string fullName = FirstName + LastName;
            Console.WriteLine("Your full name is : {0}", fullName);
        }
    }
}
