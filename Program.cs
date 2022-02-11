using System;

namespace EmployeeAttandance
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
                empHr = 8;
            else if (empCheck == IS_PART_TIME)
                empHr = 4;
            else
                empHr = 0;

            empWage = empHr * EMP_RATE_PER_HR;
            Console.WriteLine("The daily wage of employee is :" + empWage);

        }
    }
}
