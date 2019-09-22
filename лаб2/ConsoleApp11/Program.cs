using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            int i = 0;
            bool w = false; 
            for (i = 0; i < n.Length; i++)
            {
                sum1 = 0;
                sum2 = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    sum1 += n[j]; 
                }
                for (int t = i; t < n.Length; t++)
                {
                    sum2 += n[t];
                }
                if (sum1 == sum2)
                {
                    w = true;
                    break;
                }                
            }
            if (w == true)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
