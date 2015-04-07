namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Mall.Goods;
    using Mall.SpaceHolder;

    class HRM : ManagmentWorkers
    {
        private List<BaseWorker> staff;

        public List<BaseWorker> Staff
        {
            get { return this.staff; }
        }
        
        /// <summary>
        /// Creating new HR with new list of Baseworkers
        /// </summary>
        public AccountantM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            :base(name,age,gender,money,salary,workhours,skill,uniform,ManagementType.Accountant)
        {
            this.sales = new List<Sellable>();
        }
        /// <summary>
        /// Asigns new Accountant and give it the current list of sales
        /// </summary>
        /// <param name="oldList">the current list of sales</param>
        public AccountantM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, List<Sellable> oldList)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.Accountant)
        {
            this.sales = oldList;
        }
    }
}
