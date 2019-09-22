using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FoldandSum
    {
        static void Main(string[] args)
        {
            int v = 0;
            int c = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array1 = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(array1[i]);
            int[] array2 = new int[n / 2];
            int[] array3 = new int[n / 2];
            int[] array4 = new int[n / 2];
            for (int f = 0; f < n / 2 - n / 4; f++)
            {
                array2[v] = array[f];
                v++;
            }
            for (int i = n / 2 - n / 4; i < n - (n / 2 - n / 4); i++)
            {
                array3[c] = array[i];
                c++;
            }
            for (int i = n - (n / 2 - n / 4); i < n; i++)
            {
                array2[v] = array[i];
                v++;
            }
            for (int i = 0; i < n / 2; i++)
            {
                array4[i] = array2[i] + array3[i];
            }
            for (int i = 0; i < n / 2; i++)
                Console.WriteLine(array4[i]);
            Console.ReadKey();
        }
    }
}
