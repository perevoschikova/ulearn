using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));

            Console.ReadLine();
        }

        public static int MiddleOf1(int a, int b, int c)
        {
            if (a > b && a < c || a < b && a > c)
                return a;
            else if (b > a && b < c || b < a && b > c)
                return b;
            else
                return c;
        }

        public static int MiddleOf2(int a, int b, int c)
        {
            if (a < b && b < c)
                return b;
            if (c < b && b < a)
                return b;
            if (a < c && c < b)
                return c;
            if (b < c && c < a)
                return c;
            if (c < a && a < b)
                return a;
            return a;
        }

        public static int MiddleOf(int a, int b, int c)
        {
            if ((a == b) || (a == c))
                return a;
            if (b == c)
            {
                return b;
            }
            if (((a > b) && (a < c)) || ((a < b) && (a > c)))
            {
                return a;
            }
            if (((b > a) && (b < c)) || ((b < a) && (b > c)))
            {
                return b;
            }
            return c;
        }
    }
}
