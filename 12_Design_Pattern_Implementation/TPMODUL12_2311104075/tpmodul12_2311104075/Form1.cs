using System;
using System.Windows.Forms;

namespace tpmodul12_2311104075
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method untuk menentukan tanda bilangan
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        // Event handler tombol
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int angka))
            {
                labelResult.Text = CariTandaBilangan(angka);
            }
            else
            {
                labelResult.Text = "Input tidak valid!";
            }
        }
    }
}
