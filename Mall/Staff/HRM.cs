namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    
    using Mall.Goods;
    using Mall.SpaceHolder;
    using Mall.Interfaces;
    using Mall.Common;
    using Mall.Basic;

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
        public HRM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            :base(name,age,gender,money,salary,workhours,skill,uniform,ManagementType.HR)
        {
            this.staff = new List<BaseWorker>();
        }
        /// <summary>
        /// Asigns new HR and give it the current list of staff
        /// </summary>
        /// <param name="oldList">the current list of staff</param>
        public HRM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, List<BaseWorkervar> oldList)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.HR)
        {
            this.staff = oldList;
        }

        public void GetCompanyWorkers(SpaceHolder spaceholder)
        {
            staff = spaceholder.Employees;
        }
        
        public void HireCleaner()
        {
            var cleaner = HuamanGenerator.CreateCleaner();
        }

        public void HireSecurity()
        {
            var security = HuamanGenerator.CreateSecurity();
            this.staff.Add(security);
        }

        public void HirePromoter()
        {
            var promoter = HuamanGenerator.CreatePromoter();
            this.staff.Add(promoter);
        }

        public void Fire(string name, byte age)
        {
            var maches = this.Staff.FindAll(empl => ((empl.Name == name) && (empl.Age == age)));

            foreach (var item in maches)
            {
                this.Staff.Remove(item);
                Console.WriteLine("Employee {0} who is {1} age old is fired!", name, age);
            }
        }

        public void GiveSmallPrommotion(BaseWorker employee)
        {
           
            employee.SmallPromotion();
        }

        public void GiveBigPromotion(Employee employee)
        {
            employee.BigPromotion();
        }

        public void PrintAllWorkers(SpaceHolder spaceholder)
        {
            Console.WriteLine("List of workers of {0}", spaceholder.Company.CompanyName);
            var employeelist = spaceholder.Employees;
            foreach (var item in employeelist)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
