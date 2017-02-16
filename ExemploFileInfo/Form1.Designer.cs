namespace ExemploFileInfo
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriacao = new System.Windows.Forms.TextBox();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModificacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxReadyOnly = new System.Windows.Forms.CheckBox();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAtributos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 24);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criação";
            // 
            // txtCriacao
            // 
            this.txtCriacao.Location = new System.Drawing.Point(75, 67);
            this.txtCriacao.Name = "txtCriacao";
            this.txtCriacao.Size = new System.Drawing.Size(162, 20);
            this.txtCriacao.TabIndex = 2;
            // 
            // txtAcesso
            // 
            this.txtAcesso.Location = new System.Drawing.Point(75, 93);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(162, 20);
            this.txtAcesso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Acesso";
            // 
            // txtModificacao
            // 
            this.txtModificacao.Location = new System.Drawing.Point(75, 119);
            this.txtModificacao.Name = "txtModificacao";
            this.txtModificacao.Size = new System.Drawing.Size(162, 20);
            this.txtModificacao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 145);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(75, 171);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(162, 20);
            this.txtDiretorio.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diretório";
            // 
            // txtExtensao
            // 
            this.txtExtensao.Location = new System.Drawing.Point(75, 197);
            this.txtExtensao.Name = "txtExtensao";
            this.txtExtensao.Size = new System.Drawing.Size(162, 20);
            this.txtExtensao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Extensão";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(75, 223);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(162, 20);
            this.txtTamanho.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tamanho";
            // 
            // cbxReadyOnly
            // 
            this.cbxReadyOnly.AutoSize = true;
            this.cbxReadyOnly.Location = new System.Drawing.Point(12, 259);
            this.cbxReadyOnly.Name = "cbxReadyOnly";
            this.cbxReadyOnly.Size = new System.Drawing.Size(103, 17);
            this.cbxReadyOnly.TabIndex = 15;
            this.cbxReadyOnly.Text = "Somente Leitura";
            this.cbxReadyOnly.UseVisualStyleBackColor = true;
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Atributos";
            // 
            // txtAtributos
            // 
            this.txtAtributos.Location = new System.Drawing.Point(276, 63);
            this.txtAtributos.Multiline = true;
            this.txtAtributos.Name = "txtAtributos";
            this.txtAtributos.Size = new System.Drawing.Size(194, 154);
            this.txtAtributos.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 310);
            this.Controls.Add(this.txtAtributos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxReadyOnly);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExtensao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModificacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCriacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriacao;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModificacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExtensao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxReadyOnly;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAtributos;
    }
}

