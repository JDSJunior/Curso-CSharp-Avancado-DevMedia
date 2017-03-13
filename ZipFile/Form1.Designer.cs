namespace ExemploZipFile
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
            this.btnSource = new System.Windows.Forms.Button();
            this.btnTraget = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompactar = new System.Windows.Forms.Button();
            this.dlg = new System.Windows.Forms.FolderBrowserDialog();
            this.lstArquivos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileName = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(332, 75);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnTraget
            // 
            this.btnTraget.Location = new System.Drawing.Point(332, 141);
            this.btnTraget.Name = "btnTraget";
            this.btnTraget.Size = new System.Drawing.Size(75, 23);
            this.btnTraget.TabIndex = 1;
            this.btnTraget.Text = "...";
            this.btnTraget.UseVisualStyleBackColor = true;
            this.btnTraget.Click += new System.EventHandler(this.btnTraget_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(54, 78);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(256, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(54, 143);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(256, 20);
            this.txtTarget.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target";
            // 
            // btnCompactar
            // 
            this.btnCompactar.Location = new System.Drawing.Point(54, 393);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(75, 23);
            this.btnCompactar.TabIndex = 7;
            this.btnCompactar.Text = "Compactar";
            this.btnCompactar.UseVisualStyleBackColor = true;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // lstArquivos
            // 
            this.lstArquivos.Location = new System.Drawing.Point(54, 270);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(256, 97);
            this.lstArquivos.TabIndex = 8;
            this.lstArquivos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "FileName";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(54, 207);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(256, 20);
            this.txtFileName.TabIndex = 9;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(332, 204);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(75, 23);
            this.btnFileName.TabIndex = 11;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 438);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.btnCompactar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnTraget);
            this.Controls.Add(this.btnSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnTraget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompactar;
        private System.Windows.Forms.FolderBrowserDialog dlg;
        private System.Windows.Forms.ListView lstArquivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

