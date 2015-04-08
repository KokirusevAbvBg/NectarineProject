namespace Mall.Interfaces
{
    interface ILoans
    {

        public bool GetLoan(decimal sum);

        public bool ReturnLoan(decimal sum);

    }
}
