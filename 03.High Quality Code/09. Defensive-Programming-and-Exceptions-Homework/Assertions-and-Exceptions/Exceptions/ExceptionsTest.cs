using System;
using System.Collections.Generic;
using System.Text;

internal class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr","Array cannot be null.");
        }

        if (startIndex >= arr.Length - 1 || startIndex < 0)
        {
            throw new ArgumentException("Invalid start index.");
        }

        if (count >= arr.Length || count <= 0)
        {
            throw new ArgumentOutOfRangeException("count","Invalid count");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentException("String cannot be null or empty or whitespaces.");
        }
        if (count <= 0)
        {
            throw new ArgumentException("Count must be positive.");
        }
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Invalid count.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("Number must be positive.");
        }
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number%divisor == 0)
            {
                Console.WriteLine("{0} is not a prime.",number);
                return;
            }
        }
        Console.WriteLine("{0} is a prime.", number);
    }

    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(23);
        CheckPrime(33);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
