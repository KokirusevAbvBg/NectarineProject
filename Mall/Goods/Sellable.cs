
namespace Mall.Goods
{
    using System;
    using Mall.Interfaces;
    using Mall.Basic;
    using Mall.SpaceHolder;

    abstract class Sellable : ISellable
    {
        private decimal price;
        private string name;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price can not be less than zero!");
                }
            }
            
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validators.CheckNullEmptyString(value, "Sellable Name");
                this.name = value;
            }
        }


        public abstract void Sell(SpaceHolder spaceholder)
        {
            spaceholder.Company.CompanyAccount.GetPaid(this.Price);
        }

        public abstract void MakeDiscount(decimal percent)
        {
            this.Price -= this.Price * (percent / 100);
        }


    }

}
