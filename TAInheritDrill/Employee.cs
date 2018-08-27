using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAInheritDrill
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator== (Employee emp, Employee emp2)
        {
            bool result = false;
            if (emp.Id == emp2.Id)
            {
                result = true;               
            }
            return result;
        }
        public static bool operator!= (Employee emp, Employee emp2)
        {
            bool result = false;
            if (emp.Id != emp2.Id)
            {
                result = true;
            }
            return result;
        }
    }
}
