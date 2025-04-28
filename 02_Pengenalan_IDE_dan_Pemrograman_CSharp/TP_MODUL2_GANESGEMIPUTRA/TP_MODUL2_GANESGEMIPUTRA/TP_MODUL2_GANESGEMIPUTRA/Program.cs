using System;

class Program
{
    static void Main()
    {
        // A. Input satu karakter huruf kapital
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("AIUEO".Contains(huruf))
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        else
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");

        // B. Memanggil fungsi dari NumberProcessor untuk menampilkan bilangan genap
        NumberProcessor.TampilkanBilanganGenap();
    }
}
