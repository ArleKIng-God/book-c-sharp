using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            foreach (var i in array)
            {
                Console.WriteLine($"{i} -> {i - 97}");
            }
            Console.ReadKey();
        }
    }
}
