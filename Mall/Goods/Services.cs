namespace Mall.Goods
{
    using System;
    using Mall.Interfaces;
    using Mall.Basic;

    public class Services : Sellable, ISellable
    {
        //*************************************************************************** fields/Properies
        private string serviceType;

        public string ServiceType
        {
            get
            {
                return this.serviceType;
            }
            set
            {
                Validators.CheckNullEmptyString(value, "Service type");
                this.serviceType = value;
            }
        }


        //*************************************************************************** Constructors

        public Services()
        {
            this.ServiceType = "no_service";
            this.Price = 0;
        }

        public Services(string name, decimal price)
        {
            this.ServiceType = name;
            this.Price = price;
        }
        
        //*************************************************************************** Methods

        public override string ToString()
        {
            return string.Format(@"
    ServiceInfo:
    Description: {0}, 
    Service Type: {1}
    Price: {2}", 
              this.Name, this.ServiceType, this.Price);
        }
    }
}
