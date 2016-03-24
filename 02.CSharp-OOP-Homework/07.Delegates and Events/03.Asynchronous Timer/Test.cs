using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Asynchronous_Timer
{
    class Test
    {
        static void Main()
        {
            AsynchronousTimer aSyncTimer = new AsynchronousTimer(3, 1000, PrintLetterOnConsole);
            aSyncTimer.Execute();
        }

        private static void PrintLetterOnConsole(int i)
        {
            char letter = (char)('a' + i);
            Console.WriteLine(letter);
        }
    }
}
