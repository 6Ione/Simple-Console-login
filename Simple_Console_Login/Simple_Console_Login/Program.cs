using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace Simple_Console_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changes the console color, Delete if you want.
            WebClient wc = new WebClient();
            string Whitelisted = wc.DownloadString("https://pastebin.com/raw/mSh84DYc"); // Put your URL that has the logins here.

            Console.Write("Enter Login: ");
            string login = Console.ReadLine();

            if (Whitelisted.Contains(login)) // checks if user input is whitelisted.
            {
                Console.Clear();
                Console.WriteLine("Logged in."); // enter your code here.

            }

            else
            {
                Console.WriteLine("Enter correct login.");
            }
            Thread.Sleep(-1); // keep program running
        }
    }
}
