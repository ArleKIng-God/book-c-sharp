using System;
using System.Linq;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main()
        {
            int[] ns = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = 0, maxlength = -1;
            int end = 0;
            for (int i = 0; i < ns.Length - 1; i++)
            {
                if (ns[i] == ns[i + 1])
                {
                    length++;
                    if (i + 1 == ns.Length - 1 && maxlength < length)
                    {
                        maxlength = length;
                        end = i + 1;
                    }
                }
                else
                {
                    if (maxlength < length)
                    {
                        maxlength = length;
                        end = i;
                    }
                    length = 0;
                }
            }
            writens(ns, end, maxlength);
            Console.ReadKey();
        }
        private static void writens(int[] ns, int end, int maxlength)
        {
            for (int i = 0; i < maxlength + 1; i++)
            {
                Console.Write(ns[end] + " ");
            }
        }
    }
}

