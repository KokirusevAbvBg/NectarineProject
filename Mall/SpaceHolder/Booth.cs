namespace Mall.Staff
{
    using Mall.SpaceHolder;
    using System;
    using System.Object; 
    

    public class Booth 
    {
        //Fields
        private Floors floor;
        private double areaRentalPrice;
        
        //Constructors
        public Booth(Floors floors, double areaRentalPrice)
        {
            this.Floor = floor;
            this.AreaRentalPrice = areaRentalPrice;
        }

        //Properties
        public Floors Floor
        {
            get { return this.floor; }
            private set { this.floor = value; }
        }

        public double AreaRentalPrice
        {
            get { return areaRentalPrice; }
            set { areaRentalPrice = value; }
        }

        //Enums

        //Interfaces

        //Methods

    }
}
