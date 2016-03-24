using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Bank_of_Kurtovo_Konare.Interface;

namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
    abstract class Account:IInterestCalculator,IDeposit
    {
        private string customerId;
        private decimal balance;
        private decimal interestRate;
        private CustomerType customersType;

        public Account(string customerId, decimal balance, decimal interestRate)
        {
            this.CustomerID = customerId;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public string CustomerID
        {
            get { return this.customerId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("CustomerID","Cannot be empty / null / whitespace!");
                }
                this.customerId = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance","Cannot be negative!");
                }
                this.balance = Convert.ToDecimal(value);
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("InterestRate","Cannot be negative!");
                }
                this.interestRate = value;
            } 
        }

        public CustomerType CustomerType { get; set; }
       

        abstract public decimal InterestCalculator(int months);
        public virtual void Deposit(decimal money)
        {
            this.Balance += money;
        }

        
    }
}
