
using System;

namespace EmployeeAttandance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {

            int empHr = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                empWage = empHr * EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                Console.WriteLine("The daily wage of employee is :" + empWage);

            }
            Console.WriteLine("The monthly wages is : " + totalEmpWage);
        }
    }
}