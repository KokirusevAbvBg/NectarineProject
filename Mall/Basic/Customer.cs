namespace Mall.Basic
{
    using System;
    using System.Collections.Generic;

    using Mall.Staff;
    using Mall.Goods;
    using Mall.SpaceHolder;

    class Customer:Person
    {
        private List<Services> boughtServices;
        private List<Goods> boughtGoods;

        public List<Services> BoughtServices
        {
            get 
            {
                return this.boughtServices;
            }
            private set
            {
                Validators.CheckObjNull(value, "Bought Service");
                this.boughtServices = value;
            }
        }

        public List<Goods> BoughtGoods
        {
            get { return this.boughtGoods; }
            private set
            {
                Validators.CheckObjNull(value, "Bought Goods");
                this.boughtGoods = value;
            }
        }

        public Customer()
        {
            var pers = HuamanGenerator.PersonGenerator();
            this.Name = pers.Name;
            this.Age = pers.Age;
            this.Gender = pers.Gender;
            this.personalBalance = pers.personalBalance;
            this.BoughtServices = new List<Services>();
            this.BoughtGoods = new List<Goods>();
        }

        public void BuyGoods(SpaceHolder shop, string Name)
        {
            throw new NotImplementedException();
        }

        public void BeServiced(SpaceHolder shop, string Name)
        {
            throw new NotImplementedException();
        }

    }
}
