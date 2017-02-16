using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try testa se haverá um erro
            try
            {
                Autentificao.Autenticar(txtUsuario.Text, txtSenha.Text);
                //se for identificado um erro o try pula para o catch correspondente
                MessageBox.Show("OK!");
            }
            //usa a instancia da custom exception para pegar sua mensagem
            catch(UsuarioException E)
            {
                MessageBox.Show(E.Message);
            }
            catch (SenhaException E)
            {
                MessageBox.Show(E.Message);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}
