using System;

namespace _04.Student_Class
{
    public delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        public event PropertyChangedEventHandler OnPropertyChange;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be : empty, null, withespaces!");
                }
                if (this.OnPropertyChange != null)
                {
                    this.OnPropertyChange(this, new PropertyChangedEventArgs("Name", this.name, value));
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative!");
                }
                if (this.OnPropertyChange!=null)
                {
                    this.OnPropertyChange(this,new PropertyChangedEventArgs("Age",this.age,value));
                }
                this.age = value;
            }
        }
    }
}
