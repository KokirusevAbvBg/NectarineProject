using Mall.SpaceHolder;
namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;

    public class SpaceHolder
    {
        //Fields

        private string companyName;

        private Person owner;

        private IList<Employee> personal;

        private IList<ISellable> sellable;

        //Constructors

        public SpaceHolder(string companyName, Person owner, Booth Booth)
        {
            this.CompanyName = companyName;
            this.owner = owner;
            this.Boot = Booth;
            this.personal = new List<Employee>();
            this.sellable = new List<ISellable>();
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

        //Methods      // TO DO - May be some method - if bankBalance is less than zero - company should leave the mall

    }
}
