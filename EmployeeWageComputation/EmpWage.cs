using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class CompanyEmpWage1
    {
        public string company;
        public int wagePerHour;
        public int maxHoursPerMonth;
        public int maxWorkingDays;
        public int totalWage;

        public CompanyEmpWage1(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.maxWorkingDays = maxWorkingDays;
        }
        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;

        }

        public string toString()
        {
            return "Total Employee Wage for Company  " + this.company + " is " + this.totalWage;
        }
    }
}
