using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Questionario
{
    public partial class frmQuestionario : Form
    {
        public frmQuestionario()
        {
            InitializeComponent();
        }

        private void CarregarFaixasEtarias() 
        {
            cbFaixaEtaria.Items.Clear();
            string query = @"SELECT Id, Descricao FROM FaixaEtaria";
            cbFaixaEtaria.DataSource = Banco.Consulta(query);
            cbFaixaEtaria.DisplayMember = "Descricao";
            cbFaixaEtaria.ValueMember = "Id";
        }

        private void CarregarConvenios()
        {
            cbConvenio.Items.Clear();
            string query = @"SELECT Id, Descricao FROM Convenio";
            cbConvenio.DataSource = Banco.Consulta(query);
            cbConvenio.DisplayMember = "Descricao";
            cbConvenio.ValueMember = "Id";
        }

        private void CarregarFaixasSalariais()
        {
            cbFaixaSalarial.Items.Clear();
            string query = @"SELECT Id, Descricao FROM FaixaSalarial";
            cbFaixaSalarial.DataSource = Banco.Consulta(query);
            cbFaixaSalarial.DisplayMember = "Descricao";
            cbFaixaSalarial.ValueMember = "Id";
        }

        private void CarregarMotivosEmprestimo()
        {
            cbMotivoEmprestimo.Items.Clear();
            string query = @"SELECT Id, Descricao FROM MotivoEmprestimo";
            cbMotivoEmprestimo.DataSource = Banco.Consulta(query);
            cbMotivoEmprestimo.DisplayMember = "Descricao";
            cbMotivoEmprestimo.ValueMember = "Id";
        }

        private void frmQuestionario_Load(object sender, EventArgs e)
        {
            CarregarFaixasEtarias();
            CarregarConvenios();
            CarregarFaixasSalariais();
            CarregarMotivosEmprestimo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandText = 
                "INSERT Respostas VALUES(" + cbFaixaEtaria.SelectedValue + "," + cbConvenio.SelectedValue + "," + cbFaixaSalarial.SelectedValue + "," + cbMotivoEmprestimo.SelectedValue + ")";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            this.Close();
        }
    }
}
