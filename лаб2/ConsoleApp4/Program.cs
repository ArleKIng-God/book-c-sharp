using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder primesNums = FindPrimeNums(n);

        Console.WriteLine(primesNums.ToString());
        Console.ReadKey();
    }

    private static StringBuilder FindPrimeNums(int n)
    {
        bool isPrime = true;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i <= n; i++)
        {
            if (i < 2)
            {
                continue;
            }

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                result.Append(i + " ");
            }
            else
            {
                isPrime = true;
            }
        }

        return result;
    }
}