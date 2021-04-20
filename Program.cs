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