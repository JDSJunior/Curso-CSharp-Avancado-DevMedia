using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace ExemploZipFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            //caixa de dialogo de pastas
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //lista os arquivos na ListView
                var path = dlg.SelectedPath;
                txtSource.Text = path;
                foreach (var item in Directory.GetFiles(path))
                {
                    lstArquivos.Items.Add(item);
                }
            }
        }

        private void btnTraget_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = dlg.SelectedPath;
            }
        }

        private void btnCompactar_Click(object sender, EventArgs e)
        {
            var pathToZip = txtSource.Text;
            var zipToPath = txtTarget.Text;
            var fileName = txtFileName.Text;

            //metodo para compactação dos arquivos
            ZipFile.CreateFromDirectory(pathToZip, fileName);
            MessageBox.Show("Arquivo zipado com sucesso!");
        }

        //caixa de dialogo de salvar
        private void btnFileName_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlgSave.FileName;
            }
        }
    }
}
