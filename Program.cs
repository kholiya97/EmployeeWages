using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
	class CompanyEmpWage
	{ //instance variable
		public string company;
		public int empRatePerHour;
		public int numOfWorkingDays;
		public int maxHoursPerMonth;
		public int totalEmpWage;

		public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) //parameterized constructer
		{
			//invoke current class constructor
			this.company = company;
			this.empRatePerHour = empRatePerHour;
			this.numOfWorkingDays = numOfWorkingDays;
			this.maxHoursPerMonth = maxHoursPerMonth;
		}

		public void setTotalEmpWage(int totalEmpWage) //set method
		{
			this.totalEmpWage = totalEmpWage;
		}

		public string toString() //instance method 
		{
			return "total EmpWage for company :" + this.company + " is :" + this.totalEmpWage;
		}
	}
    class EmpWageBuilderArray : IComputeEmpWage   //child class
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWaeList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray() //constructor
        {
            this.companyEmpWaeList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();

        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {//body of interface member
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHourPerMonth);
            this.companyEmpWaeList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }
        public void computeEmpWage() //body of interface member
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWaeList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0; //variables
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
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void computeEmpWage();
        int getTotalWage(string company);
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
            Console.WriteLine("Total Wage for DMart Comapny " + empWageBuilder.getTotalWage("DMart"));
            Console.Read();
        }


    }
}

