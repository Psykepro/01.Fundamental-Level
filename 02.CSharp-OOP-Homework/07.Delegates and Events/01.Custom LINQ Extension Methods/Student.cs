using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Custom_LINQ_Extension_Methods
{
    public class Student
    {
        public Student(string name,int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
