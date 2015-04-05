
namespace Mall.Staff
{
    using System;
    using Mall.Basic;

    class Employee : Person, IPerson, IEmployee
    {
        //*************************************************************************** fields/Properties 
        private decimal slary;
        private int workhours;

        public decimal Salary
        {
            get
            {
                return this.slary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Employees must not pay to work!");
                }
                this.slary = value;
            }
        }

        public int Workhours
        {
            get
            {
                return this.workhours;
            }
            set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentException("Employee must work between 1 and 12 hours a day!");
                }
                this.workhours = value;
            }
        }

        //*************************************************************************** Constructors
        public Employee() : base()
        {
            this.Salary = 0;
            this.Workhours = 0;
        }

        public Employee(string name, byte age, Sex gender, decimal money, decimal salary, int workhours)
            : base(name, age, gender, money)
        {
            this.Salary = salary;
            this.Workhours = workhours;
        }

    }
}
