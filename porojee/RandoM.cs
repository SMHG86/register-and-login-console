using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using porojee;


namespace porojee
{
    internal class RandoM
    {
        private static Random random = new Random();

        public static string GenerateRandomKey()
        {
            return random.Next(100000000, 999999999).ToString();
        }
    }
}