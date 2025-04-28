using System;

class Utilities
{
    public static int GetValidInteger(string message, int min, int max)
    {
        int number;
        do
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= min && number <= max)
                return number;

            Console.WriteLine($"Input tidak valid! Masukkan angka antara {min} - {max}.");
        } while (true);
    }
}
