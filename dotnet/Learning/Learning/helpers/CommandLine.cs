using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.helpers
{
    internal class CommandLine
    {
        public void ProcessCommandLineArguments(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments passed");
            }
            else
            {
                Console.WriteLine("Arguments passed: ");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }

            Console.WriteLine("\r");
        }

        public void ProcessCommandLineArguments()
        {
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (var arg in theArgs)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine("\r");
        }

        public void GetValues() {
            int[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.WriteLine("Enter values 10: ");
            for (int i = 0; i < 10; i++)
            {
                var value = Console.ReadLine();

                if (value == null) {
                    Console.WriteLine($"Incorrect value: {value}");
                    value = Console.ReadLine();
                }

                Console.WriteLine($"Entered value: {value}");

                int.TryParse(value, out int intValue);

                values[i] = intValue;
            }

            Console.WriteLine($"Entered values: {string.Join(',', values)}");
            Console.WriteLine("\r");

            var valuesBelowFive = from i in values
                                  where i < 5
                                  select i;

            Console.WriteLine($"Values below 5 ${string.Join(',', valuesBelowFive)}");
            Console.WriteLine("\r");
        }
    }
}
