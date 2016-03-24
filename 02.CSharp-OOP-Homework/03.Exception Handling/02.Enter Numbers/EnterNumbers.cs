using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_Numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            List<int>numbers=new List<int>();
            while (numbers.Count<10)
                {
                    numbers.Add(ReadNumber(1, 100));
                }
            Console.WriteLine("Numbers : {0}",string.Join(", ",numbers));                   
        }

        static int ReadNumber(int start, int end)
        {
            int number;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return number;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number must be for 1 to 100! Try again :)");
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("The input must be Integer number : {0}", fe.Message);
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("The number must be 32bit Integer {0}",oe.Message);
                }
            }
        }
    }
}
