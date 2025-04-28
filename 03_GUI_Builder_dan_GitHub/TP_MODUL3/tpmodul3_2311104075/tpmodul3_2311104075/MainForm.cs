using System;
using System.Windows.Forms;

namespace PraktikumKPLModul3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string nama = inputTextBox.Text;
            if (!string.IsNullOrWhiteSpace(nama))
            {
                outputLabel.Text = $"Halo {nama}!";
            }
            else
            {
                outputLabel.Text = "Masukkan nama terlebih dahulu!";
            }
        }
    }
}
