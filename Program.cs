using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public static int computeEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsInMonth)
        {

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int total_working_days = 0;
            while (totalEmpHrs <= maxHrsInMonth && total_working_days < numOfWorkingDays)
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
                Console.WriteLine("Day :" + total_working_days + "emp hours" + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total  monthly employee wage :" + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            computeEmpWage("Dmart", 20, 2, 10);
            computeEmpWage("Wipro", 10, 4, 20);
        }
    }
}
