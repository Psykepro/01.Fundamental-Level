using System;
using System.Security.AccessControl;

namespace _01.Human__Student_and_Worker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty or null!");
                }
                this.firstName = value;              
            } 
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty or null!");
                }
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1}", FirstName, LastName);
        }
    }
}
