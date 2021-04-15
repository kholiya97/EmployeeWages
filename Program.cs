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
        static void Main(string[] args)
        {
            // Constant Variable

            int empRatePerHour = 20;

            //Local Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();                           //Generating Random value
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


            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
            Console.Read();
        }
    }
}
