using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Percent
{
    class Program
    {
        static void Main()
        {
            var userInput = Console.ReadLine();

            var result = Calculate(userInput);
        }

        public static double Calculate(string userInput)
        {
            var array = new String[3];
            array = userInput.Split(' ');

            var sum = Convert.ToInt32(array[0]);
            var persent = Convert.ToInt32(array[1]);
            var time = Convert.ToInt32(array[2]);

            var result = Math.Pow((sum * (1 + persent / 100)), time);

            return result;
        }
    }
}
