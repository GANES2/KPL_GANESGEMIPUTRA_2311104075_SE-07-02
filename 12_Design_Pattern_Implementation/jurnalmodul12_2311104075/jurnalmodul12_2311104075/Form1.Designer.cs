namespace modul12_2311104075
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(30, 30);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(68, 17);
            this.labelA.Text = "Nilai A:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(100, 27);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(30, 70);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(68, 17);
            this.labelB.Text = "Nilai B:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(100, 67);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(100, 110);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 30);
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(30, 160);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lblHasil);
            this.Name = "Form1";
            this.Text = "Kalkulator Pangkat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
