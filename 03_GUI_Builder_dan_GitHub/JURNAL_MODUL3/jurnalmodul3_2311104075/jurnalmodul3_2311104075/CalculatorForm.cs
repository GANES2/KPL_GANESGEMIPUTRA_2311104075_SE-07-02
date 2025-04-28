using System;
using System.Windows.Forms;

namespace KalkulatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                double angka1 = double.Parse(txtAngka1.Text);
                double angka2 = double.Parse(txtAngka2.Text);
                double hasil = angka1 + angka2;
                lblHasil.Text = "Hasil: " + hasil.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            try
            {
                double angka1 = double.Parse(txtAngka1.Text);
                double angka2 = double.Parse(txtAngka2.Text);
                double hasil = angka1 - angka2;
                lblHasil.Text = "Hasil: " + hasil.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
