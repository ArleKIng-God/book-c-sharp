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
            int number, n;
            number = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int nDigit = Convert.ToInt32(Math.Floor(number / Math.Pow(10, n - 1)) % 10);
            Console.WriteLine(nDigit);
            Console.ReadKey();

        }
    }
}
