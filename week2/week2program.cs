using System

namespace IntroSelectionLogin
{
    
    {
    class Program
            {
            static void Main(string[] args)
                    {
                    string sysUsername = "Bob";
                    string sysPassword = "Password";

                    string username;
                    string password;

                    username = Console.WriteLine("Please enter your username");
                    username = Console.ReadLine();
                    password = Console.WriteLine("Please enter your password");
                    username = Console.ReadLine();

                    if(username == sysUsername) 
                    {
                        if(password == sysPassword) 
                        {
                            System.Console.WriteLine("Login Successful");
                        }
                        else 
                        {
                        System.Console.WriteLine("Login Unsuccessful");
                        }
                    }
                    else

                    }
            }
    }
}    