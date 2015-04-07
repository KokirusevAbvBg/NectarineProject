namespace Mall.Staff
{
    using Mall.SpaceHolder;
    using System;
    using System.Collections.Generic;
    using Mall.Goods;
    using Mall.Interfaces;

    public class SpaceHolder :ISellable
    {
        //Fields

        private string companyName;

        private Person owner;

        private IList<Employee> personal;

        private IList<Sellable> sellables;

        //Constructors

        public SpaceHolder(string companyName, Person owner, Booth Booth)
        {
            this.CompanyName = companyName;
            this.owner = owner;
            this.Boot = Booth;
            this.personal = new List<Employee>();
            this.sellables = new List<Sellable>();
        }

        //Properties

        public Booth Boot { get; private set; }

        public string CompanyName
        {
            get { return this.companyName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter correct name for the company, using this space");
                }
                this.companyName = value;
            }
        }

       

        //Enums

        //Interfaces

        //Methods      

        public void AddServices(string name, decimal price)
        {
            Sellable service = new Services(name, price);
            this.sellables.Add(service);
        }

        public void AddGoods(string type, decimal unitPrice, int quantity)
        {
            decimal balnce = this.owner.personalBalance.ShowBalance();
            decimal totalPrice = unitPrice*quantity;

            if (balnce >= totalPrice)
            {
                Sellable goods = new Goods(type, unitPrice, quantity);
                this.owner.personalBalance.Pay(totalPrice);
                Console.WriteLine("Goods bought from company successful!");
            }
            
        }

        public void Sell(string name)
        {
            throw new NotImplementedException();
            //must be linq expression to this.sellables
        }

        public void MakeDiscount(decimal percent)
        {
            throw new NotImplementedException();
            //must be linq expression to this.sellables
            //this.Price -= this.Price * (percent / 100);
        }
    }
}
