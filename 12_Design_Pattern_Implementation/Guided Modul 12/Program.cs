using System;

namespace modul12
{
    public static class Program
    {
        public static string DetermineGrade(int score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "E";
        }
    }
}
