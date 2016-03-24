using System;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age)
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
            
            Console.WriteLine("Bau");
        }
    }
}