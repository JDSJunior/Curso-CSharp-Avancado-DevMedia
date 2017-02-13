//define a diretiva de compilação padrão
//#define DEBUG

//define a diretiva de compilação personalizada
#define RED
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //testa a diretiva
            //cor cinza indica que o compilador nao executará o codigo
            //#if DEBUG
            //teste padrão
            #if RED
            new frmRed().ShowDialog();
            #endif
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            //codigo que será executado 
            #if AZUL
            new frmBlue().ShowDialog();
            #endif
        }


    }
}