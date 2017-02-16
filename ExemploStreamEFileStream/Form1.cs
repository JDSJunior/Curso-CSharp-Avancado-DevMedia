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


namespace ExemploStreamEFileStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LerArquivo(string filename)
        {
            //Stream classe de fluxo de dados
            //File classe de manipulção ed dados
            StreamReader reader = File.OpenText(filename);
            var str = "";
            StringBuilder builder = new StringBuilder();
            //atribuia o valor lido em file na variavel str
            //e varre enquanto ela na for null
            while ((str = reader.ReadLine()) != null)
            {
                //atribui o conteudo lido no StringBuider
                builder.AppendLine(str);
            }
            //exibe o conteudo no txtArquivo
            txtArquivo.Text = builder.ToString();
        }

        private void SalvarArquivo(string filename)
        {
            //verifica se o arquivo existe
            if (!File.Exists(filename))
            {
                //cria o arquivo
                FileStream fs = File.Create(filename);
                //atribui o conteudo do txtArquivo dentro de um array de bytes
                Byte[] arq = new UTF8Encoding(true).GetBytes(txtArquivo.Text);
                //escreve o arquivo
                //arquivo, inicio da gravação, final da gravação
                fs.Write(arq, 0, arq.Length);
                //fecha o processo que usa o arquivo 
                fs.Close();
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //se o resultado da caixa de dialogo for ok
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                //le o arquivo selecionado
                LerArquivo(openDlg.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //se o resulatdo da caixa de dialogo for ok
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                //salva o arquivo
                SalvarArquivo(saveDlg.FileName);
            }
        }


    }
}
