using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi 1: Akar Persamaan Kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0) return new double[] { }; // Tidak ada akar real

            double sqrtDisc = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDisc) / (2 * a);
            double x2 = (-b - sqrtDisc) / (2 * a);

            return new double[] { x1, x2 };
        }

        // Fungsi 2: Hasil Kuadrat dari Persamaan Linear
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double A = a * a;          // x^2
            double B = 2 * a * b;      // x
            double C = b * b;          // konstanta

            return new double[] { A, B, C };
        }
    }
}
