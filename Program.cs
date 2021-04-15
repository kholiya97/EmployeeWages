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
        public const int maxWorkingHours = 100;
        static void Main(string[] args)
        {
           // Console.WriteLine("Welcome to Employee wage Calculation....");

            //Local Variables
            int empHrs = 0;
            int empWage = 0;
            int workingDays = 1;
            int totalEmpWage = 0;
            int totalHrs = 0;

            Random random = new Random();                           //Generating Random value
            while (totalHrs < maxWorkingHours && workingDays < maxWorkingDays)
            {
                workingDays++;
                int employeeCheck = random.Next(0, 3);                      // assigning Random value to the variable 
                                                                            // Console.WriteLine("Random Value: " + employeeCheck);

                //USING SWITCH STATEMENT
                switch (employeeCheck)
                {
                    case FullTime:
                        empHrs = 8;
                        break;

                    case PartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empRatePerHour * empHrs;
                totalHrs = totalHrs + empHrs; //calculting emp hours
                totalEmpWage += empWage; //calculating emp total wage
            } //END of WHILE LOOP

            Console.WriteLine("Employee wage for" + workingDays + " day: " + totalEmpWage);
            Console.WriteLine("Working Hours: " + totalHrs);
            Console.Read();
        }
    }
}
   
