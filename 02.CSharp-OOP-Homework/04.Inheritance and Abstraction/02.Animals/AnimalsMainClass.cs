using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class Animals
    {
        static void Main()
        {
            Cat someCat = new Cat("Kotka", 10);
            Cat someCat1 = new Cat("Kotka1", 5);

            Tomcat tom = new Tomcat("Tom", 4, Gender.Male);
            Tomcat tom1 = new Tomcat("Tom1", 3, Gender.Male);

            Kitten maca = new Kitten("Maca", 2, Gender.Female);
            Kitten maca1 = new Kitten("Maca1", 6, Gender.Female);

            Dog sharo = new Dog("Sharo", 3);
            Dog sharo1 = new Dog("Sharo1", 1);

            Frog frogy = new Frog("Frogy", 8);
            Frog frogy1 = new Frog("Frogy1", 2);

            Console.WriteLine(someCat);
            Console.WriteLine(tom);
            Console.WriteLine(maca);
            Console.WriteLine(sharo);
            Console.WriteLine(frogy);

            IList<Animal> allAnimal = new List<Animal>();
            allAnimal.Add(someCat);
            allAnimal.Add(someCat1);
            allAnimal.Add(tom);
            allAnimal.Add(tom1);
            allAnimal.Add(maca);
            allAnimal.Add(maca1);
            allAnimal.Add(sharo);
            allAnimal.Add(sharo1);
            allAnimal.Add(frogy);
            allAnimal.Add(frogy1);

            foreach (var kind in allAnimal.GroupBy(x => x.GetType().Name))
            {
                double averageAge = kind.Select(x => x.Age).Average();
                Console.WriteLine("Animal : {0}, AverageAge: {1}", kind.Key, averageAge);
            }

        }
    }
}