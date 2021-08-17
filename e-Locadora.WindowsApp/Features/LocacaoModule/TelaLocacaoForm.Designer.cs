
namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    partial class TelaLocacaoForm
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
            this.groupBoxLocacao = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labeld = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBoxTaxasServicos = new System.Windows.Forms.GroupBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxCarro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxLocacaoDetalhes = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxLocacao.SuspendLayout();
            this.groupBoxTaxasServicos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxCarro.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.groupBoxLocacaoDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocacao
            // 
            this.groupBoxLocacao.Controls.Add(this.groupBoxLocacaoDetalhes);
            this.groupBoxLocacao.Controls.Add(this.groupBoxFuncionario);
            this.groupBoxLocacao.Controls.Add(this.groupBoxCarro);
            this.groupBoxLocacao.Controls.Add(this.groupBoxCliente);
            this.groupBoxLocacao.Controls.Add(this.groupBoxTaxasServicos);
            this.groupBoxLocacao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLocacao.Name = "groupBoxLocacao";
            this.groupBoxLocacao.Size = new System.Drawing.Size(859, 426);
            this.groupBoxLocacao.TabIndex = 85;
            this.groupBoxLocacao.TabStop = false;
            this.groupBoxLocacao.Text = "Informações da Locação";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(47, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(6, 22);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(18, 13);
            this.labeld.TabIndex = 13;
            this.labeld.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(796, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(715, 444);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 83;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // groupBoxTaxasServicos
            // 
            this.groupBoxTaxasServicos.Controls.Add(this.comboBox3);
            this.groupBoxTaxasServicos.Controls.Add(this.label20);
            this.groupBoxTaxasServicos.Controls.Add(this.textBox16);
            this.groupBoxTaxasServicos.Location = new System.Drawing.Point(662, 19);
            this.groupBoxTaxasServicos.Name = "groupBoxTaxasServicos";
            this.groupBoxTaxasServicos.Size = new System.Drawing.Size(172, 401);
            this.groupBoxTaxasServicos.TabIndex = 86;
            this.groupBoxTaxasServicos.TabStop = false;
            this.groupBoxTaxasServicos.Text = "Taxas e Serviços Adicionais";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.comboBox2);
            this.groupBoxCliente.Controls.Add(this.textBox2);
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Location = new System.Drawing.Point(495, 19);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(161, 401);
            this.groupBoxCliente.TabIndex = 87;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // groupBoxCarro
            // 
            this.groupBoxCarro.Controls.Add(this.comboBox1);
            this.groupBoxCarro.Controls.Add(this.labeld);
            this.groupBoxCarro.Controls.Add(this.txtId);
            this.groupBoxCarro.Location = new System.Drawing.Point(332, 19);
            this.groupBoxCarro.Name = "groupBoxCarro";
            this.groupBoxCarro.Size = new System.Drawing.Size(157, 401);
            this.groupBoxCarro.TabIndex = 88;
            this.groupBoxCarro.TabStop = false;
            this.groupBoxCarro.Text = "Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(51, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 82;
            this.textBox2.Text = "0";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(62, 19);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(104, 20);
            this.textBox16.TabIndex = 87;
            this.textBox16.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 90;
            this.label20.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(62, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(104, 21);
            this.comboBox3.TabIndex = 86;
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.comboBox4);
            this.groupBoxFuncionario.Controls.Add(this.label1);
            this.groupBoxFuncionario.Controls.Add(this.textBox1);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(169, 19);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(157, 401);
            this.groupBoxFuncionario.TabIndex = 89;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Funcionário";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(47, 45);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(104, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(47, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // groupBoxLocacaoDetalhes
            // 
            this.groupBoxLocacaoDetalhes.Controls.Add(this.comboBox5);
            this.groupBoxLocacaoDetalhes.Controls.Add(this.label2);
            this.groupBoxLocacaoDetalhes.Controls.Add(this.textBox3);
            this.groupBoxLocacaoDetalhes.Location = new System.Drawing.Point(6, 19);
            this.groupBoxLocacaoDetalhes.Name = "groupBoxLocacaoDetalhes";
            this.groupBoxLocacaoDetalhes.Size = new System.Drawing.Size(157, 401);
            this.groupBoxLocacaoDetalhes.TabIndex = 90;
            this.groupBoxLocacaoDetalhes.TabStop = false;
            this.groupBoxLocacaoDetalhes.Text = "Detalhes Locacao";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(47, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(104, 21);
            this.comboBox5.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(47, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "0";
            // 
            // TelaLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 479);
            this.Controls.Add(this.groupBoxLocacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "TelaLocacaoForm";
            this.Text = "TelaLocacaoForm";
            this.groupBoxLocacao.ResumeLayout(false);
            this.groupBoxTaxasServicos.ResumeLayout(false);
            this.groupBoxTaxasServicos.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxCarro.ResumeLayout(false);
            this.groupBoxCarro.PerformLayout();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.groupBoxLocacaoDetalhes.ResumeLayout(false);
            this.groupBoxLocacaoDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocacao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBoxTaxasServicos;
        private System.Windows.Forms.GroupBox groupBoxCarro;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBoxLocacaoDetalhes;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
    }
}