namespace Mall.Staff
{
    using System;

    public class Goods : ISellable
    {
        //Fields
        private decimal price;
        private int quantity;
        private GoodType goodType;
        //Constructors

        public Goods(decimal price,int quantity,GoodType goodType)
        {
            this.Price = price;
            this.Quantity = quantity;
            this.GoodType = goodType;
        }
        //Enums

        //Interfaces

        //Properties
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value>0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price of the goods can not be less than zero");
                }
            }
        }
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    throw new ArgumentException("The quantity of the goods can not be less than zero");
                }
            }
        }
        public GoodType GoodType
        {
            get
            {
                return this.goodType;
            }
            set
            {
                this.goodType = value;
            }
        }



        //Methods
        public void Sell(Goods good)
        {
            throw new NotImplementedException();   // We must create something like a budget of the mall and with each good sold 
                                                   // the sum will be added to this budget
        }
    }
}