using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            if ((c > b) && (c > b))
            {
                Console.WriteLine(c);
            }
            if ((b > a) && (b > c))
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
