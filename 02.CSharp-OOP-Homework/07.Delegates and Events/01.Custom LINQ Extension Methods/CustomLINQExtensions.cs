using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Custom_LINQ_Extension_Methods
{
    class CustomLINQExtensions
    {
        static void Main()
        {
            List<int> numbers=new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var oddNumbers = numbers.WhereNot(n => n%2 == 0);
            Console.WriteLine(string.Join(", ",oddNumbers));

            List<Student> students=new List<Student>()
            {
                new Student("Gosho",5),
                new Student("Ivan",7),
                new Student("Tosho",9),
                new Student("Niki",12),
            };
            Console.WriteLine("MAX : {0}",students.Max(st=>st.Grade));
        }
    }
}
