namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;
    using Mall.SpaceHolder;
    using Mall.Interfaces;
    using Mall.Common;

    public class Security : BaseWorker, IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties 
        protected List<Weapons> equipment;
        private int problemSolving;
        
        public int ProblemSolving
        {
            get { return problemSolving; }
            private set { this.problemSolving = value; }
        }

        //*************************************************************************** Constructors
        public Security()
            : base()
        {
            this.equipment = new List<Weapons>();
            this.ProblemSolving = this.Skill + AddedQuality();
        }

        public Security(string name, byte age, Sex gender, decimal money, decimal salary, int workingHours, int skill, Uniform uniform, Floors floor)
            : base(name, age, gender, money, salary, workingHours, skill, uniform, floor)
        {
            this.equipment = new List<Weapons>();
            AddItems(Weapons.Bat, Weapons.Flashlight, Weapons.Radiostation, Weapons.Teaser, Weapons.Handcuffs);
            this.ProblemSolving = this.Skill + AddedQuality();
        }
        //*************************************************************************** Methods
        private int AddedQuality()
        {
            int result=0;
            foreach (var item in this.equipment)
	        {
            result+= (int)item;
            }
		    return result;
        }

        public void AddItems(params Weapons[] items)
        {
            foreach (var item in items)
            {
                if (!equipment.Contains(item))
                {
                    equipment.Add(item);
                } 
            }   
        }

        public void RemoveItems(params Weapons[] items)
        {
            foreach (var item in items)
            {
                if (equipment.Contains(item))
                {
                    equipment.Remove(item);
                }
            }   
        }

        public override void SmallPromotion()
        {
            this.Salary += 100;
            this.Skill += 15;
        }

        public override void BigPromotion()
        {
            this.Salary += 300;
            this.Skill += 50;
        }

        public override void Discipline()
        {
            this.personalBalance.Pay(200);
            this.Skill += 5;
        }

        public override string ToString()
        {
            string baseWorkerInfo = base.ToString();
            string securityInfo = baseWorkerInfo + string.Format(@"
    Guarding skill: {0}
    Equipment: {1}",
                   this.ProblemSolving, string.Join(", ", equipment));

            return securityInfo;
        }

    }
}