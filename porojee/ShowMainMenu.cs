using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using porojee;

namespace porojee
{
    public static class ShowMainMenu
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Edit User and Password");
            Console.WriteLine("4. Exit");
            Console.Write("Select: ");
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    register.Register();
                    break;
                case "2":
                    login.Login();
                    break;
                case "3":
                    edit.edituser();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. Please try again.");
                    Console.ResetColor();
                    Show();
                    break;
            }
        }
    }
}
