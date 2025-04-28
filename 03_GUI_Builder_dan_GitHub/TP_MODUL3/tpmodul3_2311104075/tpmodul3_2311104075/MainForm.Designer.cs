namespace PraktikumKPLModul3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label outputLabel;

        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // TextBox (Input)
            this.inputTextBox.Location = new System.Drawing.Point(50, 30);
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);

            // Button
            this.button.Text = "BUTTON";
            this.button.Location = new System.Drawing.Point(260, 30);
            this.button.Size = new System.Drawing.Size(100, 25);
            this.button.Click += new System.EventHandler(this.button_Click);

            // Label (Output)
            this.outputLabel.Location = new System.Drawing.Point(50, 80);
            this.outputLabel.Size = new System.Drawing.Size(300, 20);
            this.outputLabel.Text = "OUTPUT";

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.outputLabel);
            this.Text = "Praktikum GUI";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
