using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }
        public string Age { get { return this.OtherInfo.Substring(this.OtherInfo.Length - 10); }}

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.Age);
            DateTime secondDate =
                DateTime.Parse(other.Age);
            return firstDate > secondDate;
        }
    }
}
