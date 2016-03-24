using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Human__Student_and_Worker
{
    class Student : Human
    {
        private string facultyNumber;
        private static string pattern = @"(?<!^.\*\/\\\!\?\)\()[A-Za-z\d]*(?!^.\*\/\\\)\(\!\?)";
        private Regex regex=new Regex(pattern);
        public Student(string firstName,string lastName,string facultyNum):base(firstName,lastName)
        {
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Count() < 5 || value.Count() > 10)
                {
                    throw new ArgumentOutOfRangeException("The faculty number must be from 5-10 digits or numbers!");
                }
                else if (!regex.IsMatch(value))
                {
                    throw new FormatException("The faculty number must be only from digits or numbers!");
                }
                this.facultyNumber = value;
            }
        }
    }
}
