using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using porojee;

namespace porojee
{

    internal class edit
    {
        public static void edituser()
        {
            Console.Write("user name: ");
            string username = Console.ReadLine();

            if (!Program.users.ContainsKey(username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("user sabt nashode.");
                Console.ResetColor();
                return;
            }

            Console.Write("ramz ra vared konid: ");
            string randomKey = Console.ReadLine();

            Console.Write("kod meli ra vared konid: ");
            string nationalCode = Console.ReadLine();

            var userData = Program.users[username];
            if (userData.RandomKey == randomKey && userData.NationalCode == nationalCode)
            {
                Console.WriteLine("atelaat sahih ast, ramz ra vared konid");

                Console.Write("ramz jadid : ");
                string newPassword = Console.ReadLine();

                Program.users[username] = (newPassword, userData.RandomKey, userData.NationalCode);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ramz taghir kard");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ramz ya kod meli eshtebah ast! ");
                Console.ResetColor();
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}