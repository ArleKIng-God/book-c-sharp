using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, k1 = 0, n;
            string[] array = Console.ReadLine().Split(' ');
            string[] array1 = Console.ReadLine().Split(' ');
            if (array.Length > array1.Length)
                n = array.Length;
            else
                n = array1.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array1[i])
                {
                    k++;
                    if (array[i] != array1[i])
                    {
                        break;
                    }
                }
            }
            for (int i = n - 1; i > 0; i--)
            {
                if (array[i] == array1[i])
                {
                    k1++;
                    if (array[i] != array1[i])
                    {
                        break;
                    }
                }
            }
            if (k > k1)
            {
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(k1);
            }
            Console.ReadKey();
        }
    }
}