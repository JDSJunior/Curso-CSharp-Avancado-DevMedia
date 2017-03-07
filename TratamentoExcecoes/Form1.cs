using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratamentoExcecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //bloco que o compilador tenta executar
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);

                TxtIMC.Text = Convert.ToString(peso / (altura * altura));
            }
            catch (FormatException)
            {
                //caso haja um erro pula para a este bloco
                MessageBox.Show("Tipo Invalido");
                //throw;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divisao não pode ser zero");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Erro aritmetico");
            }
            //sempre da execeção mais expecifica para a mais generica
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel calcular IMC");
            }
            finally
            {
                //sempre é executado
                txtAltura.Clear();
                txtPeso.Clear();
            }
        }
    }
}
