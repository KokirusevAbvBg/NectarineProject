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

    class HRM : ManagmentWorkers
    {
        private List<Employee> staff;

        public List<Employee> Staff
        {
            get { return this.staff; }
        }


        /// <summary>
        /// Creating new HR with new list of Baseworkers
        /// </summary>
        public HRM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            :base(name,age,gender,money,salary,workhours,skill,uniform,ManagementType.HR)
        {
            this.staff = new List<Employee>();
        }
        /// <summary>
        /// Asigns new HR and give it the current list of staff
        /// </summary>
        /// <param name="oldList">the current list of staff</param>
        public HRM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, List<Employee> oldList)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.HR)
        {
            this.staff = oldList;
        }

        public void GetCompanyWorkers(SpaceHolder spaceholder)
        {
            staff = spaceholder.Employees;
        }
        
        public void HireCleaner(string name, byte age, Sex gender, decimal initialMoney)
        {
            BaseWorker cleaner = new Cleaner(name,age,gender,initialMoney,360.00m,4,10,Uniform.Cleaner_uniform,Floors.NotAsigned)
            this.staff.Add(cleaner);
        }

        public void HireSecurity(string name, byte age, Sex gender, decimal initialMoney)
        {
            BaseWorker security = new Security(name,age,gender,initialMoney,700.00m,8,10,Uniform.Security_uniform,Floors.NotAsigned)
            this.staff.Add(security);
        }

        public void HirePromoter(string name, byte age, Sex gender, decimal initialMoney)
        {
            BaseWorker promoter = new Security(name,age,gender,initialMoney,450.00m,4,10,Uniform.Security_uniform,Floors.NotAsigned)
            this.staff.Add(promoter);
        }

        public void Fire(string name, byte age, Uniform uniform)
        {
            var maches = this.Staff.FindAll(empl => ((empl.WorkUniform == uniform) && (empl.Name == name) && (empl.Age == age)));

            foreach (var item in maches)
            {
                this.Staff.Remove(item);
                Console.WriteLine("Employee {0} who is {1} age old is fired!", name, age);
            }
        }

        public void GiveSmallPrommotion(Employee employee)
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
