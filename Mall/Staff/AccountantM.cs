namespace Mall.Staff
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Mall.Goods;
    using Mall.SpaceHolder;
    using Mall.Common;

    public class AccountantM : ManagmentWorkers
    {
        private List<Sellable> sales;

        public List<Sellable> Sales
        {
            get { return this.sales; }
        }
        
        /// <summary>
        /// Creating new Acountant with new list of sales
        /// </summary>
        public AccountantM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            :base(name,age,gender,money,salary,workhours,skill,uniform,ManagementType.Accountant)
        {
            this.sales = new List<Sellable>();
        }
        /// <summary>
        /// Asigns new Accountant and give it the current list of sales
        /// </summary>
        /// <param name="oldList">the current list of sales</param>
        public AccountantM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, List<Sellable> oldList)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.Accountant)
        {
            this.sales = oldList;
        }

        public void AddSell(Sellable item)
        {
            sales.Add(item);
        }

        public decimal ShowTotalSalesSum()
        {
            decimal totalSum = 0;
            foreach (var item in sales)
            {
                totalSum += item.Price;   
            }
            return totalSum;
        }

        public void ShowCompanyBankBalnce(Company comapny)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Company name: {0}", comapny.CompanyName));
            sb.AppendLine("Company account info:");
            sb.AppendLine(string.Format(" * Balance: {0}", comapny.CompanyAccount.ShowBalance()));
            sb.AppendLine(string.Format(" * Loans: {0}", comapny.CompanyAccount.Loan));
        }

        public void PaySallaryTo(Company company, Employee employee)
        {
            decimal sum = employee.Salary;
            company.CompanyAccount.Pay(sum);
            employee.personalBalance.GetPaid(sum);
            Console.WriteLine("Sallary payment succesfull!");
        }

        public void PayRent(SpaceHolder spaceHolder)
        {
            decimal sum = spaceHolder.Booth.AreaRentalPrice;
            spaceHolder.Company.CompanyAccount.Pay(sum);
            Console.WriteLine("Rent sum paid successfull!");
        }

    }
}
