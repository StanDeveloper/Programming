using Learning.classes;
using Learning.helpers;

namespace Learning
{
    internal class Program
    {
        static int Main(string[] args)
        {
            
            var newLogger = new ConsoleLogger();
            newLogger.Start();

            var newCommandLine = new CommandLine();
            newCommandLine.ProcessCommandLineArguments(args);
            newCommandLine.ProcessCommandLineArguments();

            var newUserData = new UserData();
            newUserData.QueryUserData();
            newUserData.PrintUserData();
            newUserData.UserDataValidation();

            newCommandLine.GetValues();

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