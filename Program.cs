using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeewagee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant Variable
            int FullTime = 1;                                        //creating a local variable
            int empRatePerHour = 20;

            //Local Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();                           //Generating Random value
            int employeeCheck = random.Next(0, 2);       // assigning Random value to the variable 
            Console.WriteLine("Random Value: " + employeeCheck);

            if (employeeCheck == FullTime)                 //Checking whether Employee is Present or Not
            {
                Console.WriteLine("Employee is PRESENT");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employess is ABSENT");
                empHrs = 0;
            }

            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
            Console.Read();
        }
    }
}
       
