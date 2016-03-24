using System;


namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public abstract override string ToString();

        public abstract void ProduceSound();
    }
}