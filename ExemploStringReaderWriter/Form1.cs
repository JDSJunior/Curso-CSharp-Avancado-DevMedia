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

namespace ExemploStringReaderWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //escreve uma string 
            var sw = new StringWriter();
            sw.WriteLine("LINHA 1");
            sw.WriteLine("LINHA 2");
            sw.WriteLine("LINHA 3");
            sw.WriteLine("LINHA 4");

            //MessageBox.Show(sw.ToString());

            txtStrings.Text = sw.ToString();

            string linha = null;
            string msg = null;
            StringReader sr = new StringReader(sw.ToString());

            //varre a variavel linha
            while (true)
            {
                linha = sr.ReadLine();
                //mostra a variavel linha recebendo o conteudo de cada linha
                MessageBox.Show(linha);
                if (linha == null)
                    break;
                else
                    //concatena a variavel linha ate o resuktado for null
                    msg = msg + linha + Environment.NewLine;
            }

            txtReader.Text = msg.ToString();
        }
    }
}
