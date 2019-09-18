using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int lastDigit = n % (10);
            Console.WriteLine(lastDigit);
            Console.ReadKey();
        }
    }
}
