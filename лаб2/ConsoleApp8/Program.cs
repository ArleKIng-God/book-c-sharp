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
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 0;
            int maxk = 0;
            int zn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0 ;j < array.Length ;j++)
                {
                    if (array[i] == array[j])
                    {
                        k++;
                        if (maxk < k && i + 1 == array.Length - 1)
                        {
                            maxk = k;
                            zn = array[i];  
                        }                        
                    }
                    else
                    {
                        if (maxk < k)
                        {
                            maxk = k;
                            zn = array[i];
                        }
                        k = 0;
                    }
                }
            }
            Console.WriteLine(zn);
            Console.ReadKey();
        }
    }
}
