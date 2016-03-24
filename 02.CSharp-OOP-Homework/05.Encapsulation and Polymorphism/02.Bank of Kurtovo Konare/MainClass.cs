using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Bank_of_Kurtovo_Konare.Accounts;

namespace _02.Bank_of_Kurtovo_Konare
{
    class MainClass
    {
        static void Main()
        {
            Account[] accounts =new Account[]
            {
                new DepositAccount("Gosho",100,5,"individual"),
                new DepositAccount("Pesho",1001,5,"company"), 
                new LoanAccount("Tosho",100,5,"individual"), 
                new LoanAccount("Kircho",100,5,"company"), 
                new MortgageAccount("Ivancho",100,5,"individual"),
                new MortgageAccount("Gancho",100,5,"company"),
                                
            };
            accounts[0].InterestRate = accounts[0].InterestCalculator(5);
            accounts[1].InterestRate = accounts[1].InterestCalculator(5);
            accounts[2].InterestRate = accounts[2].InterestCalculator(3);
            accounts[3].InterestRate = accounts[3].InterestCalculator(2);
            accounts[4].InterestRate = accounts[4].InterestCalculator(6);
            accounts[5].InterestRate = accounts[5].InterestCalculator(12);
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}
