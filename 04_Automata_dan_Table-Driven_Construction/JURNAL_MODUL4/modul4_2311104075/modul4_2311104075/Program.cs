using System;

class Program
{
    static void Main(string[] args)
    {
        // Bagian Table-Driven Construction (KodeBuah)
        Console.WriteLine("=== Table-Driven Construction (KodeBuah) ===");
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Kode buah Apel: " + kodeBuah.GetKodeBuah("Apel"));
        Console.WriteLine("Kode buah Durian: " + kodeBuah.GetKodeBuah("Durian"));
        Console.WriteLine("Kode buah Tidak Ada: " + kodeBuah.GetKodeBuah("Mangga"));

        // Bagian State-Based Construction (PosisiKarakterGame)
        Console.WriteLine("\n=== State-Based Construction (PosisiKarakterGame) ===");
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        // Deklarasi variabel NIM dan nimMod3
        long nim = 2311104075; // Ubah ke tipe long jika diperlukan
        int nimMod3 = (int)(nim % 3); // Casting eksplisit jika tipe berbeda

        // Simulasikan perubahan berdasarkan nimMod3
        karakter.SimulasikanPerubahan(nimMod3);

        // Tunggu input sebelum program selesai
        Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}

