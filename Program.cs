using System;

namespace CSharp_Programming
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        
        static void Main(string[] args)
        {
            //Variables 
            int emphrs = 0, empwage 0, total EmpWage-0;
            //Computation 
            for(int day 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random new Random(); 
                int empCheck= random.Next(0, 3);
                switch (empCheck)
                {
                    case IS PART_TIME:
                         empHrs = 4;
                         break;

                    case IS FULL_TIME:
                         empHrs = 8;
                         break;

                    default:
                        empHrs = 0;
                        break;
                }

                empwage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage:" + empilage);
            }
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        }
    }
}
