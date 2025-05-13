using System;
using System.Windows.Forms;

namespace modul12_2311104075
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(textBoxA.Text) || string.IsNullOrWhiteSpace(textBoxB.Text))
            {
                MessageBox.Show("Harap masukkan nilai untuk A dan B.");
                return;
            }

            int a, b;
            if (!int.TryParse(textBoxA.Text, out a) || !int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Masukkan nilai yang valid untuk A dan B.");
                return;
            }

            // Hitung hasil pangkat
            int hasil = CariNilaiPangkat(a, b);

            // Menampilkan hasil
            if (hasil == -1)
                lblHasil.Text = "Pangkat negatif tidak diperbolehkan.";
            else if (hasil == -2)
                lblHasil.Text = "Nilai A harus <= 100 dan B harus <= 10.";
            else if (hasil == -3)
                lblHasil.Text = "Overflow terjadi, nilai terlalu besar.";
            else
                lblHasil.Text = $"Hasil: {hasil}";
        }

        private int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                        hasil *= a;
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
    }
}
