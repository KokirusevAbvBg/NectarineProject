namespace Mall.Staff
{
    abstract class Balnce
    {
        //Balance for employes and clients
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
