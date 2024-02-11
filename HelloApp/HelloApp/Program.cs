using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class Program
    {
        // Sum of 2 variables
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int Sum = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, firstNumber, Sum);
            Console.ReadKey();
        }
    }
}
