using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class frmCalculoIMC : Form
    {
        public frmCalculoIMC()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtIMC.Clear();
            txtNome.Focus();
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtNome.Text == string.Empty)
            {
                msgErro = "Campo NOME em branco.\n";
            }
            if (txtPeso.Text == string.Empty)
            {
                msgErro += "Campo PESO em branco.\n";
            }
            else
            {
                decimal peso = decimal.Parse(txtPeso.Text);
                if (peso < 40 || peso > 250)
                {
                    msgErro += "Peso deve estar entre 40kg e 250kg.\n";
                }
            }
            if (txtAltura.Text == string.Empty)
            {
                msgErro += "campo ALTURA em branco.\n";
            }
            else
            {
                decimal altura = decimal.Parse(txtAltura.Text);
                if (altura < (decimal)1.2 || altura > (decimal)2.5)
                {
                    msgErro += "Altura deve estar entre 1.20m e 2.50m.\n";
                }
            }
            return msgErro;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();
            if (mensagem != string.Empty)
            {
                MessageBox.Show(mensagem, "Erro de Preenchimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nome = txtNome.Text;
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / Math.Pow(altura, 2);

            imc = Math.Round(imc, 1);
            txtIMC.Text = imc.ToString();
            MessageBox.Show(nome + RetornarMensagem(imc), "Cálculo IMC",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
        private bool CaracterInvalido(char caracter, TextBox textBox)
        {
            bool retorno = true;
            if (char.IsDigit(caracter)                       // é numero
                || caracter == (char)Keys.Back              // BackSpace
                || (caracter == ','                         //Vírgula
                    && textBox.Text.IndexOf(',') == -1      //For a 1° vírgula 
                    && textBox.Text != string.Empty))       //TextBox não estiver vazio
            {
                retorno = false;
            }
            return retorno;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CaracterInvalido(e.KeyChar, txtAltura);// keychar: chave personalisada ela 
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CaracterInvalido(e.KeyChar, txtPeso);
        }
        private string RetornarMensagem(double resultado) //retorno do resultado 
        {
            string mensagem = ", Você está";

            if (resultado < 17)
            {
                mensagem = "muito baixo do peso";             
            }
            else if (resultado  < 18.5)
            {
                mensagem = " abaixo do peso";
            }
            else if (resultado < 25)
            {
                mensagem += "acima do peso";
            }
            else if(resultado < 35)
            {
                mensagem += "com Obesidade I.";
            }
            else if  (resultado < 40)
            {
                mensagem += "com Obesidade II";
            }
            else
            {
                mensagem += "com Obesidade III";
            }
            return mensagem;

        }

        
    }   
}
