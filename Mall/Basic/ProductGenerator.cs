
namespace Mall.Basic
{
    using System;
    using Mall.Common;
    using Mall.Goods;

    public class ProductGenerator
    {
        private static Random rand = new Random();

        public Goods generateGoods()
        {
            string name = "not-set";
            string goodType = "not-set";
            int priceGenerator = rand.Next(1, 1000);
            int quantity = rand.Next(0, 100);

            decimal price = 0.25m * priceGenerator;

            return new Goods(name, goodType, price, quantity);
        }

        public ServicesTypes generateServices()
        {
            throw new NotImplementedException();
        }
    }
}
