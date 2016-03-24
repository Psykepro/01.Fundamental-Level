using System;

internal class Persons
{
    private static void Main()
    {
        Person Pesho=new Person("Pesho",12);
        Console.WriteLine(Pesho);
        Person Gosho=new Person("Gosho",15,"gosho@abv.bg");
        Console.WriteLine(Gosho);
        Person Tosho=new Person("Tosho",17,null);
        Console.WriteLine(Tosho);
    }
}