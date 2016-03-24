using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Worker:Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName,double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                try
                {
                    this.weekSalary = value;
                }
                catch (FormatException Fe)
                {
                    throw Fe;
                }
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                try
                {
                    this.workHoursPerDay = value;
                }
                catch (FormatException Fe)
                {                    
                    throw Fe;
                }
            }
        }

        internal double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }
        public override string ToString()
        {
            return String.Format("0, week salary:{1}, work hour per day:{2}, money per hour:{3}", base.ToString(), WeekSalary, WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
