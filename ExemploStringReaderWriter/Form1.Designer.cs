namespace ExemploStringReaderWriter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTeste = new System.Windows.Forms.Button();
            this.txtStrings = new System.Windows.Forms.TextBox();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(12, 24);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // txtStrings
            // 
            this.txtStrings.Location = new System.Drawing.Point(12, 53);
            this.txtStrings.Multiline = true;
            this.txtStrings.Name = "txtStrings";
            this.txtStrings.Size = new System.Drawing.Size(178, 149);
            this.txtStrings.TabIndex = 1;
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(196, 53);
            this.txtReader.Multiline = true;
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(178, 149);
            this.txtReader.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.txtReader);
            this.Controls.Add(this.txtStrings);
            this.Controls.Add(this.btnTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.TextBox txtStrings;
        private System.Windows.Forms.TextBox txtReader;
    }
}

