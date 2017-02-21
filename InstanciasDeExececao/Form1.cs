using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstanciasDeExececao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HandlerExeception(Exception E)
        {
            StringBuilder sb = new StringBuilder();

            //stringbuilder que pega os dados da instancia da exeception
            sb.AppendLine("Source");
            sb.AppendLine(E.Source);
            sb.AppendLine("StrackTrace");
            sb.AppendLine(E.StackTrace);
            sb.AppendLine("Message");
            sb.AppendLine(E.Message);
            sb.AppendLine("Hresult");
            sb.AppendLine(E.HResult.ToString());
            sb.AppendLine("Data");
            foreach (var item in E.Data.Values)
            {
                //percorre o Idictionary e insere no stringbuilder
                sb.AppendLine(item.ToString());
            }

            txtLog.Text = sb.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);

                txtIMC.Text = Convert.ToString(peso / altura * altura);
            }
            //usa uma instancia de exception
            catch (FormatException E)
            {
                MessageBox.Show("Formato invalido para peso/ altura");
                //Passa os valores para um Idictionary 
                E.Data.Add("valores:" , txtAltura.Text + ";" + txtPeso.Text );
                HandlerExeception(E);
            }
            catch (OverflowException E)
            {
                MessageBox.Show("Numero muito Grande");
                HandlerExeception(E);
            }
            catch (DivideByZeroException E)
            {
                MessageBox.Show("Divisao por Zero");
                HandlerExeception(E);
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro inesperado");
                HandlerExeception(E);
            }
            finally
            {
                txtAltura.Clear();
                txtPeso.Clear();
                txtIMC.Clear();
            }
        }
    }
}
