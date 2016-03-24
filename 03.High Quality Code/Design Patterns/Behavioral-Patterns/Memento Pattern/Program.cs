namespace Memento
{
    using System;

    /// <summary>
    /// MainApp startup class for Real-World 
    /// Memento Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    internal class SalesProspect
    {
        private double _budget;

        private string _name;

        private string _phone;

        // Gets or sets name
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
                Console.WriteLine("Name:  " + this._name);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get
            {
                return this._phone;
            }

            set
            {
                this._phone = value;
                Console.WriteLine("Phone: " + this._phone);
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get
            {
                return this._budget;
            }

            set
            {
                this._budget = value;
                Console.WriteLine("Budget: " + this._budget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(this._name, this._phone, this._budget);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    internal class Memento
    {
        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }

        // Gets or sets name
        public string Name { get; set; }

        // Gets or set phone
        public string Phone { get; set; }

        // Gets or sets budget
        public double Budget { get; set; }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    internal class ProspectMemory
    {
        // Property
        public Memento Memento { get; set; }
    }
}