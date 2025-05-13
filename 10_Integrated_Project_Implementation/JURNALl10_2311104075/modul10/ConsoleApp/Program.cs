using System;
using MatematikaLibraries;
using System;

namespace AppPemanggil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh pemanggilan FPB dan KPK
            Console.WriteLine("FPB(60, 45) = " + Matematika.FPB(60, 45)); // Output: 15
            Console.WriteLine("KPK(60, 45) = " + Matematika.KPK(60, 45)); // Output: 180

            // Contoh pemanggilan Turunan
            int[] persamaanTurunan = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan([1,4,-12,9]) = " + Matematika.Turunan(persamaanTurunan)); // Output: 3x^2 +8x -12

            // Contoh pemanggilan Integral
            int[] persamaanIntegral = { 4, 6, -12, 9 };
            Console.WriteLine("Integral([4,6,-12,9]) = " + Matematika.Integral(persamaanIntegral)); // Output: x^4 +2x^3 -6x^2 +9x + C
        }
    }
}
