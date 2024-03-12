using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Inheritance.Problem3
{
    internal class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary 
        {
            get { return weekSalary; } 
            
            set 
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Should be more than 10"); 
                }

                weekSalary = value;
            }
        }
        
        public double WorkHoursPerDay 
        {
            get { return workHoursPerDay; }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                workHoursPerDay = value;
            }
        }

        public double SalaryPerHour
        {
            get {  return WeekSalary / (WorkHoursPerDay*5); } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nFirst Name: {FirstName}")
              .AppendLine($"Last Name: {LastName}")
              .AppendLine($"Week Salary: {WeekSalary:F2}")
              .AppendLine($"Hours per day: {WorkHoursPerDay:F2}")
              .AppendLine($"Salary per hour: {SalaryPerHour:F2}");

            return sb.ToString();
        }
    }
}
