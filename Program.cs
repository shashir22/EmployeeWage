using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 20;
        static void Main(string[] args)
        {

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int total_working_days = 0;
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && total_working_days < NUM_OF_WORKING_DAYS)
            {
                total_working_days++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }

                totalEmpHrs += empHrs;
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total  moEnthly mployee wage :" + totalEmpWage);

        }
    }
}
