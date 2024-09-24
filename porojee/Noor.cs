using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porojee
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class Noor
    {
        public static Random random = new Random();

        public static void noor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
                System.Threading.Thread.Sleep(200);
            }
            Console.ResetColor();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

    }
}
