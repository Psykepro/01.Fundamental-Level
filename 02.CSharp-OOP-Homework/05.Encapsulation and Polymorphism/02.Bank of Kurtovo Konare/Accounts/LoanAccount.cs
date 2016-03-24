using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
    class LoanAccount:Account
    {
       private CustomerType customerType;
        public LoanAccount(string customerId,decimal balance,decimal interestRate,string customerType)
            :base(customerId,balance,interestRate)
        {
            this.CustomerType = (CustomerType)Enum.Parse(typeof(CustomerType), customerType, true);
        }

        public CustomerType CustomerType { get; set; }

        public override decimal InterestCalculator(int months)
        {
            if (months <= 3 && this.CustomerType == CustomerType.Individual)
            {
                return this.InterestRate = 0;
            }
            else if (months <= 2 && this.CustomerType == CustomerType.Company)
            {
                return this.InterestRate = 0;
            }
            return this.InterestRate = this.Balance * (decimal)(1 + this.InterestRate * months);
        }
        public override string ToString()
        {
            return string.Format("Loan Account: \r\nCustomer ID : {0}, Balance : {1}, Interest Rate : {2}, Customer Type {3}", this.CustomerID, this.Balance, this.InterestRate, this.CustomerType);
        }
        
    }
}
