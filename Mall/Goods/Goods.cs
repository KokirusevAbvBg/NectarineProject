namespace Mall.Goods
{
    
    using System;
    using Mall.Interfaces;

    public class Goods : Sellable, ISellable
    {
        //Fields
        private string goodType;
        private int quantity;
        
        //Constructors

        public Goods(string goodType, decimal price, int quantity)
        {
            this.GoodType = goodType;
            this.Price = price;
            this.Quantity = quantity;
        }
        //Enums

        //Interfaces

        //Properties
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value >= 0)
                {
                    this.quantity = value;
                }
                else
                {
                    throw new ArgumentException("The quantity of the goods can not be less than zero");
                }
            }
        }
        public string GoodType
        {
            get
            {
                return this.goodType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Good type name cannot be null or empty!");
                }
                this.goodType = value;
            }
        }



        //Methods
        public override string ToString()
        {
            string productInfo = string.Format(@"
    GoodsInfo:
    Type: {0}
    Price: {1}
    Quantity: {2}",
                  this.GoodType, this.Price, this.Quantity);
            return productInfo;
        }        
    }
}