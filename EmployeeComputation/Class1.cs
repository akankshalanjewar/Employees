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
        int EMP_RATE_PER_HR = 20;
        int empHrs = 0;
        int empWage = 0;

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
        public void empWages()
        { 
        

        int empCheck = random.Next(0, 2);
            if(empCheck==IS_PRSENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;

            Console.WriteLine("EmpWage : " + empWage);

       }      
    }

}