using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeewagee
{
    class Program
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;

        public static int ComputeEmployeeWage()
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            Random random = new Random();       //Random Class
            while (hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_DAYS)
            // for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)
            {

                workingDays++;
                int EmpCheack = random.Next(0, 3);      //Random Generate 0 ,1,2
                switch (EmpCheack)          //Switch case Statment
                {
                    case FULL_TIME:         //Employee is FullTime=1
                        emphrs = 8;
                        break;
                    case PART_TIME:          //Employee is FullTime=2
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                empWage = EMP_RATE_PER_HOUR * emphrs;            // Calculate empWage
                hrs += emphrs;                                           //Display empwage
                totalempwage = totalempwage + empWage;      //Calculate total employe month wage
            }
            Console.WriteLine("Employe Wage Per Day :- " + empWage);
            Console.WriteLine("Total Employe Month Wage :- " + totalempwage);
            Console.WriteLine("Employee wage for " + workingDays + " days " + totalempwage);
            Console.WriteLine("Working hours " + hrs);
            return totalempwage;

        }
        public static void Main(string[] args)
        {
            Program.ComputeEmployeeWage();
            Console.ReadLine();

        const int FullTime = 1;                                        //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        public const int maxWorkingHours = 100;
        static void Main(string[] args)
        {
           // Console.WriteLine("Welcome to Employee wage Calculation....");


        const int FullTime = 1;                                        //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            // Constant Variable


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

                empWage = empRatePerHour * empHrs;
                totalHrs = totalHrs + empHrs; //calculting emp hours
                totalEmpWage += empWage; //calculating emp total wage
            } //END of WHILE LOOP

            Console.WriteLine("Employee wage for" + workingDays + " day: " + totalEmpWage);
            Console.WriteLine("Working Hours: " + totalHrs);

                empWage = empRatePerHour * empHrs; //calculating wage with hours
                totalEmpWage += empWage;
            }

            // computation

            Console.WriteLine("Employee Total Wgae: " + totalEmpWage); //final wage foa month


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

