namespace Mall.Staff
{
    
    using System;
    using System.Collections.Generic;

    using Mall.SpaceHolder;

    public class Promoter : BaseWorker, IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties 
        protected List<PromotionMaterials> equipment;
        private int adverisingSkill;
        
        public int AdverisingSkill
        {
            get { return adverisingSkill; }
            private set { this.adverisingSkill = value; }
        }

        //*************************************************************************** Constructors
        public Promoter()
            : base()
        {
            this.equipment = new List<PromotionMaterials>();
            this.AdverisingSkill = this.Skill + AddedQuality();
        }

        public Promoter(string name, byte age, Sex gender, decimal money, decimal salary, int workingHours, int skill, Uniform uniform, Floors floor)
            : base(name, age, gender, money, salary, workingHours, skill, uniform, floor)
        {
            this.equipment = new List<PromotionMaterials>();
            AddItems(PromotionMaterials.Leaflets);
            this.AdverisingSkill = this.Skill + AddedQuality();
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

        public void AddItems(params PromotionMaterials[] items)
        {
            foreach (var item in items)
            {
                if (!equipment.Contains(item))
                {
                    equipment.Add(item);
                } 
            }   
        }

        public void RemoveItems(params PromotionMaterials[] items)
        {
            foreach (var item in items)
            {
                if (equipment.Contains(item))
                {
                    equipment.Remove(item);
                }
            }   
        }

        public override string ToString()
        {
            string baseWorkerInfo = base.ToString();
            string promoterInfo = baseWorkerInfo + string.Format(@"
    Advertising skill: {0}
    Equipment: {1}",
                   this.AdverisingSkill, string.Join(", ", equipment));

            return promoterInfo;
        }
    }
}