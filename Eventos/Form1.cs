﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //metodo que é apontado pelo evento
        //multi cast
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo! 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo! 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo! 3");
        }
    }
}
