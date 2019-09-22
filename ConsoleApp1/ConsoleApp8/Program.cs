using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            double a, b, c;
            string product;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if ((a < 0) || (b < 0) || (c < 0))
            {
                k++;
            }
            if ((k == 1) || k == 3)
            {
                product = "negativ";
            }
            else
            {
                product = "positiv";
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
