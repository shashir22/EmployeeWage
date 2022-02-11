using System;

namespace EmployeeAttandance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {

            int empHr = 0;
            int totalEmpHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHr;
                Console.WriteLine("Day " + totalWorkingDays + ": Employee hour :" + empHr);

            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total employee wages is : " + totalEmpWage);
        }
    }
}