using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using _02.Customer;

namespace _02.Customer
{
    public class Customer : ICloneable,IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private uint id;
        private string permanentAddress;
        private uint mobilePhone;
        private string email;

        public Customer(string firstName,
            string middleName,
            string lastName,
            uint id,
            string permanentAddress,
            uint mobilePhone,
            string email,           
            CustomerType customerType,
            params decimal[] payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = new List<decimal>(payments);
            this.CustomerType = customerType;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name cannote be null / empty / whispaces!");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Middle Name cannote be null / empty / whispaces!");
                }
                this.middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name cannote be null / empty / whispaces!");
                }
                this.lastName = value;
            }
        }

        public uint ID { get { return this.id; } set { this.id = value; } }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Permanent Address cannote be null / empty / whispaces!");
                }
                this.permanentAddress = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email cannote be null / empty / whispaces!");
                }
                this.email = value;
            }
        }

        public uint MobilePhone { get { return this.mobilePhone; } set { this.mobilePhone = value; } }

        public List<decimal> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public override bool Equals(object obj)
        {
            Customer other = obj as Customer;
            if (other == null)
            {
                return false;
            }
            if (!Object.Equals(this.ID,other.ID))
            {
                return false;
            }
            if (!Object.Equals(this.CustomerType,other.CustomerType))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.ID.GetHashCode() ^ this.CustomerType.GetHashCode();
        }

        public int CompareTo(object obj)
        {           
            Customer other = obj as Customer;
            if (other == null)
            {
                throw new ArgumentNullException("Second customer is null.");
            }
            string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
            if (thisFullName.CompareTo(otherFullName) == 0)
            {
                return this.ID.CompareTo(other.ID);
            }
                return thisFullName.CompareTo(otherFullName);
        }

        public object Clone()
        {
            var customer=new Customer(FirstName,MiddleName,LastName,ID,PermanentAddress,MobilePhone,Email,CustomerType,Payments.ToArray());
            return customer;
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return Object.Equals(c1, c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            StringBuilder customer =new StringBuilder();
            customer.AppendFormat("First Name: {0}", this.FirstName).AppendLine();
            customer.AppendFormat("Мiddle Name: {0}", this.MiddleName).AppendLine();
            customer.AppendFormat("Last Name: {0}", this.LastName).AppendLine();
            customer.AppendFormat("ID: {0}", this.ID).AppendLine();
            customer.AppendFormat("Permanent Address: {0}", this.PermanentAddress).AppendLine();
            customer.AppendFormat("Mobile Phone: {0}", this.MobilePhone).AppendLine();
            customer.AppendFormat("Email: {0}", this.Email).AppendLine();
            customer.AppendFormat("Payments: {0}", string.Join(", ", this.Payments)).AppendLine();
            customer.AppendFormat("Customer Type: {0}", string.Join(", ", this.CustomerType.ToString()));
            return customer.ToString();
        }
    }
}
