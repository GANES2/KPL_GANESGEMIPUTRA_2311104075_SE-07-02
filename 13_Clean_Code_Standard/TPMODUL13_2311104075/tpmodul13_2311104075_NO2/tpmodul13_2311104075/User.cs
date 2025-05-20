// File: User.cs  
using System;

namespace ObserverPattern
{
    public class User : IObserver
    {
        private string _name;
        public User(string name) => _name = name;

        public void Update(string news)
        {
            Console.WriteLine($"[{_name}] Berita terbaru: {news}");
        }
    }
}