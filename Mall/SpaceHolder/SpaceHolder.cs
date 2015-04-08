namespace Mall.SpaceHolder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
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
        
        private List<BaseWorker> personal;

        private HRM humanResourse;

        private AccountantM accountant;

        private AddM advertisingManager;

        private ProductM productManager;

        private List<Goods> goods;

        private List<Services> services;

        //Constructors

        public SpaceHolder(string companyName, decimal initialBalance, Floors floor, decimal area, decimal rent)
        {
            this.Company = new Company(companyName, initialBalance);
            this.owner = HuamanGenerator.PersonGenerator();
            this.booth = new Booth(floor, area, rent);
            this.personal = new List<BaseWorker>();
            
            this.accountant = HuamanGenerator.AccountantGenerator();
            this.humanResourse = HuamanGenerator.HRMGenerator();
            this.advertisingManager = HuamanGenerator.AddvertisingManagerGenerator();
            this.productManager = HuamanGenerator.ProductManagerGenerator();

            this.goods = new List<Goods>();
            this.services = new List<Services>();
        }

        //Properties

        public HRM HumanResourse
        {
            get { return this.humanResourse; }
        }

        public AccountantM Accountant
        {
            get
            {
                return this.accountant;
            }
        }
        
        public ProductM ProductManager
        {
            get { return this.productManager; }
        }

        public AddM AdvertisingManager
        {
            get
            {
                return this.advertisingManager;
            }
        }

        public Booth Booth
        {
            get { return this.booth; }
        }

        public List<Goods> Goods
        {
            get { return this.goods; }
            protected set { this.goods = value; }
        }

        public List<Services> Services
        {
            get { return this.services; }
            protected set { this.services = value; }
        }

        public List<BaseWorker> Employees
        {
            get
            {
                return this.personal;
            }
            private set 
            {
                this.personal = value;
            }

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
