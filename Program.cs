using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeewagee
{
    class Program
    {
        
        /// <summary>
        /// Creating Multiple Company
        /// </summary>
        //constants
        public const int Full_TIME = 1;
        public const int PART_TIME = 2;
        //public const int EMP_RATE_PER_HR = 20;
        //public const int MAX_WORKING_DAYS = 20;
        //public const int MAX_WORKING_HRS = 100;

        public static void ComputeWage(String companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int WorkingDays = 1;


            //inbuilt class
            Random random = new Random();
            while (hrs < maxWorkingHours && WorkingDays <= maxWorkingDays)
            {
                WorkingDays++;
                int employeeCheck = random.Next(0, 3);

                //Console.WriteLine("random value " + employeeCheck);

                //selection statements

                switch (employeeCheck)
                {
                    case Full_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                //computation
                empWage = wagePerHour * empHrs;
                hrs = empHrs;
                totalEmpWage += empWage;//totalEmpWage=totalWage+empWage
            }
            Console.WriteLine("Emp wage for " + companyName + "\t is\t" + totalEmpWage);

        }
        static void Main(string[] args)
        {
            ComputeWage("Demart", 20, 20, 40);
            ComputeWage("Reliance", 15, 15, 30);
            Console.Read();

        }
    }
}
   
