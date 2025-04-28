using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7
{
    // Class Article
    public class Article
    {
        public string title { get; set; }
        public string author { get; set; }
    }

    // Class Journal
    public class Journal
    {
        public string journal_name { get; set; }
        public List<Article> articles { get; set; } = new List<Article>(); // Inisialisasi agar tidak null
        public int volume { get; set; }
        public int tahun_terbit { get; set; }
    }

    // Class untuk handle JSON
    public class Jurnal
    {
        public static void ReadJson()
        {
            string filePath = "jurnal.json"; // Pastikan file ini diset Copy to Output Directory

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    Journal journal = JsonSerializer.Deserialize<Journal>(jsonContent);

                    if (journal != null)
                    {
                        Console.WriteLine($"Nama Jurnal   : {journal.journal_name}");
                        Console.WriteLine($"Volume        : {journal.volume}");
                        Console.WriteLine($"Tahun Terbit  : {journal.tahun_terbit}");
                        Console.WriteLine($"Daftar Artikel:");

                        if (journal.articles.Count > 0)
                        {
                            foreach (var article in journal.articles)
                            {
                                Console.WriteLine($"- {article.title} oleh {article.author}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tidak ada artikel.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data jurnal tidak ditemukan dalam file.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Terjadi kesalahan saat membaca file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File jurnal.json tidak ditemukan.");
            }
        }
    }

    // Main method
    class Program
    {
        static void Main(string[] args)
        {
            Jurnal.ReadJson(); // panggil method untuk baca JSON
        }
    }
}
