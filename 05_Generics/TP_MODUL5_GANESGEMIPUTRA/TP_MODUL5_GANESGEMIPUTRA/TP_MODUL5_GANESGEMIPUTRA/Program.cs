using System;

class Program
{
    static void Main()
    {
        // Meminta input nama dari pengguna
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        // Memanggil generic method dengan nama pengguna
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(nama);

        // Meminta input NIM dari pengguna
        Console.Write("Masukkan NIM Anda: ");
        string nim = Console.ReadLine();

        // Memanggil generic class dengan NIM pengguna
        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
        dataNIM.PrintData();
    }
}

