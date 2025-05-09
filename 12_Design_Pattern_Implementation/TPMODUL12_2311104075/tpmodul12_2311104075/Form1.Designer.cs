namespace tpmodul12_2311104075
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.TextBox textBoxInput;
        public System.Windows.Forms.Button buttonCheck;
        public System.Windows.Forms.Label labelResult;

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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(30, 30);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(180, 22);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(230, 28);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 25);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Cek";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 70);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 17);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Hasil:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 120);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Cari Tanda Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
