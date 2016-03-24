using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
    class DepositAccount:Account
    {
        private CustomerType customerType;
        public DepositAccount(string customerId,decimal balance,decimal interestRate,string customerType)
            :base(customerId,balance,interestRate)
        {
            this.CustomerType = (CustomerType)Enum.Parse(typeof(CustomerType), customerType, true);
        }

        public CustomerType CustomerType { get; set; }
        
        public override decimal InterestCalculator(int months)
        {
            if (this.Balance > 0 && this.Balance<1000)
            {
                return 0;
            }
            return this.InterestRate=this.Balance*(decimal)(1 + this.InterestRate*months);
        }
        

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }

        public override string ToString()
        {
            return string.Format("Deposit Account: \r\nCustomer ID : {0}, Balance : {1}, Interest Rate : {2}, Customer Type {3}",this.CustomerID,this.Balance,this.InterestRate,this.CustomerType);
        }
    }
}
