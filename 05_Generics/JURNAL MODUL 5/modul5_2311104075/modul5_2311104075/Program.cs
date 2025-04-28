using System;
using System.Collections.Generic;

namespace TugasModul5
{
    // Class SimpleDataBase<T> untuk menyimpan data generik
    public class SimpleDataBase<T>
    {
        private List<T> storedData = new List<T>();  // Menyimpan data
        private List<DateTime> inputDates = new List<DateTime>();  // Menyimpan waktu input

        // Method untuk menambahkan data baru
        public void AddNewData(T item)
        {
            storedData.Add(item);
            inputDates.Add(DateTime.Now); // Menyimpan waktu input
        }

        // Method untuk mencetak semua data
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, disimpan pada waktu: {inputDates[i]}");
            }
        }
    }

    // Class Penjumlahan untuk operasi generik
    public class Penjumlahan
    {
        // Method generik untuk menjumlahkan tiga angka
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tugas Jurnal Modul 5 ===");

            // 1. Menggunakan class Penjumlahan
            Penjumlahan penjumlahan = new Penjumlahan();

            // Input angka berdasarkan dua digit dari NIM 2311104075
            float angka1 = 23; // Dua digit pertama
            float angka2 = 11; // Dua digit berikutnya
            float angka3 = 10; // Dua digit berikutnya

            // Penjumlahan menggunakan angka NIM
            float hasilPenjumlahan = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
            Console.WriteLine($"Hasil Penjumlahan Tiga Angka: {hasilPenjumlahan}");

            // 2. Menggunakan class SimpleDataBase untuk menyimpan hasil
            SimpleDataBase<float> database = new SimpleDataBase<float>();
            database.AddNewData(angka1);
            database.AddNewData(angka2);
            database.AddNewData(angka3);
            database.AddNewData(hasilPenjumlahan);

            // Cetak semua data di database
            Console.WriteLine("\n--- Data yang Tersimpan ---");
            database.PrintAllData();

            Console.WriteLine("\n=== Program Selesai ===");
        }
    }
}
