using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус   ");
            double r = Convert.ToDouble(Console.ReadLine());
            double v = ((double)4)/3.0*Math.PI*Math.Pow(r,3);
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
