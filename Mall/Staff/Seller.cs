namespace Mall.Staff
{
    
    using System;
    using System.Collections.Generic;
    using Mall.SpaceHolder;
    using Mall.Interfaces;
    using Mall.Common;

    public class Seller : BaseWorker, IPerson, IEmployee, IPromote
    {
      //*************************************************************************** fields/Properties 
        protected List<Responsibilities> responsibilities;
        private int serviceQuality;
        
        public int ServiceQuality
        {
            get { return serviceQuality; }
            private set { this.serviceQuality = value; }
        }

        //*************************************************************************** Constructors
        public Seller()
            : base()
        {
            this.responsibilities = new List<Responsibilities>();
            this.ServiceQuality = this.Skill + AddedQuality();
        }

        public Seller(string name, byte age, Sex gender, decimal money, decimal salary, int workingHours, int skill, Uniform uniform, Floors floor)
            : base(name, age, gender, money, salary, workingHours, skill, uniform, floor)
        {
            this.responsibilities = new List<Responsibilities>();
            AddItems(Responsibilities.Sell, Responsibilities.Assist_Clients);
            this.ServiceQuality = this.Skill + AddedQuality();
        }
        //*************************************************************************** Methods
        private int AddedQuality()
        {
            int result=0;
            foreach (var item in this.responsibilities)
	        {
            result+= (int)item;
            }
		    return result;
        }

        public void AddItems(params Responsibilities[] items)
        {
            foreach (var item in items)
            {
                if (!responsibilities.Contains(item))
                {
                    responsibilities.Add(item);
                } 
            }   
        }

        public void RemoveItems(params Responsibilities[] items)
        {
            foreach (var item in items)
            {
                if (responsibilities.Contains(item))
                {
                    responsibilities.Remove(item);
                }
            }   
        }

        public override void SmallPromotion()
        {
            this.Salary += 150;
            this.Skill += 15;
        }

        public override void BigPromotion()
        {
            this.Salary += 400;
            this.Skill += 45;
        }

        public override void Discipline()
        {
            this.personalBalance.Pay(100);
            this.Skill += 5;
        }

        public override string ToString()
        {
            string baseWorkerInfo = base.ToString();
            string sellerInfo = baseWorkerInfo + string.Format(@"
    Service Quality: {0}
    Responsibilities: {1}",
                   this.ServiceQuality, string.Join(", ", responsibilities));

            return sellerInfo;
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

    }
}