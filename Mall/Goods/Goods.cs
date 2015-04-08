namespace Mall.Goods
{
    
    using System;
    using Mall.Interfaces;
    using Mall.Basic;
    using Mall.SpaceHolder;

    public class Goods : Sellable, ISellable
    {
        //Fields
        private string goodType;
        private int quantity; 
        
        //Constructors

        public Goods(string name, string goodType, decimal price, int quantity)
        {
            this.Name = name;
            this.GoodType = goodType;
            this.Price = price;
            this.Quantity = quantity;
        }

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
                Validators.CheckNullEmptyString(value, "Good type");
                this.goodType = value;
            }
        }

        public override void Sell(SpaceHolder spaceholder)
        {
            this.Quantity--;
            spaceholder.Company.CompanyAccount.GetPaid(this.Price);
        }

        //Methods
        public override string ToString()
        {
            string productInfo = string.Format(@"
    GoodsInfo:
    Name: {0}
    Type: {1}
    Price: {2}
    Quantity: {3}",
                  this.Name, this.GoodType, this.Price, this.Quantity);
            return productInfo;
        }        
    }
}