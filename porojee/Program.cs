using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using porojee;

namespace porojee
{
    public class Program
    {
      public  static Dictionary<string, (string Password, string RandomKey, string NationalCode)> users = new Dictionary<string, (string Password, string RandomKey, string NationalCode)>();

    /*    internal static void ShowMainMenu()
        {
            throw new NotImplementedException();
        }*/

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. register");
                Console.WriteLine("2. login");
               // Console.WriteLine("3. edit user and pass");
                Console.WriteLine("3. exit");
                Console.Write("select: ");
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
                 /*   case "3":
                        edit.edituser();
                        break;*/
                    case "3":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("eror try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }



    }
}

