using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeewagee
{
    class Program
    {
            const int FullTime = 1;                                        //creating a local variable
            const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            // Constant Variable

            int empRatePerHour = 20;

            //Local Variables
            int empHrs = 0;
            int empWage = 0;
            int workingDays = 1;
            int totalEmpWage = 0;

            Random random = new Random();                           //Generating Random value
            while (workingDays <= maxWorkingDays)
            {
                workingDays++;
                int employeeCheck = random.Next(0, 3);                  // assigning Random value to the variable 
                Console.WriteLine("Random Value: " + employeeCheck);

                //using Case statement 
                switch (employeeCheck)
                {
                    case FullTime:
                        empHrs = empHrs + 8;
                        break;

                    case PartTime:
                        empHrs = empHrs + 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empRatePerHour * empHrs; //calculating wage with hours
                totalEmpWage += empWage;
            }

            // computation

            Console.WriteLine("Employee Total Wgae: " + totalEmpWage); //final wage foa month
            Console.Read();
        }
    }
}
 