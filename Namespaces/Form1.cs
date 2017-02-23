using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importação do namespace dos dois assemblies
using Junior.form.button;

namespace Namespaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //classe que do namespace importada
            textBox1.Text = GUID.GeraGuid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //classe que do namespace importada
            textBox2.Text = Data.GeraData();
        }

    }
}
