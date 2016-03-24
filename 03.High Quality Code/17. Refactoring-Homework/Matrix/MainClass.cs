using System;
using System.IO;

private class MainClass
{
    private static void Main()
    {
        Console.WriteLine("Enter a positive number from 0 to 100:");
        string input = Console.ReadLine();
        int n;

        while (!int.TryParse(input, out n) || n < 0 || n > 100)
        {
            Console.WriteLine("You haven't entered a correct positive number! Try again.");
            input = Console.ReadLine();
        }

        Matrix matrix = new Matrix(n);
        matrix.Run();      
    }
}