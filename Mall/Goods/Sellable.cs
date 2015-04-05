
namespace Mall.Goods
{
    using System;  

    abstract class Sellable : ISellable
    {
        private decimal price;
        
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

        public abstract void Sell(string name)
        {
            
        }

        public abstract void MakeDiscount(decimal percent)
        {
            this.Price -= this.Price * (percent / 100);
        }
    }

}
