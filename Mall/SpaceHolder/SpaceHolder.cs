namespace Mall.SpaceHolder
{
    using System;
    using System.Collections.Generic;
    
    using Mall.Goods;
    using Mall.Interfaces;
    using Mall.Basic;
    using Mall.Common;
    using Mall.Staff;

    public class SpaceHolder : ISellable
    {
        //Fields

        private Company company;

        private Person owner;

        private Booth booth;
        
        private IList<Employee> personal;

        private IList<Sellable> sellables;


        //Constructors

        public SpaceHolder(string companyName, decimal initialBalance, Floors floor, decimal area, decimal rent)
        {
            this.Company = new Company(companyName, initialBalance);
            this.owner = HuamanGenerator.PersonGenerator();
            this.booth = new Booth(floor, area, rent);
            this.personal = new List<Employee>();
            personal.Add(HuamanGenerator.ManagerGenerator(ManagementType.Accountant));
            personal.Add(HuamanGenerator.ManagerGenerator(ManagementType.HR));
            personal.Add(HuamanGenerator.ManagerGenerator(ManagementType.Product_Manager));
            personal.Add(HuamanGenerator.ManagerGenerator(ManagementType.Advertising));
            this.sellables = new List<Sellable>();
        }

        //Properties

        public Booth Booth
        {
            get { return this.booth; }
        }

        public List<Sellable> Sellable
        {
            get;
            set;
        }
        public List<Employee> Employees
        {
            get;
            set;
        }
        public Company Company
        {
            get { return this.company; }
            set
            {
                this.company = value;
            }
        }


        /*

        public void AddServices(string name, decimal price)
        {
            Sellable service = new Services(name, price);
            this.sellables.Add(service);
        }

        public void AddGoods(string type, decimal unitPrice, int quantity)
        {
            decimal balnce = this.owner.personalBalance.ShowBalance();
            decimal totalPrice = unitPrice * quantity;

            if (balnce >= totalPrice)
            {
                Sellable goods = new Goods(type, unitPrice, quantity);
                this.owner.personalBalance.Pay(totalPrice);
                Console.WriteLine("Goods bought from company successful!");
            }

        }
         
         */

    }
}
