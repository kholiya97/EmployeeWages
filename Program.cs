using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeewagee
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace EmpWageComputation
	{
		class CompanyEmpWage
		{
			public string company;
			public int empRatePerHour;
			public int numOfWorkingDays;
			public int maxHoursPerMonth;
			public int totalEmpWage;

			public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
			{
				this.company = company;
				this.empRatePerHour = empRatePerHour;
				this.numOfWorkingDays = numOfWorkingDays;
				this.maxHoursPerMonth = maxHoursPerMonth;
			}

			public void setTotalEmpWage(int totalEmpWage)
			{
				this.totalEmpWage = totalEmpWage;
			}

			public string toString()
			{
				return "total EmpWage for company :" + this.company + " is :" + this.totalEmpWage;
			}
		}
        class EmpWageBuilderArray : IComputeEmpWage   //child class
        {
            //constants
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private CompanyEmpWage[] companyEmpWageArray;
            private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

            public EmpWageBuilderArray() //constructor
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
                this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();

            }

            public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
            {//body of interface member
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHourPerMonth);
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHourPerMonth);
                companyToEmpWageMap.Add(company, companyEmpWage);
                numOfCompany++;
            }
            public void computeEmpWage() //body of interface member
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }
            public int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days" + totalWorkingDays + "EmpHrs : " + empHrs);
                }
                return totalEmpHrs * companyEmpWage.empRatePerHour;
            }
            public int getTotalWage(string company) //using get method
            {
                Console.WriteLine("Inside GetTotalWage Method");
                int result = this.companyToEmpWageMap[company].totalEmpWage;
                Console.WriteLine("TotalWage is : {0}", result);
                return result;
            }
        }
        class IComputeEmpWage
        {
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("welcome to employee Program");
                EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();  //creat object of EmpWageBuilderArray class
                empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); //call AddCompany method
                empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
                Console.Read();
            }
        }
    }


}

namespace Employeewage
{       /* UC10 Ability to manage Employee Wage of multiple companies
        */

    class EmployeeWageComputationProblem
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        public EmployeeWageComputationProblem(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + " is :- " + totalempwage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        public int numofCompany = 0;
        private EmployeeWageComputationProblem[] EmployeeWageComputationProblemArray;

        public EmpWageBuilderArray()
        {
            this.EmployeeWageComputationProblemArray = new EmployeeWageComputationProblem[5];
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            EmployeeWageComputationProblemArray[this.numofCompany] = new EmployeeWageComputationProblem(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        public void ComputeEmployeeWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                EmployeeWageComputationProblemArray[i].setTotalEmpWage(this.ComputeEmployeeWage(this.EmployeeWageComputationProblemArray[i]));
                Console.WriteLine(this.EmployeeWageComputationProblemArray[i].toString());
            }
        }
        private int ComputeEmployeeWage(EmployeeWageComputationProblem EmployeeWageComputationProblem)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while (emphrs <= EmployeeWageComputationProblem.maxHoursPerMonth && workingDays < EmployeeWageComputationProblem.numOfWorkingDays)
            {

                workingDays++;
                Random random = new Random();
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
                hrs += emphrs;

                Console.WriteLine("Day " + workingDays + " Emp hrs:- " + emphrs);//Display empwage

                //totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                //empWage = empRatePerHour * emphrs;

            }
            return emphrs * EmployeeWageComputationProblem.empRatePerHour;
        }

    }
    class Program

    {

        public static void Main(String[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();   //Create object of class
            empWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            empWageBuilder.addComapnyEmpWage("Relicance", 10, 4, 20); //call method
            empWageBuilder.ComputeEmployeeWage(); //call method
            Console.ReadLine();
          
        /// <summary>
        /// Creating Program For Employee Wage for Company
        /// </summary>
        public class EmpWageBuilder
        {
            //constants
            const int Full_DAY_HOUR = 8;
            const int PART_TIME_HOUR = 4;
            const int EMP_FULL_TIME = 1;
            const int EMP_PART_TIME = 2;

            string companyName;
            int wagePerHour;
            int maxWorkingHours;
            int maxWorkingDays;
            int wagePerMonth = 0;
            public EmpWageBuilder(String companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
            {
                this.companyName = companyName;
                this.wagePerHour = wagePerHour;
                this.maxWorkingDays = maxWorkingDays;
                this.maxWorkingHours = maxWorkingHours;
            }
            public void ComputeWage()
            {
                //local variables
                int workingHours = 0;
                int workingDays = 0;
                int totalWage = 0;

                //inbuilt class
                Random random = new Random();
                while (workingHours < maxWorkingHours && workingDays < maxWorkingDays)
                {
                    int attendance = random.Next(0, 3);
                    int hoursWorked = 0;

                    //Console.WriteLine("random value " + employeeCheck);

                    //selection statements

                    switch (attendance)
                    {
                        case EMP_FULL_TIME:
                            workingDays += 1;
                            hoursWorked = Full_DAY_HOUR;
                            break;

                        case EMP_PART_TIME:
                            workingDays += 1;
                            hoursWorked = PART_TIME_HOUR;
                            break;

                        default:
                            break;
                    } //end switch
                      //computation

                    workingHours += hoursWorked;
                    wagePerMonth += (wagePerHour * workingHours);
                    totalWage += wagePerMonth;//totalEmpWage=totalWage+wagePerMonth
                } //end while
                  // Console.WriteLine("Emp wage for " + companyName +"\t is\t" +totalEmpWage);

            }
            public override string ToString()
            {
                return $"Wages for the company {companyName}: {wagePerMonth}";
            }
            static void Main(string[] args)
            {
                EmpWageBuilder demart = new EmpWageBuilder("Demart", 20, 20, 10);
                demart.ComputeWage();
                Console.WriteLine(demart.ToString());
                EmpWageBuilder realiance = new EmpWageBuilder("Realiance", 10, 30, 20);
                realiance.ComputeWage();
                Console.WriteLine(realiance.ToString());
                Console.Read();
              }
          
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

        const int FullTime = 1;               //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        public const int maxWorkingHours = 100;
        static void Main(string[] args)
        {
           // Console.WriteLine("Welcome to Employee wage Calculation....");


        const int FullTime = 1;             //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            // Constant Variable


        const int FullTime = 1;                  //creating a local variable
        const int PartTime = 2;
        static void Main(string[] args)
        {
            // Constant Variable



            int FullTime = 1;                       //creating a local variable
        
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

