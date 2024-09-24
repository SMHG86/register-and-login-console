using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using porojee;
using System.Text.RegularExpressions;


namespace porojee
{
    internal class register
    {
        public static void Register()
        {
            Console.Clear();
            Console.WriteLine("be menoye register khosh amadid");

            //barresi user
            string username = "";
            bool validUsername = false;
            //ta zamani ke user eshtebah bashad edame midehad
            while (!validUsername)
            {
                Console.Write("user name ra vared konid (hadaghal 3 karakter): ");
                username = Console.ReadLine();
                //barresi user hatma 3 ragham bashad
                if (username.Length >= 3)
                {
                    //barresi ke az ghabl user bode ya ne 
                    if (Program.users.ContainsKey(username))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("gablan sabtnam shode.");
                        Console.ResetColor();
                    }
                    else
                    {
                        //barresi ke user ghablan sabt nashode bashad
                        validUsername = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("user bayad hadaghal 3 character bashad!");
                    Console.ResetColor();
                }
            }

            //barresi pass
            string password = "";
            bool isPasswordStrong = false;
            //barresi ghavi bodan pass
            while (!isPasswordStrong)
            {
                Console.Write("password ra vared konid: ");
                password = Console.ReadLine();

                if (password.Length < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ramz bayad hadaghal 5 raghami bashad.");
                    Console.ResetColor();
                    continue;
                }

                int score = pass.CalculatePasswordStrength(password);
                //bar asas class pass, be ramz nomre midehad ke agar kamtar az 3 bod ghabol nemikonad
                if (score < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ramz asan ast, lotfan dobare ramz vared konid.");
                    Console.ResetColor();
                }
                else if (score == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ramz motavaset ast. aya mikhahid virayesh konid? (bale = Y / na = N)");
                    Console.ResetColor();

                    string response = Console.ReadLine();
                    if (response.ToLower() == "n")
                    {
                        isPasswordStrong = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ramz sakht ast. be marhale ba'd miravid.");
                    Console.ResetColor();
                    isPasswordStrong = true;
                }
            }

            //gereftan pass dovom va tatabogh dadan
            string confirmPassword = "";
            bool passwordsMatch = false;

            while (!passwordsMatch)
            {
                //agar ramz ha yeki bodan , miravad marahel baadi
                Console.Write("dobare password ra vared konid: ");
                confirmPassword = Console.ReadLine();

                if (confirmPassword == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("password ha mosavi hastand.");
                    passwordsMatch = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("password ha mosavi nistand, dobare vared konid.");
                }

                Console.ResetColor();
            }

            
            Console.WriteLine("select");
            Console.WriteLine("iranian = 1");
            Console.WriteLine("atba = 2");

            int kodmeli;

            if (!int.TryParse(Console.ReadLine(), out kodmeli) || (kodmeli != 1 && kodmeli != 2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("na motabar, please enter 1 or 2");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                register.Register();
            }

            string nationalCode = "";
            bool validNationalCode = false;

            switch (kodmeli)
            {
                case 1:
                    while (!validNationalCode)
                    {
                        Console.WriteLine("kod melli ra vared konid");
                        nationalCode = Console.ReadLine();

                        if (nationalCode.Length == 10 && long.TryParse(nationalCode, out _))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("kod melli sahih ast.");
                            validNationalCode = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("kod melli bayad 10 raghami bashad va faghat adad bashad.");
                        }

                        Console.ResetColor();
                    }
                    break;

                case 2:
                    Console.WriteLine("kode faragir ra vared konid");
                    nationalCode = Console.ReadLine();
                    break;
            }

            kapcha.kap();
            string randomkey = RandoM.GenerateRandomKey();
            Console.WriteLine($"ramz shoma: *hatma yaddasht konid* : {randomkey}");
            Program.users[username] = (password, randomkey, nationalCode);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("register ok.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            ShowMainMenu.Show();
        }
    }
}

