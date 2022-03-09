using System;

namespace EmployeeComputation
{
    public class Class1
    {
        int IS_PRSENT = 1;
        int IS_ABSENT = 0;
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int EMP_RATE_PER_HR = 20;
        int NUM_OF_WORKING_DAY = 20;
        int empHrs = 0;
        int empWage = 0;
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
        public void empWages()
        {


            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRSENT)
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
        public void partTimeFullTime()
        {
            for (int i = 0; i < NUM_OF_WORKING_DAY; i++)
            {

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

                empWage = (empHrs + EMP_RATE_PER_HR);
                totalSalary = (totalSalary + empWage);




            }
            Console.WriteLine("Total Emp Wages:" + totalSalary);

        }
    }

}