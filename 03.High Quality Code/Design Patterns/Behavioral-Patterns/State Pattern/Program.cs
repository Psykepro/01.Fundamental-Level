namespace State
{
    using System;

    /// <summary>
    /// MainApp startup class for Real-World 
    /// State Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    internal abstract class State
    {
        protected Account account;

        protected double balance;

        protected double interest;

        protected double lowerLimit;

        protected double upperLimit;

        // Properties
        public Account Account
        {
            get
            {
                return this.account;
            }

            set
            {
                this.account = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public abstract void PayInterest();
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    internal class RedState : State
    {
        private double _serviceFee;

        // Constructor
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            this.Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            this.interest = 0.0;
            this.lowerLimit = -100.0;
            this.upperLimit = 0.0;
            this._serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            this.balance += amount;
            this.StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - this._serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (this.balance > this.upperLimit)
            {
                this.account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    internal class SilverState : State
    {
        // Overloaded constructors
        public SilverState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            this.Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            this.interest = 0.0;
            this.lowerLimit = 0.0;
            this.upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            this.balance += amount;
            this.StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            this.balance -= amount;
            this.StateChangeCheck();
        }

        public override void PayInterest()
        {
            this.balance += this.interest * this.balance;
            this.StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (this.balance < this.lowerLimit)
            {
                this.account.State = new RedState(this);
            }
            else if (this.balance > this.upperLimit)
            {
                this.account.State = new GoldState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    internal class GoldState : State
    {
        // Overloaded constructors
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            this.Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            this.interest = 0.05;
            this.lowerLimit = 1000.0;
            this.upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            this.balance += amount;
            this.StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            this.balance -= amount;
            this.StateChangeCheck();
        }

        public override void PayInterest()
        {
            this.balance += this.interest * this.balance;
            this.StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (this.balance < 0.0)
            {
                this.account.State = new RedState(this);
            }
            else if (this.balance < this.lowerLimit)
            {
                this.account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    internal class Account
    {
        private string _owner;

        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this._owner = owner;
            this.State = new SilverState(0.0, this);
        }

        // Properties
        public double Balance
        {
            get
            {
                return this.State.Balance;
            }
        }

        public State State { get; set; }

        public void Deposit(double amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}", this.State.GetType().Name);
            Console.WriteLine(string.Empty);
        }

        public void Withdraw(double amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }

        public void PayInterest()
        {
            this.State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }
    }
}