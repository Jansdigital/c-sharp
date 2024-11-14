using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        string operacao = string.Empty;
        private bool CaracterInvalido(char caracter, TextBox textBox)
        {
            bool retorno = true;
            if (char.IsDigit(caracter)                  // é numero
                || caracter == (char)Keys.Back          // BackSpace
                || (caracter == ','                     //Vírgula
                    && textBox.Text.IndexOf(',') == -1   //For a 1° vírgula 
                    && textBox.Text != string.Empty))    //TextBox não estiver vazio
            {
                retorno = false;
            }
            return retorno;
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CaracterInvalido(e.KeyChar, txtValor1);
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CaracterInvalido(e.KeyChar, txtValor2);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operacao = "+";
            txtoperacao.Text = "soma";
        }

        private void btn2Subtrair_Click(object sender, EventArgs e)
        {
            operacao = "-";
            txtoperacao.Text = "subtração";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacao = "*";
            txtoperacao.Text = "multiplicação";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            txtoperacao.Text = "dividir";
        }

        private void btnLimpar_Click(object sender, EventArgs e) 

        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtoperacao.Clear();
            txtResultado.Clear();
            operacao = string.Empty;
            txtValor1.Focus();
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtValor1.Text == string.Empty)
            {
                msgErro = "Campo VALOR 1 em branco.\n";
            }
            if (txtValor2.Text == string.Empty)
            {
                msgErro += "Campo VALOR 2 em branco.\n";
            }
            if (txtoperacao.Text == string.Empty)
            {
                msgErro += "Campo OPERAÇÃO em branco.\n";
            }
            return msgErro;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();
            if (mensagem != string.Empty)
            {
                MessageBox.Show(mensagem, "Erro de preechimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
