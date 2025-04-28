using System;

class NumberProcessor
{
    public static void TampilkanBilanganGenap()
    {
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
