namespace Mall.Staff
{

    using System;
    using System.Collections.Generic;

    using Mall.Common;
    using Mall.Goods;
    using Mall.SpaceHolder;
    using Mall.Basic;
    
    class ProductM: ManagmentWorkers
    {
        private List<Goods> goods;
        private List<Services> services;

        public ProductM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.Product_Manager)
        {
            goods = new List<Goods>();
            services = new List<Services>();
        }

        public List<Goods> Goods
        {
            get { return this.goods; }
        }

        public List<Services> Services
        {
            get { return this.services; }
        }

        public void GetGoods(SpaceHolder spaceHolder)
        {
            this.goods = spaceHolder.Goods;
        }

        public void GetService(SpaceHolder spaceHolder)
        {
            this.services = spaceHolder.Services;
        }

        public void AddGoods(SpaceHolder spaceHolder, params Goods[] newGoods)
        {
            foreach (var item in newGoods)
            {
                spaceHolder.Goods.Add(item);
            }
        }

        public void AddService(SpaceHolder spaceHolder, params Services[] newService)
        {
            foreach (var item in newService)
            {
                spaceHolder.Services.Add(item);
            }
        }

        public void RemoveGoods(SpaceHolder spaceholder, Goods item)
        {
            spaceholder.Goods.Remove(item);
        }

        public void RemoveService(SpaceHolder spaceHolder, Services serv)
        {
            spaceHolder.Services.Remove(serv);
        }
    }
}
