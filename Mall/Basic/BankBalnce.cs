namespace Mall.Basic
{
    using System;

    class BankBalnce: Balnce, ILoans
    {
        //*************************************************************************** constants
        private const decimal interest = 5;
        private const decimal loanReturnVerifier = 10;

        //*************************************************************************** fields/Properties 
        private decimal loan;

        public decimal Loan
        {
            get { return loan; }
            private set { loan = value; }
        }

        public decimal ActualMoney
        {
            get
            {
                return this.Balance - this.Loan;
            }
            private set;
        }
        
        //*************************************************************************** Constructors
        public BankBalnce()
        {
            this.Balance = 0;
            this.Loan = 0;
        }

        public BankBalnce(decimal sum)
        {
            CheckSumPositive(sum);
            this.Balance = sum;
            this.Loan = 0;
        }

        //*************************************************************************** Methods 
        public override void GetPaid(decimal sum)
        {
            CheckSumPositive(sum);
            this.Balance = this.Balance + sum;
        }

        public override bool Pay(decimal sum)
        {
            CheckSumPositive(sum);

            if (sum>this.Balance)
            {
                Console.WriteLine("You cannot pay, consider taking a loan!");
                return false;
            }
            else
            {
                Console.WriteLine("Payment successful!");
                this.Balance = this.Balance - sum;
                return true;
            }
        }

        public bool GetLoan(decimal sum)
        {
            CheckSumPositive(sum);

            if (ActualMoney*loanReturnVerifier>=sum)
            {
                this.Balance = this.Balance + sum;
                this.Loan = this.Loan + sum*((100 + interest)/100);
                Console.WriteLine("Loan granted!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, loan is denied!");
                return false;
            }
            
        }

        public bool ReturnLoan(decimal sum)
        {
            CheckSumPositive(sum);

            if (sum>this.Loan)
            {
                Console.WriteLine("You don't owe that much money!");
                return false;
            }

            if (this.Balance<sum)
            {
                Console.WriteLine("You cannot return the loan!");
                return false;
            }
            else
            {
                this.Balance = this.Balance - sum;
                this.Loan = this.Loan - sum;
                Console.WriteLine("{0} returned successfully!",sum);
                return true;
            }


        }

        private void CheckSumPositive(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Sum must be positive!");
            }
        }
    }
}
