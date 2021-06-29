using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{
    public partial class frmListaRespostas : Form
    {
        public frmListaRespostas()
        {
            InitializeComponent();
        }

        private void CarregaListaRespostas() 
        {
            string query = @"
                SELECT 
                    R.Id,
                    FE.DESCRICAO AS [Faixa Etaria],
                    C.DESCRICAO AS [Convênio],
                    FS.DESCRICAO AS [Faixa Salarial],
                    ME.DESCRICAO AS [Motivo Empréstimo]
                FROM
                    Respostas R
                    INNER JOIN FaixaEtaria FE 
					  ON FE.Id = R.FaixaEtariaId
					INNER JOIN Convenio C
					  ON C.Id = R.ConvenioId
					INNER JOIN FaixaSalarial FS
					  ON FS.Id = R.FaixaSalarialId
					INNER JOIN MotivoEmprestimo ME
					  ON ME.Id = R.MotivoEmprestimoId";

            dgRespostas.DataSource = Banco.Consulta(query);
            for (int i = 0; i < dgRespostas.Columns.Count - 1; i++)
            {
                if (i == 0)
                {
                    dgRespostas.Columns[i].Visible = false;
                }
                dgRespostas.Columns[i].Width = 150;
            }
        }

        private void frmListaRespostas_Load(object sender, EventArgs e)
        {
            CarregaListaRespostas();
            btnExcluirResposta.Enabled = ((dgRespostas.Rows.Count -1) > 0);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            frmQuestionario frmQuestionario = new frmQuestionario();
            frmQuestionario.ShowDialog();
            CarregaListaRespostas();
            btnExcluirResposta.Enabled = ((dgRespostas.Rows.Count - 1) > 0);
        }

        private void btnExcluirResposta_Click(object sender, EventArgs e)
        {
            string registro = dgRespostas.Rows[dgRespostas.CurrentRow.Index].Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Banco.abrir();
            cmd.CommandText =
                "DELETE Respostas WHERE Id = " + registro;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            CarregaListaRespostas();
            btnExcluirResposta.Enabled = ((dgRespostas.Rows.Count - 1) > 0);
        }
    }
}
