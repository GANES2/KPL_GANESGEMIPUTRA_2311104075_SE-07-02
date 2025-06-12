using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Modul15_SecureLogin
{
    class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

    class Program
    {
        static string filePath = "user.json";

        static void Main(string[] args)
        {
            Console.WriteLine("=== Aplikasi Registrasi dan Login (Modul 15) ===");
            Console.WriteLine("1. Registrasi");
            Console.WriteLine("2. Login");
            Console.Write("Pilih menu (1/2): ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                RegisterUser();
            }
            else if (choice == "2")
            {
                LoginUser();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
        }

        static void RegisterUser()
        {
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine();

            if (!ValidateUsername(username)) return;

            Console.Write("Masukkan password: ");
            string password = Console.ReadLine();

            if (!ValidatePassword(password, username)) return;

            string hashedPassword = HashPassword(password);

            List<User> users = LoadUsers();
            users.Add(new User { Username = username, PasswordHash = hashedPassword });
            SaveUsers(users);

            Console.WriteLine("Registrasi berhasil!");
        }

        static void LoginUser()
        {
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine();

            Console.Write("Masukkan password: ");
            string password = Console.ReadLine();

            string hashedPassword = HashPassword(password);
            List<User> users = LoadUsers();

            foreach (var user in users)
            {
                if (user.Username == username && user.PasswordHash == hashedPassword)
                {
                    Console.WriteLine("Login berhasil!");
                    return;
                }
            }

            Console.WriteLine("Username atau password salah.");
        }

        static bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 8 || username.Length > 20)
            {
                Console.WriteLine("Username harus antara 8-20 karakter.");
                return false;
            }

            if (!Regex.IsMatch(username, "^[a-zA-Z]+$"))
            {
                Console.WriteLine("Username hanya boleh mengandung huruf alfabet ASCII.");
                return false;
            }

            return true;
        }

        static bool ValidatePassword(string password, string username)
        {
            if (password.Length < 8 || password.Length > 20)
            {
                Console.WriteLine("Password harus antara 8-20 karakter.");
                return false;
            }

            if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
            {
                Console.WriteLine("Password harus mengandung setidaknya satu karakter spesial (!@#$%^&*).");
                return false;
            }

            if (password.Contains(username))
            {
                Console.WriteLine("Password tidak boleh mengandung bagian dari username.");
                return false;
            }

            return true;
        }

        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
