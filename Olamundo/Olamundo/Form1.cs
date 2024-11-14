using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olamundo
{
    public partial class frmOlaMundo : Form
    {
        public frmOlaMundo()
        {
            InitializeComponent();
        }

        private void btnOlaMundo_Click(object sender, EventArgs e) //Nunca escrevam o metodo os eventos
        {
            MessageBox.Show("Olá Mundo!", "Titulo da Janela", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); //Não tem ordem
            string nome = "Estevam Campos";
            int idade = 49;
            string mensagem = "";//classe String com letra maiuscula
            mensagem = string.Format("Seu nome é {0}, \nVocê tem {1} anos.",
                nome, idade);                              // observação \n quebra de linha no código   {} ->mensage na ordem das informações citada entre chaves
            MessageBox.Show(mensagem, "Seu nome e idade",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
