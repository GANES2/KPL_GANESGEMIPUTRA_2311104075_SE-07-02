using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();
        config.UbahSatuan(); // Contoh penggunaan method ubah satuan

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");
        int hari = int.Parse(Console.ReadLine());

        bool suhuOK = (config.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5)
                      || (config.satuan_suhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5);

        bool hariOK = hari < config.batas_hari_deman;

        if (suhuOK && hariOK)
            Console.WriteLine(config.pesan_diterima);
        else
            Console.WriteLine(config.pesan_ditolak);
    }
}
