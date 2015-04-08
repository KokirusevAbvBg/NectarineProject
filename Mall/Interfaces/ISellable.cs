namespace Mall.Interfaces
{
    using System;
    using Mall.SpaceHolder;

    public interface ISellable 
    {
        public void Sell(SpaceHolder spaceholder)
        {

        }

        public void MakeDiscount(decimal percent)
        {

        }
    }
}