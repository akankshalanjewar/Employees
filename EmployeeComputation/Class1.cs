using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComputation
{
    public class Class1
    {
        int IS_PRSENT = 1;
        int IS_ABSENT = 0;
        Random random = new Random();
        public void myMethod()
        {
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRSENT)
            {
                Console.WriteLine("Employee Is Present");

            }
            else
            {
                Console.WriteLine("Employee Is Absent");

            }
        }
    }
}