using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem
{
    class Auth
    {
        public void register() {
            while (true)
            {
                Console.WriteLine("Enter username");
                string? userName = Console.ReadLine();
                Console.WriteLine("Enter password");
                string? password = Console.ReadLine();
                string path = @"C:\Users\User\desktop\a.txt";
                if (userName != null && password != null)
                {
                    if (!File.Exists(path)) {
                        File.Create(path);
                        File.WriteAllText(path, $"{userName} {password}");
                        break;
                    }
                    File.AppendAllText(path, $"\n{userName} {password}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input all the fields... :(");
                }

            }
        }

        public void login() {
            Console.WriteLine("login");
        }

    }
}
