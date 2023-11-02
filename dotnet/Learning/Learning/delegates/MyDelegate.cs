using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.delegates
{
    public delegate int BinaryOp(int x, int y);
    public delegate int SquaredOp(int a);

    public class DelegateHelper
    {
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }


        public void Run()
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            DisplayDelegateInfo(b);
            Console.WriteLine();

            SquaredOp b2 = new SquaredOp(SimpleMath.SquareNumber);
            Console.WriteLine("10 x 10 is {0}", b2(10));
            DisplayDelegateInfo(b2);
            Console.WriteLine();
        }
    }



    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;

        public static int SquareNumber(int a) => a * a;

        public void Run()
        {
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            Console.WriteLine("10 + 10 is {0}", b(10, 10));

            SquaredOp b2 = new SquaredOp(SimpleMath.SquareNumber);
            Console.WriteLine("10 x 10 is {0}", b2(10));
        }
    }
}
