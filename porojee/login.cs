using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using porojee;

namespace porojee
{
    internal class login
    {
        public static void Login()
        {
            Console.WriteLine("be menoye login khosh amadid");
            Console.Write("user name: ");
            string username = Console.ReadLine();
            kapcha.kap();

            if (!Program.users.ContainsKey(username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("user sabt nashode, bayad sabt bokonid.");
                Console.ResetColor();
                Console.WriteLine("aya mikhahid register konid ? ");
                Console.WriteLine("yes = 1");
                Console.WriteLine("no = 2");
                int taeed = int.Parse(Console.ReadLine());

                if (taeed == 1)
                {
                    register.Register();
                }
                else if (taeed == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("na motabar, please enter 1 or 2");
                    Console.ResetColor();
                }
                return;
            }

            Console.Write("password: ");
            string password = Console.ReadLine();

            if (Program.users[username].Password == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("login ok.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                ShowMainMenu.Show();
              //  Noor.noor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("password eror.");
                Console.ResetColor();
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}