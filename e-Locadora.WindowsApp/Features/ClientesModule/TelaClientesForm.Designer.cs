
namespace e_Locadora.WindowsApp.ClientesModule
{
    partial class TelaClientesForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoPessoa = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosPessoa = new System.Windows.Forms.GroupBox();
            this.groupBoxTipoPessoa.SuspendLayout();
            this.groupBoxDadosPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(446, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(365, 219);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número do CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Número do RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Endereço Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(113, 76);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(165, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(113, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Text = "0";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(113, 102);
            this.TxtTelefone.Mask = "(99) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Número do CNPJ";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(393, 46);
            this.txtRG.Mask = "000000000";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(393, 72);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(393, 99);
            this.txtCnpj.Mask = "00000000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 6;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(6, 19);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(152, 17);
            this.rbCPF.TabIndex = 9;
            this.rbCPF.Text = "Cadastro de Pessoa Física";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(164, 19);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(159, 17);
            this.rbCNPJ.TabIndex = 10;
            this.rbCNPJ.Text = "Cadastro de Pessoa Juridica";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // groupBoxTipoPessoa
            // 
            this.groupBoxTipoPessoa.Controls.Add(this.rbCPF);
            this.groupBoxTipoPessoa.Controls.Add(this.rbCNPJ);
            this.groupBoxTipoPessoa.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTipoPessoa.Name = "groupBoxTipoPessoa";
            this.groupBoxTipoPessoa.Size = new System.Drawing.Size(331, 52);
            this.groupBoxTipoPessoa.TabIndex = 29;
            this.groupBoxTipoPessoa.TabStop = false;
            this.groupBoxTipoPessoa.Text = "Tipo de Pessoa";
            // 
            // groupBoxDadosPessoa
            // 
            this.groupBoxDadosPessoa.Controls.Add(this.txtId);
            this.groupBoxDadosPessoa.Controls.Add(this.TxtTelefone);
            this.groupBoxDadosPessoa.Controls.Add(this.txtCnpj);
            this.groupBoxDadosPessoa.Controls.Add(this.txtNome);
            this.groupBoxDadosPessoa.Controls.Add(this.txtCPF);
            this.groupBoxDadosPessoa.Controls.Add(this.txtEndereco);
            this.groupBoxDadosPessoa.Controls.Add(this.txtRG);
            this.groupBoxDadosPessoa.Controls.Add(this.label1);
            this.groupBoxDadosPessoa.Controls.Add(this.label7);
            this.groupBoxDadosPessoa.Controls.Add(this.label2);
            this.groupBoxDadosPessoa.Controls.Add(this.label3);
            this.groupBoxDadosPessoa.Controls.Add(this.label4);
            this.groupBoxDadosPessoa.Controls.Add(this.label6);
            this.groupBoxDadosPessoa.Controls.Add(this.label5);
            this.groupBoxDadosPessoa.Location = new System.Drawing.Point(12, 70);
            this.groupBoxDadosPessoa.Name = "groupBoxDadosPessoa";
            this.groupBoxDadosPessoa.Size = new System.Drawing.Size(509, 143);
            this.groupBoxDadosPessoa.TabIndex = 30;
            this.groupBoxDadosPessoa.TabStop = false;
            this.groupBoxDadosPessoa.Text = "Informações do Cliente";
            // 
            // TelaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 253);
            this.Controls.Add(this.groupBoxDadosPessoa);
            this.Controls.Add(this.groupBoxTipoPessoa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaClientesForm_FormClosing);
            this.Load += new System.EventHandler(this.TelaClientesForm_Load);
            this.groupBoxTipoPessoa.ResumeLayout(false);
            this.groupBoxTipoPessoa.PerformLayout();
            this.groupBoxDadosPessoa.ResumeLayout(false);
            this.groupBoxDadosPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.GroupBox groupBoxTipoPessoa;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoa;
    }
}