using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            bool result = (n > 20) && (n % 2 != 0);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
