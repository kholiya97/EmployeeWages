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

        }
    }
}

