namespace Mall.Basic
{
    abstract class Balnce
    {

        protected decimal Balance { get; set; }

        abstract public void GetPaid(decimal sum)
        {

        }
        abstract public bool Pay(decimal sum)
        {
            return true;
        }
    }
}
