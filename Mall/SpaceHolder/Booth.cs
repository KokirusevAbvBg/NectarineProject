using Mall.SpaceHolder;
namespace Mall.Staff
{
    using Mall.SpaceHolder;
    using System;
    using System.Object;
    using Mall.Common;

    public class Booth 
    {
        //Fields
        private Floors floor;
        private decimal area;
        private decimal areaRentalPrice;
        
        //Constructors
        public Booth(Floors floors,decimal area, decimal areaRentalPrice)
        {
            this.Floor = floor;
            this.Area = area;
            this.AreaRentalPrice = areaRentalPrice;
        }

        //Properties
        public Floors Floor
        {
            get { return this.floor; }
            private set { this.floor = value; }
        }

        public decimal Area
        {
            get { return this.area; }
            private set 
            {
                if (value >= 0)
                {
                    this.area = value; 
                }
                else
                {
                    throw new ArgumentException("Area must be positive number!");
                }
            }
        }

        public decimal AreaRentalPrice
        {
            get { return areaRentalPrice; }
            set 
            {
                if (value >= 0)
                {
                    this.areaRentalPrice = value;
                }
                else
                {
                    throw new ArgumentException("Rental price must be positive!");
                }
            }
        }
    }
}
