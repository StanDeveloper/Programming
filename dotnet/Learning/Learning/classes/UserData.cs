using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.classes
{
    internal class UserData
    {
        string? name { get; set; }
        string? age { get; set; }

        public void QueryUserData()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("\r");
        }

        public void PrintUserData()
        {
            Console.WriteLine($"Your name is {name} and you are {age} years old.");
            Console.WriteLine("\r");
        }

        public void UserDataValidation()
        {
            if (name == null || age == null)
            {
                Console.WriteLine("Name or age is null");
                return;
            }

            Console.WriteLine($"Your name has {name.Length} characters");
            Console.WriteLine($"Your name in uppercase: {name.ToUpper()}");
            Console.WriteLine($"Your name in lowercase: {name.ToLower()}");
            Console.WriteLine($"Your name contains a 'y': {name.Contains("y")}");
            Console.WriteLine($"Replace your name with -: {name.Replace('y', '-')}");
            Console.WriteLine("\r");

        }
    }
}
