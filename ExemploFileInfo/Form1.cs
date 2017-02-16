using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                ShowFileInfo(openDlg.FileName);
            }
        }

        private void ShowFileInfo(string filename)
        {

            Text = filename;
            //FileInfo classe que retorna as propriedades dos arquivos
            FileInfo info = new FileInfo(filename);
            txtCriacao.Text = info.CreationTime.ToString();
            txtAcesso.Text = info.LastAccessTime.ToString();
            txtModificacao.Text = info.LastWriteTime.ToString();
            txtNome.Text = info.Name.ToString();
            txtDiretorio.Text = info.DirectoryName.ToString();
            txtExtensao.Text = info.Extension.ToString();
            txtTamanho.Text = info.Length.ToString();
            cbxReadyOnly.Checked = info.IsReadOnly;
            txtAtributos.Text = info.Attributes.ToString();

        }
    }
}
