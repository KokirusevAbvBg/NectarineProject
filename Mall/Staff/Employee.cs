
namespace Mall.Staff
{
    using System;
    using Mall.Staff;
    using Mall.Interfaces;
    using Mall.Common;

    public class Employee : Person, IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties 
        private decimal slary;
        private int workhours;
        private int skill;

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
        
        public int Skill
        {
            get { return skill; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Skill increase must be positive!");
                }
                skill = value;
            }
        }

        //*************************************************************************** Constructors
        public Employee() : base()
        {
            this.Salary = 0;
            this.Workhours = 0;
            this.Skill = 10;
        }

        public Employee(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill)
            : base(name, age, gender, money)
        {
            this.Salary = salary;
            this.Workhours = workhours;
            this.Skill = skill;
        }

        //*************************************************************************** Methods
        
        public virtual void SmallPromotion()
        {
            this.Salary += 50;
            this.Skill += 15;
        }

        public virtual void BigPromotion()
        {
            this.Salary += 150;
            this.Skill += 50;
        }

        public virtual void Discipline()
        {
            this.personalBalance.Pay(20);
            this.Skill += 5;
        }

        public void ChangeSkill(int value)
        {
            if (this.skill+value>=0)
            {
                this.skill += value;
            }
            else
            {
                throw new ArgumentException("Skill cannot be changed with such value!");
            }
        }

        public override string ToString()
        {
            string personalInfo = base.ToString();
            string employeeInfo = personalInfo + string.Format(@"
    Salary: {0}
    Working Hours: {1}
    Skill: {2}",
               this.Salary, this.Workhours, this.Skill);
            return employeeInfo;
        }
    }
}
