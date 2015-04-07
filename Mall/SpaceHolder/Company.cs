namespace Mall.SpaceHolder
{
    using Mall.Staff;

    class Company
    {
        private string companyName;

        private BankBalnce companyAccount;

        public string CompanyName
        {
            get { return this.companyName; }
            private set 
            {
                Validators.CheckNullEmptyString(value, "Company Name");
                this.companyName = value; 
            }
        }
        
        public BankBalnce CompanyAccount
        {
            get { return this.companyAccount; }
            set { this.companyAccount = value; }
        }

        public Company()
        {
            this.CompanyName = "no-name";
            this.CompanyAccount = new BankBalnce();
        }
        public Company(string companyName, decimal initialBalance)
        {
            this.CompanyName = companyName;
            this.CompanyAccount = new BankBalnce(initialBalance);
        }
        
    }
}
