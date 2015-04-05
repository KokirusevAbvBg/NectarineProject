namespace Mall.Goods
{
    using System;

    public class Services : Sellable, ISellable
    {
        //*************************************************************************** fields/Properies
        private string serviceName;

        public string ServiceName
        {
            get
            {
                return this.serviceName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Service name cannot be null or empty!");
                }
                this.serviceName = value;
            }
        }


        //*************************************************************************** Constructors

        public Services()
        {
            this.ServiceName = "no_service";
            this.Price = 0;
        }

        public Services(string name, decimal price)
        {
            this.ServiceName = name;
            this.Price = 0;
        }
        
        //*************************************************************************** Methods

        public override string ToString()
        {
            return string.Format(@"
    ServiceInfo: 
    Description: {0}, 
    Price: {1}", 
               this.ServiceName, this.Price);
        }
    }
}
