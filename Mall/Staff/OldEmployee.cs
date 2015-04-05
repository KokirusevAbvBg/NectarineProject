namespace Mall.Staff
{
    using System;

    public class OldEmployee
    {
        //Fields
        protected string name;
        protected double salary;
        protected int workingHours;

        //Properties
        public  string Name
        {
            get;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Employee name cannot be null or empty!");
                }
            }
        }

        public double Salary
        {
            get;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Employees must not pay to work!");
                }
            }
        }

        public int WorkingHours
        {
            get;
            private set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentException("Employee must work between 1 and 12 hours a day!");
                }
            }
        }

        //Methods



    }
}

