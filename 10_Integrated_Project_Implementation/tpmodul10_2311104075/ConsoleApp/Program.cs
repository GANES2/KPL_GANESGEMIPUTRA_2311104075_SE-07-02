using System;
using AljabarLibraries;

class Program
{
    static void Main()
    {
        double[] kuadrat1 = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("Akar-akar persamaan: " + string.Join(", ", kuadrat1));

        double[] kuadrat2 = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("Hasil kuadrat: " + string.Join(", ", kuadrat2));
    }
}

