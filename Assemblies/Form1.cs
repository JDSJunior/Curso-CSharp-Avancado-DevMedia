using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using referenciando o assemblie debtro do projeto
//ja adicionado no references
using AssemblieClassLibrary.Calculo;


namespace Assemblies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);

            //classe dentro do assemblie
            int r = Class1.Somar(x, y);

            textBox3.Text = r.ToString();

        }
    }
}
