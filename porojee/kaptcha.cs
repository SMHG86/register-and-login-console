using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using porojee;

namespace porojee
{
    internal class kapcha
    {
        private static Random random = new Random();

        public static void kap()
        {
            while (true)
            {
                int captchaNumber = random.Next(1000, 9999);
                Console.WriteLine("kaptcha: " + captchaNumber);
                Console.WriteLine("kaptcha ra vared konid: ");

                string user = Console.ReadLine();

                if (user == captchaNumber.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("kaptcha vared shode sahih ast!");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("kaptcha vared shode sahih nemi bashad!");
                    Console.ResetColor();
                    Console.WriteLine("lotfa dobare vared konid");
                    Console.Clear();
                }
            }
        }
    }
}
