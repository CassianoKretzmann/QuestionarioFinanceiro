
namespace Questionario
{
    partial class frmQuestionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFaixaEtaria = new System.Windows.Forms.Label();
            this.cbFaixaEtaria = new System.Windows.Forms.ComboBox();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.cbFaixaSalarial = new System.Windows.Forms.ComboBox();
            this.lblFaixaSalarial = new System.Windows.Forms.Label();
            this.cbMotivoEmprestimo = new System.Windows.Forms.ComboBox();
            this.lblMotivoEmprestimo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFaixaEtaria
            // 
            this.lblFaixaEtaria.AutoSize = true;
            this.lblFaixaEtaria.Location = new System.Drawing.Point(12, 9);
            this.lblFaixaEtaria.Name = "lblFaixaEtaria";
            this.lblFaixaEtaria.Size = new System.Drawing.Size(62, 13);
            this.lblFaixaEtaria.TabIndex = 0;
            this.lblFaixaEtaria.Text = "Faixa Etaria";
            // 
            // cbFaixaEtaria
            // 
            this.cbFaixaEtaria.FormattingEnabled = true;
            this.cbFaixaEtaria.Location = new System.Drawing.Point(15, 25);
            this.cbFaixaEtaria.Name = "cbFaixaEtaria";
            this.cbFaixaEtaria.Size = new System.Drawing.Size(147, 21);
            this.cbFaixaEtaria.TabIndex = 1;
            // 
            // cbConvenio
            // 
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(15, 80);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(147, 21);
            this.cbConvenio.TabIndex = 3;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(12, 64);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(52, 13);
            this.lblConvenio.TabIndex = 2;
            this.lblConvenio.Text = "Convênio";
            // 
            // cbFaixaSalarial
            // 
            this.cbFaixaSalarial.FormattingEnabled = true;
            this.cbFaixaSalarial.Location = new System.Drawing.Point(205, 25);
            this.cbFaixaSalarial.Name = "cbFaixaSalarial";
            this.cbFaixaSalarial.Size = new System.Drawing.Size(147, 21);
            this.cbFaixaSalarial.TabIndex = 5;
            // 
            // lblFaixaSalarial
            // 
            this.lblFaixaSalarial.AutoSize = true;
            this.lblFaixaSalarial.Location = new System.Drawing.Point(202, 9);
            this.lblFaixaSalarial.Name = "lblFaixaSalarial";
            this.lblFaixaSalarial.Size = new System.Drawing.Size(69, 13);
            this.lblFaixaSalarial.TabIndex = 4;
            this.lblFaixaSalarial.Text = "Faixa Salarial";
            // 
            // cbMotivoEmprestimo
            // 
            this.cbMotivoEmprestimo.FormattingEnabled = true;
            this.cbMotivoEmprestimo.Location = new System.Drawing.Point(205, 80);
            this.cbMotivoEmprestimo.Name = "cbMotivoEmprestimo";
            this.cbMotivoEmprestimo.Size = new System.Drawing.Size(147, 21);
            this.cbMotivoEmprestimo.TabIndex = 7;
            // 
            // lblMotivoEmprestimo
            // 
            this.lblMotivoEmprestimo.AutoSize = true;
            this.lblMotivoEmprestimo.Location = new System.Drawing.Point(202, 64);
            this.lblMotivoEmprestimo.Name = "lblMotivoEmprestimo";
            this.lblMotivoEmprestimo.Size = new System.Drawing.Size(99, 13);
            this.lblMotivoEmprestimo.TabIndex = 6;
            this.lblMotivoEmprestimo.Text = "Motivo Empréstimo ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 122);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 153);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbMotivoEmprestimo);
            this.Controls.Add(this.lblMotivoEmprestimo);
            this.Controls.Add(this.cbFaixaSalarial);
            this.Controls.Add(this.lblFaixaSalarial);
            this.Controls.Add(this.cbConvenio);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.cbFaixaEtaria);
            this.Controls.Add(this.lblFaixaEtaria);
            this.Name = "frmQuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionário ";
            this.Load += new System.EventHandler(this.frmQuestionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFaixaEtaria;
        private System.Windows.Forms.ComboBox cbFaixaEtaria;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.ComboBox cbFaixaSalarial;
        private System.Windows.Forms.Label lblFaixaSalarial;
        private System.Windows.Forms.ComboBox cbMotivoEmprestimo;
        private System.Windows.Forms.Label lblMotivoEmprestimo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

