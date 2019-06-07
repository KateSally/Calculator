using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            double c = 0;
            string znak;
            a = Convert.ToInt32(Console.ReadLine());
            znak = Console.ReadLine();
            b = Convert.ToInt32(Console.ReadLine());
            if (znak == "+")
            {
                c = a + b;
            }
            if (znak == "-")
            {
                c = a - b;
            }
            if (znak == "*")
            {
                c = a * b;
            }
            if (znak == "/")
            {
                c = a / b;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
