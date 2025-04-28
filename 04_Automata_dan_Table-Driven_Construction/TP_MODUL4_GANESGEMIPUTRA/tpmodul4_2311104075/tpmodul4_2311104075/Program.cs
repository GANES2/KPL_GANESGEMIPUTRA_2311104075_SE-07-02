using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Implementasi Table-Driven (KodePos) ===");
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Tidak Ada: " + kodePos.GetKodePos("TidakAda"));

        Console.WriteLine("\n=== Implementasi State-Based (DoorMachine) ===");
        DoorMachine door = new DoorMachine();
        door.Kunci();
        door.Buka();
        door.Kunci();

        // Tunggu input sebelum keluar
        Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
        Console.ReadKey();
    }
}
