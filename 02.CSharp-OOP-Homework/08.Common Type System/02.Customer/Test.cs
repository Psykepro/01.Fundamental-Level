using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{

    class Test
    {
        
        static void Main()
        {
            Customer customer1=new Customer("Jhony","Besniq","Abdal",14215,"Levski jm,bl 132,vh e",41253,"maniaka@abv.bg",CustomerType.Diamond,214,4125,1215,312445);
            Customer customerClone = customer1.Clone() as Customer;
            customerClone.FirstName = "Batko ti";
            customerClone.Payments[2] = 0;
            customerClone.ID = 444;
            Console.WriteLine(customer1);
            Console.WriteLine("Customer Clone");
            Console.WriteLine(customerClone);

            Console.WriteLine(customer1.CompareTo(customerClone));
            Console.WriteLine(customerClone!=customer1);
        }
    }
}
