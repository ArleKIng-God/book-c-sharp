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
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int n = 0;
            if (array1.Length < array2.Length)
                n = array2.Length;
            else
                n = array2.Length;
            for (int i = 0; i < n; i++)
            {
                if (array1[i] > array2[i])
                {
                    Console.WriteLine(string.Join(string.Empty, array2));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, array1));
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

