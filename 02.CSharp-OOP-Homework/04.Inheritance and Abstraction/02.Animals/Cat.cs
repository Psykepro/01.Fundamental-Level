using System;

namespace Animals
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            {
                return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            }
        }

        public override void ProduceSound()
        {
            
            Console.WriteLine("Miauu");
        }
    }
}