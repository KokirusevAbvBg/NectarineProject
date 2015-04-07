namespace Mall.Staff
{

    using System;
    using System.Collections.Generic;

    using Mall.SpaceHolder;
    using Mall.Interfaces;

    public class Cleaner : BaseWorker,IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties 
        protected List<CleaningStuff> equipment;
        private int cleningQuality;
        
        public int CleningQuality
        {
            get { return cleningQuality; }
            private set { this.cleningQuality = value; }
        }

        //*************************************************************************** Constructors
        public Cleaner()
            : base()
        {
            this.equipment = new List<CleaningStuff>();
            this.CleningQuality = this.Skill + AddedQuality();
        }

        public Cleaner(string name, byte age, Sex gender, decimal money, decimal salary, int workingHours, int skill, Uniform uniform, Floors floor)
            : base(name, age, gender, money, salary, workingHours, skill, uniform, floor)
        {
            this.equipment = new List<CleaningStuff>();
            AddItems(CleaningStuff.Gloves, CleaningStuff.Mop, CleaningStuff.Bucket, CleaningStuff.Rag, CleaningStuff.Usual_Cleanig_Chemical);
            this.CleningQuality = this.Skill + AddedQuality();
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

        public void AddItems(params CleaningStuff[] items)
        {
            foreach (var item in items)
            {
                if (!equipment.Contains(item))
                {
                    equipment.Add(item);
                } 
            }   
        }

        public void RemoveItems(params CleaningStuff[] items)
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
            string cleanerInfo = baseWorkerInfo + string.Format(@"
    Cleaning quality: {0}
    Equipment: {1}",
                   this.CleningQuality, string.Join(", ", equipment));

            return cleanerInfo;
        }
    }
}