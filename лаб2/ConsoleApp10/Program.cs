using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());
            int m = 0; 
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if(i != j)
                    if (n[i] + n[j] == k || Math.Abs(n[i] - n[j]) == k)
                    {
                        m++;
                    }
                }
            }
            Console.WriteLine(m/2);
            Console.ReadKey();
        }
    }
}
