using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{
    public partial class frmConfigServidor : Form
    {
        public frmConfigServidor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbServidor.Text != "") 
            {
                Banco.Servidor = tbServidor.Text;
                frmListaRespostas frmListaRespostas = new frmListaRespostas();
                frmListaRespostas.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Deve ser informado o servido do banco de dados");            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
