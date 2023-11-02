using Learning.classes;
using Learning.delegates;
using Learning.helpers;

namespace Learning
{
    internal class Program
    {
        static int Main(string[] args)
        {
            
            var newLogger = new ConsoleLogger();
            newLogger.Start();

           new Car().Run();

            newLogger.Stop();
            WaitForEnd();
            return 0;
        }

        static void WaitForEnd()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("Are you done? [yes] [no]");
                userIsDone = Console.ReadLine();
            } while (userIsDone != null && userIsDone.ToLower() != "yes");

            Console.WriteLine("\r");
            return;

        }
    }
}