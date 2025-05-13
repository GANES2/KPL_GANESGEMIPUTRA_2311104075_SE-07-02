using System.Text;

namespace MatematikaLibraries
{
    public static class Matematika
    {
        // Method FPB (Algoritma Euclidean)
        public static int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Method KPK menggunakan FPB
        public static int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        // Method Turunan Polinomial
        public static string Turunan(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i] * (persamaan.Length - 1 - i);
                int pangkat = persamaan.Length - 2 - i;

                if (koefisien == 0) continue;

                // Format suku
                if (result.Length > 0)
                {
                    if (koefisien > 0)
                        result.Append(" + ");
                    else
                        result.Append(" - ");
                }
                else if (koefisien < 0)
                {
                    result.Append("-");
                }

                int absKoef = System.Math.Abs(koefisien);
                if (absKoef != 1 || pangkat == 0)
                    result.Append(absKoef);

                if (pangkat > 0)
                {
                    result.Append("x");
                    if (pangkat > 1) result.Append($"^{pangkat}");
                }
            }
            return result.ToString().Trim();
        }

        // Method Integral Polinomial
        public static string Integral(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = persamaan.Length - i;
                double koefisien = (double)persamaan[i] / pangkat;

                if (koefisien == 0) continue;

                if (result.Length > 0)
                {
                    if (koefisien > 0)
                        result.Append(" + ");
                    else
                        result.Append(" - ");
                }
                else if (koefisien < 0)
                {
                    result.Append("-");
                }

                double absKoef = System.Math.Abs(koefisien);
                if (System.Math.Abs(absKoef - System.Math.Round(absKoef)) < 0.0001)
                {
                    int intKoef = (int)System.Math.Round(absKoef);
                    if (intKoef != 1 || pangkat == 0)
                        result.Append(intKoef);
                }
                else
                {
                    result.Append(absKoef.ToString("0.##"));
                }

                if (pangkat > 0)
                {
                    result.Append("x");
                    if (pangkat > 1) result.Append($"^{pangkat}");
                }
            }
            result.Append(" + C");
            return result.ToString();
        }
    }
}
