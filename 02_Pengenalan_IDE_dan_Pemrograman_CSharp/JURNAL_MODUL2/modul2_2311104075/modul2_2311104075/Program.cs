using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!\n");

        // Panggil fungsi untuk menampilkan array
        NumberProcessor.TampilkanArray();

        // Cek bilangan prima
        Console.Write("\nMasukkan angka (1-10000): ");
        int angka = Convert.ToInt32(Console.ReadLine());

        if (NumberProcessor.IsPrima(angka))
            Console.WriteLine($"Angka {angka} adalah bilangan prima.");
        else
            Console.WriteLine($"Angka {angka} bukan bilangan prima.");
    }
}
