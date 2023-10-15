using Learning.helpers;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newLogger = new ConsoleLogger();
            newLogger.Start();
        }
    }
}