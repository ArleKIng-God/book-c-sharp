using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rotated = int.Parse(Console.ReadLine());

        int[] sum = new int[n.Length];

        for (int i = 0; i < rotated; i++)
        {
            RotatingArray(n);
            for (int j = 0; j < sum.Length; j++)
            {
                sum[j] = n[j] + sum[j];
            }
        }

        Console.WriteLine(string.Join(" ", sum));
        Console.ReadKey();
    }



    private static void RotatingArray(int[] n)
    {
        int lastNum = n[n.Length - 1];

        for (int i = n.Length - 1; i > 0; i--)
        {
            n[i] = n[i - 1];
        }

        n[0] = lastNum;
    }
}
