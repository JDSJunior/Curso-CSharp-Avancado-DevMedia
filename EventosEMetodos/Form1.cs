using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosEMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criando um botao em tempo de execução
            Button bt = new Button();
            //indicando qual é o conteiner onde ficara o botao
            bt.Parent = this;
            //adicionando o botao aos controles
            this.Controls.Add(bt);
            //localização do botao
            bt.Location = new System.Drawing.Point(32, 100);
            //texto do botão
            bt.Text = "Botao";

            //bt.Click = evento
            //new EventHandler Delegate
            //(bt_Click) evento que o delegate aponta
            bt.Click += new EventHandler(bt_Click);

            //delegate que aponta diretamente para o metodo
            bt.Click += delegate(object sender2, EventArgs e2)
            {
                //metodo anonimo
                MessageBox.Show("Ola Mundo! 2");
            };

            //função lambda
            //metodo anonimo resumido
            bt.Click += (sender2, e2) => MessageBox.Show("Hello World 3");

        }

        //evento que é apontado
        void bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Mundo! 1");            
        }
    }
}
