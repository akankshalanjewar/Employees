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
        int NUM_OF_WORKING_DAY = 20;
        int MAX_RATE_PER_HR = 10;
        int empHrs = 0;
        int empWages = 0;
        int totalWorkingDays = 0;
        int NUM_OR_WORKING_DAYS = 20;
        int totalEmpHrs = 0;
        int totalSalary = 0;
        

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
        public void empWage()
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
            empWages = empHrs * EMP_RATE_PER_HR;

            Console.WriteLine("EmpWages : " + empWages);

       }    
        public void WagesOfMonth()
        {
            for (int i = 0; i < NUM_OF_WORKING_DAY; i++)
            {
                Random random = new Random();
                int randomcheck = random.Next(0, 3);
                switch (randomcheck)
                {
                    case 1:
                        empHrs = 8;
                        break;

                    case 2:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                empWages= (empHrs + EMP_RATE_PER_HR);
                totalSalary = (totalSalary + empWages);




            }
            Console.WriteLine("Total Emp Wages:" + totalSalary);
        }
        public void workingHours()
        {
            while (totalEmpHrs <= MAX_RATE_PER_HR && totalWorkingDays <= NUM_OR_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);

                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;

                    case 2:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "EmpHrs:" + empHrs);


            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("TotalEmpWage:" + totalEmpWage);


        }
    }
}
    

