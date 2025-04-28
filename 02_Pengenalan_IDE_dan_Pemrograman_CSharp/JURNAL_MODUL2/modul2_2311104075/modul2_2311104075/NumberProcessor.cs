using System;

class NumberProcessor
{
    public static void TampilkanArray()
    {
        int[] arr = new int[50];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
            Console.Write($"{i} ");

            if (i % 2 == 0 && i % 3 == 0)
                Console.WriteLine("#$#$");
            else if (i % 2 == 0)
                Console.WriteLine("##");
            else if (i % 3 == 0)
                Console.WriteLine("$$");
            else
                Console.WriteLine();
        }
    }

    public static bool IsPrima(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
