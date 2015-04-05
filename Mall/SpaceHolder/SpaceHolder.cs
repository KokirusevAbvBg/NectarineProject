namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;

    public class SpaceHolder
    {
        //Fields

        private decimal bankBalance;

        private string owner;

        private string companyName;

        //Constructors

        public SpaceHolder(string companyName, string owner, decimal bankBalance, Booth Booth)
        {
            this.CompanyName = companyName;
            this.Owner = owner;
            this.BankBalance = bankBalance;
            this.Boot = Booth;
            this.Personal = Personal;
            this.Sellable = Sellable;
        }

        //Properties

        public Booth Boot { get; private set; }

        public IList<Employee> Personal { get; private set; }

        public IList<ISellable> Sellable { get; private set; }

        public decimal BankBalance
        {
            get { return this.bankBalance; }
            private set { this.bankBalance = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter owner of the company, using this space");
                }
                this.owner = value;
            }
        }
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

        //Methods      // TO DO - May be some method - if bankBalance is less than zero - company should leave the mall

    }
}
