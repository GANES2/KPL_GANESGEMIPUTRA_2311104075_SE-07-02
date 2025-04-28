namespace KalkulatorApp
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtAngka1
            this.txtAngka1.Location = new System.Drawing.Point(30, 30);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(100, 20);

            // txtAngka2
            this.txtAngka2.Location = new System.Drawing.Point(150, 30);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(100, 20);

            // btnTambah
            this.btnTambah.Location = new System.Drawing.Point(30, 70);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnKurang
            this.btnKurang.Location = new System.Drawing.Point(150, 70);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(75, 23);
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);

            // lblHasil
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(30, 110);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(35, 13);
            this.lblHasil.Text = "Hasil:";

            // CalculatorForm
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.lblHasil);
            this.Name = "CalculatorForm";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Label lblHasil;
    }
}
