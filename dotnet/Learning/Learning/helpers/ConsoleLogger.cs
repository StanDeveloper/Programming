﻿namespace Learning.helpers
{
    public class ConsoleLogger
    {
        public void Start()
        {
            Console.Title = "Learning";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("*************************************");
            Console.WriteLine("*********** Learning C# *************");
            Console.WriteLine("*************************************");

            Console.BackgroundColor = ConsoleColor.Black;


            Console.ReadLine();
        }

        public void Stop()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
