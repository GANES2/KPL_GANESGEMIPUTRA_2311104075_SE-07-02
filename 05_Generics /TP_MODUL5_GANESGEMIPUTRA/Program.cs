using System;

class Program
{
    static void Main()
    {
        // Memanggil generic method
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("NamaKamu");

        // Memanggil generic class dengan NIM
        DataGeneric<string> dataNIM = new DataGeneric<string>("1202201234");
        dataNIM.PrintData();
    }
}
