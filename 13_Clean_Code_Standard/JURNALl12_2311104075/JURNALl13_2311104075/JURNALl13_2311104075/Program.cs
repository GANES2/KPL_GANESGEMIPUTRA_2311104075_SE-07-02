using System;

class Program
{
    static void Main(string[] args)
    {
        // Langkah D.A dan D.B: Inisialisasi data1 dan data2 dengan instance Singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Langkah D.C: Tambah data ke data1
        data1.AddSebuahData("Ganes Gemi Putra (Team 8)");
        data1.AddSebuahData("AHMAD AL-FARIZI (Team 8)");
        data1.AddSebuahData("KAFKA PUTRA RIYADI (Team 8)");
        data1.AddSebuahData("NAURA AISHA ZAHIRA (Team 8)");
        data1.AddSebuahData("FAISHAL ARIF SETIAWAN (Team 8)");
        data1.AddSebuahData("Asisten Praktikum: Gideon Tonarawa Ladiyo"); // Index 5

        // Langkah D.D: Cetak data dari data2
        Console.WriteLine("=== Data Sebelum Dihapus ===");
        data2.PrintSemuaData();

        // Langkah D.E: Hapus data asisten (index 5)
        data2.HapusSebuahData(5); // Perbaikan indeks

        // Langkah D.F: Cetak data dari data1
        Console.WriteLine("\n=== Data Setelah Dihapus ===");
        data1.PrintSemuaData();

        // Langkah D.G: Cetak jumlah data di data1 dan data2
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData()}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData()}");
    }
}