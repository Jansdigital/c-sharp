using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) //criar nosso método//
        {
            LimparCampos();//Depois de fazer a parte de baixo, você sobe para este ponto e chama.
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtMateria.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNome.Focus();
        }
   

    }
}
