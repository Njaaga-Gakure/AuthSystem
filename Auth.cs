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
                Console.WriteLine("\n\n\n\t\t\t  Register Form");
                Console.WriteLine("Enter username");
                string? userName = Console.ReadLine();
                Console.WriteLine("Enter password");
                string? password = Console.ReadLine();
                string path = @"C:\Users\a.txt";
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
            string path = @"C:\Users\a.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("User does not exist... :(");
                return;
            }

            var users = File.ReadAllLines(path);

            Dictionary<string, string> usersData = new Dictionary<string, string>();
            
            foreach ( var user in users)
            {
                string[] credentials =  user.Split(" ");
                string userName = credentials[0];
                string password = credentials[1];
                usersData.Add(userName, password);
            }

            do
            {
                Console.WriteLine("\n\n\n\t\t\tLogin Form");
                Console.WriteLine("Enter username: ");
                string? loginUserName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string? loginPassword = Console.ReadLine();

                if (loginUserName != null && loginPassword != null) {
                    if (!usersData.ContainsKey(loginUserName))
                    {
                        Console.WriteLine("User does not exist. Plese try again... :(");
                        continue;
                    }
                    else if (usersData[loginUserName] != loginPassword)
                    {
                        Console.WriteLine("Invalid password. Please try again... :(");
                        continue;
                    }
                    else {
                        Console.WriteLine($"Welcome, {loginUserName}");
                        break;
                    }
                }

            } while (true);
        }

    }
}
