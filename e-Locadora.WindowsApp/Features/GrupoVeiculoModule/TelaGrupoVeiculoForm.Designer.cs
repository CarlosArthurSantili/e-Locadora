
namespace e_Locadora.WindowsApp.GrupoVeiculoModule
{
    partial class TelaGrupoVeiculoForm
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPlanoDiarioValorDiario = new System.Windows.Forms.TextBox();
            this.txtPlanoDiarioValorKm = new System.Windows.Forms.TextBox();
            this.groupBoxPlanoDiario = new System.Windows.Forms.GroupBox();
            this.groupBoxPlanoControlado = new System.Windows.Forms.GroupBox();
            this.txtPlanoControladoValorDiario = new System.Windows.Forms.TextBox();
            this.txtPlanoControladoValorKm = new System.Windows.Forms.TextBox();
            this.groupBoxPlanoLivre = new System.Windows.Forms.GroupBox();
            this.txtPlanoLivreValorDiario = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labeld = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBoxPlanoDiario.SuspendLayout();
            this.groupBoxPlanoControlado.SuspendLayout();
            this.groupBoxPlanoLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(228, 160);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(309, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(142, 23);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtPlanoDiarioValorDiario
            // 
            this.txtPlanoDiarioValorDiario.Location = new System.Drawing.Point(6, 19);
            this.txtPlanoDiarioValorDiario.Name = "txtPlanoDiarioValorDiario";
            this.txtPlanoDiarioValorDiario.Size = new System.Drawing.Size(109, 20);
            this.txtPlanoDiarioValorDiario.TabIndex = 3;
            // 
            // txtPlanoDiarioValorKm
            // 
            this.txtPlanoDiarioValorKm.Location = new System.Drawing.Point(6, 56);
            this.txtPlanoDiarioValorKm.Name = "txtPlanoDiarioValorKm";
            this.txtPlanoDiarioValorKm.Size = new System.Drawing.Size(109, 20);
            this.txtPlanoDiarioValorKm.TabIndex = 4;
            // 
            // groupBoxPlanoDiario
            // 
            this.groupBoxPlanoDiario.Controls.Add(this.txtPlanoDiarioValorDiario);
            this.groupBoxPlanoDiario.Controls.Add(this.txtPlanoDiarioValorKm);
            this.groupBoxPlanoDiario.Location = new System.Drawing.Point(9, 59);
            this.groupBoxPlanoDiario.Name = "groupBoxPlanoDiario";
            this.groupBoxPlanoDiario.Size = new System.Drawing.Size(121, 90);
            this.groupBoxPlanoDiario.TabIndex = 8;
            this.groupBoxPlanoDiario.TabStop = false;
            this.groupBoxPlanoDiario.Text = "Plano Diário";
            // 
            // groupBoxPlanoControlado
            // 
            this.groupBoxPlanoControlado.Controls.Add(this.txtPlanoControladoValorDiario);
            this.groupBoxPlanoControlado.Controls.Add(this.txtPlanoControladoValorKm);
            this.groupBoxPlanoControlado.Location = new System.Drawing.Point(136, 59);
            this.groupBoxPlanoControlado.Name = "groupBoxPlanoControlado";
            this.groupBoxPlanoControlado.Size = new System.Drawing.Size(121, 90);
            this.groupBoxPlanoControlado.TabIndex = 9;
            this.groupBoxPlanoControlado.TabStop = false;
            this.groupBoxPlanoControlado.Text = "Plano Controlado";
            // 
            // txtPlanoControladoValorDiario
            // 
            this.txtPlanoControladoValorDiario.Location = new System.Drawing.Point(6, 19);
            this.txtPlanoControladoValorDiario.Name = "txtPlanoControladoValorDiario";
            this.txtPlanoControladoValorDiario.Size = new System.Drawing.Size(109, 20);
            this.txtPlanoControladoValorDiario.TabIndex = 3;
            // 
            // txtPlanoControladoValorKm
            // 
            this.txtPlanoControladoValorKm.Location = new System.Drawing.Point(6, 56);
            this.txtPlanoControladoValorKm.Name = "txtPlanoControladoValorKm";
            this.txtPlanoControladoValorKm.Size = new System.Drawing.Size(109, 20);
            this.txtPlanoControladoValorKm.TabIndex = 4;
            // 
            // groupBoxPlanoLivre
            // 
            this.groupBoxPlanoLivre.Controls.Add(this.txtPlanoLivreValorDiario);
            this.groupBoxPlanoLivre.Location = new System.Drawing.Point(263, 59);
            this.groupBoxPlanoLivre.Name = "groupBoxPlanoLivre";
            this.groupBoxPlanoLivre.Size = new System.Drawing.Size(121, 51);
            this.groupBoxPlanoLivre.TabIndex = 10;
            this.groupBoxPlanoLivre.TabStop = false;
            this.groupBoxPlanoLivre.Text = "Plano Livre";
            // 
            // txtPlanoLivreValorDiario
            // 
            this.txtPlanoLivreValorDiario.Location = new System.Drawing.Point(6, 19);
            this.txtPlanoLivreValorDiario.Name = "txtPlanoLivreValorDiario";
            this.txtPlanoLivreValorDiario.Size = new System.Drawing.Size(109, 20);
            this.txtPlanoLivreValorDiario.TabIndex = 3;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(164, 7);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 11;
            this.labelCategoria.Text = "Categoria";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(54, 7);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(18, 13);
            this.labeld.TabIndex = 13;
            this.labeld.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(15, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // TelaGrupoVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 194);
            this.Controls.Add(this.labeld);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.groupBoxPlanoLivre);
            this.Controls.Add(this.groupBoxPlanoControlado);
            this.Controls.Add(this.groupBoxPlanoDiario);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGrupoVeiculoForm";
            this.Text = "Cadastro Grupo de Veículos";
            this.groupBoxPlanoDiario.ResumeLayout(false);
            this.groupBoxPlanoDiario.PerformLayout();
            this.groupBoxPlanoControlado.ResumeLayout(false);
            this.groupBoxPlanoControlado.PerformLayout();
            this.groupBoxPlanoLivre.ResumeLayout(false);
            this.groupBoxPlanoLivre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPlanoDiarioValorDiario;
        private System.Windows.Forms.TextBox txtPlanoDiarioValorKm;
        private System.Windows.Forms.GroupBox groupBoxPlanoDiario;
        private System.Windows.Forms.GroupBox groupBoxPlanoControlado;
        private System.Windows.Forms.TextBox txtPlanoControladoValorDiario;
        private System.Windows.Forms.TextBox txtPlanoControladoValorKm;
        private System.Windows.Forms.GroupBox groupBoxPlanoLivre;
        private System.Windows.Forms.TextBox txtPlanoLivreValorDiario;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.TextBox txtId;
    }
}