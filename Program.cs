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



            int FullTime = 1;                                        //creating a local variable

            int PartTime = 2

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

 
            int employeeCheck = random.Next(0, 3);                  // assigning Random value to the variable 
            Console.WriteLine("Random Value: " + employeeCheck);


            if (employeeCheck == FullTime)                          //Checking whether Employee is Present or Not

            int employeeCheck = random.Next(0, 2);       // assigning Random value to the variable 
            Console.WriteLine("Random Value: " + employeeCheck);

            if (employeeCheck == FullTime)                 //Checking whether Employee is Present or Not

            {
                Console.WriteLine("Employee is PRESENT");
                empHrs = 8;
            }

            else if (employeeCheck == PartTime)
            {
                Console.WriteLine("Part Time Empoyee: ");
                empHrs = 4;
            }


            else
            {
                Console.WriteLine("Employess is ABSENT");
                empHrs = 0;
            }



            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);

            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);

            int Present = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            Console.WriteLine("EmpCheck: " + EmpCheck);

            if (EmpCheck == Present)
            {
                Console.WriteLine("Employee PRESENT");
            }
            else
            {
                Console.WriteLine("Employee ABSENT");
            }



            Console.Read();
        }
    }
}

        


       


