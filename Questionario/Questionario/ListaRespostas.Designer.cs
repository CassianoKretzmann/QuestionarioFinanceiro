
namespace Questionario
{
    partial class frmListaRespostas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRespostas = new System.Windows.Forms.DataGridView();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnExcluirResposta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRespostas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRespostas
            // 
            this.dgRespostas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRespostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRespostas.Location = new System.Drawing.Point(12, 12);
            this.dgRespostas.Name = "dgRespostas";
            this.dgRespostas.ReadOnly = true;
            this.dgRespostas.Size = new System.Drawing.Size(776, 373);
            this.dgRespostas.TabIndex = 0;
            // 
            // btnResponder
            // 
            this.btnResponder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResponder.Location = new System.Drawing.Point(10, 389);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(130, 23);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "&Responder Questionário";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnExcluirResposta
            // 
            this.btnExcluirResposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirResposta.Location = new System.Drawing.Point(146, 389);
            this.btnExcluirResposta.Name = "btnExcluirResposta";
            this.btnExcluirResposta.Size = new System.Drawing.Size(130, 23);
            this.btnExcluirResposta.TabIndex = 2;
            this.btnExcluirResposta.Text = "&Excluir Resposta";
            this.btnExcluirResposta.UseVisualStyleBackColor = true;
            this.btnExcluirResposta.Click += new System.EventHandler(this.btnExcluirResposta_Click);
            // 
            // frmListaRespostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btnExcluirResposta);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.dgRespostas);
            this.Name = "frmListaRespostas";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Respostas";
            this.Load += new System.EventHandler(this.frmListaRespostas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRespostas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRespostas;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnExcluirResposta;
    }
}