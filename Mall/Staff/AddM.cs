
namespace Mall.Staff
{
    using System;
    using System.Collections.Generic;

    using Mall.Common;
    using Mall.Goods;
    using Mall.SpaceHolder;

    public class AddM : ManagmentWorkers
    {
        private List<Promoter> promoters;

        public AddM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.Advertising)
        {
            promoters = new List<Promoter>();
        }

        public void MakeDiscount(string sellableName, decimal percent, SpaceHolder shop)
        {
            var services = shop.Goods;
            var goods = shop.Services;

            var maches1 = goods.FindAll(g => g.Name==sellableName);

            foreach (var item in maches1)
            {
                item.MakeDiscount(percent);
            }

            var maches2 = services.FindAll(s => s.Name == sellableName);
            
            foreach (var item in maches2)
            {
                item.MakeDiscount(percent);
            }
        }

        public void GiveProotersMaterials(params PromotionMaterials[] items)
        {
            foreach (var person in this.promoters)
            {
                person.AddItems(items);
            }
        }
    }
}
