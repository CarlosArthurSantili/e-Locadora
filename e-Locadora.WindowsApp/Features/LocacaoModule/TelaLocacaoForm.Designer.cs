
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
            this.label4 = new System.Windows.Forms.Label();
            this.labelDataLocacao = new System.Windows.Forms.Label();
            this.labelPlano = new System.Windows.Forms.Label();
            this.cboxPlano = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLocacao = new System.Windows.Forms.TextBox();
            this.txtQuilometragemDevolucao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxVeiculo = new System.Windows.Forms.ComboBox();
            this.labeld = new System.Windows.Forms.Label();
            this.txtIdVeiculo = new System.Windows.Forms.TextBox();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxFuncionario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLocacao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeguroTerceiro = new System.Windows.Forms.TextBox();
            this.txtSeguroCliente = new System.Windows.Forms.TextBox();
            this.checkBoxSeguroTerceiro = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIdCondutor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxCondutor = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cListBoxTaxasServicos = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdTaxasServicos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxGrupoVeiculo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data Devolução";
            // 
            // labelDataLocacao
            // 
            this.labelDataLocacao.AutoSize = true;
            this.labelDataLocacao.Location = new System.Drawing.Point(164, 16);
            this.labelDataLocacao.Name = "labelDataLocacao";
            this.labelDataLocacao.Size = new System.Drawing.Size(75, 13);
            this.labelDataLocacao.TabIndex = 19;
            this.labelDataLocacao.Text = "Data Locação";
            // 
            // labelPlano
            // 
            this.labelPlano.AutoSize = true;
            this.labelPlano.Location = new System.Drawing.Point(6, 42);
            this.labelPlano.Name = "labelPlano";
            this.labelPlano.Size = new System.Drawing.Size(34, 13);
            this.labelPlano.TabIndex = 15;
            this.labelPlano.Text = "Plano";
            // 
            // cboxPlano
            // 
            this.cboxPlano.FormattingEnabled = true;
            this.cboxPlano.Items.AddRange(new object[] {
            "Diário",
            "Km Controlado",
            "Km Livre"});
            this.cboxPlano.Location = new System.Drawing.Point(74, 39);
            this.cboxPlano.Name = "cboxPlano";
            this.cboxPlano.Size = new System.Drawing.Size(77, 21);
            this.cboxPlano.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // txtIdLocacao
            // 
            this.txtIdLocacao.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdLocacao.Enabled = false;
            this.txtIdLocacao.Location = new System.Drawing.Point(74, 9);
            this.txtIdLocacao.Name = "txtIdLocacao";
            this.txtIdLocacao.Size = new System.Drawing.Size(77, 20);
            this.txtIdLocacao.TabIndex = 1;
            this.txtIdLocacao.Text = "0";
            // 
            // txtQuilometragemDevolucao
            // 
            this.txtQuilometragemDevolucao.Location = new System.Drawing.Point(144, 95);
            this.txtQuilometragemDevolucao.Name = "txtQuilometragemDevolucao";
            this.txtQuilometragemDevolucao.Size = new System.Drawing.Size(104, 20);
            this.txtQuilometragemDevolucao.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quilometragem Devolução";
            // 
            // cboxVeiculo
            // 
            this.cboxVeiculo.FormattingEnabled = true;
            this.cboxVeiculo.Location = new System.Drawing.Point(144, 68);
            this.cboxVeiculo.Name = "cboxVeiculo";
            this.cboxVeiculo.Size = new System.Drawing.Size(104, 21);
            this.cboxVeiculo.TabIndex = 14;
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(6, 14);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(18, 13);
            this.labeld.TabIndex = 13;
            this.labeld.Text = "ID";
            // 
            // txtIdVeiculo
            // 
            this.txtIdVeiculo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdVeiculo.Enabled = false;
            this.txtIdVeiculo.Location = new System.Drawing.Point(144, 14);
            this.txtIdVeiculo.Name = "txtIdVeiculo";
            this.txtIdVeiculo.Size = new System.Drawing.Size(104, 20);
            this.txtIdVeiculo.TabIndex = 1;
            this.txtIdVeiculo.Text = "0";
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(51, 49);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(104, 21);
            this.cboxCliente.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 239);
            this.tabControl1.TabIndex = 86;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboxFuncionario);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.maskedTextBoxDevolucao);
            this.tabPage1.Controls.Add(this.maskedTextBoxLocacao);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboxPlano);
            this.tabPage1.Controls.Add(this.labelDataLocacao);
            this.tabPage1.Controls.Add(this.txtIdLocacao);
            this.tabPage1.Controls.Add(this.labelPlano);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalhes de Locação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboxFuncionario
            // 
            this.cboxFuncionario.FormattingEnabled = true;
            this.cboxFuncionario.Location = new System.Drawing.Point(74, 72);
            this.cboxFuncionario.Name = "cboxFuncionario";
            this.cboxFuncionario.Size = new System.Drawing.Size(77, 21);
            this.cboxFuncionario.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Funcionario";
            // 
            // maskedTextBoxDevolucao
            // 
            this.maskedTextBoxDevolucao.Location = new System.Drawing.Point(261, 39);
            this.maskedTextBoxDevolucao.Mask = "00/00/0000";
            this.maskedTextBoxDevolucao.Name = "maskedTextBoxDevolucao";
            this.maskedTextBoxDevolucao.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxDevolucao.TabIndex = 24;
            this.maskedTextBoxDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxLocacao
            // 
            this.maskedTextBoxLocacao.Location = new System.Drawing.Point(261, 13);
            this.maskedTextBoxLocacao.Mask = "00/00/0000";
            this.maskedTextBoxLocacao.Name = "maskedTextBoxLocacao";
            this.maskedTextBoxLocacao.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxLocacao.TabIndex = 23;
            this.maskedTextBoxLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeguroTerceiro);
            this.groupBox1.Controls.Add(this.txtSeguroCliente);
            this.groupBox1.Controls.Add(this.checkBoxSeguroTerceiro);
            this.groupBox1.Controls.Add(this.checkBoxCliente);
            this.groupBox1.Location = new System.Drawing.Point(9, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 91);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguros";
            // 
            // txtSeguroTerceiro
            // 
            this.txtSeguroTerceiro.Enabled = false;
            this.txtSeguroTerceiro.Location = new System.Drawing.Point(134, 56);
            this.txtSeguroTerceiro.Name = "txtSeguroTerceiro";
            this.txtSeguroTerceiro.Size = new System.Drawing.Size(100, 20);
            this.txtSeguroTerceiro.TabIndex = 3;
            this.txtSeguroTerceiro.Text = "0";
            // 
            // txtSeguroCliente
            // 
            this.txtSeguroCliente.Enabled = false;
            this.txtSeguroCliente.Location = new System.Drawing.Point(133, 30);
            this.txtSeguroCliente.Name = "txtSeguroCliente";
            this.txtSeguroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtSeguroCliente.TabIndex = 2;
            this.txtSeguroCliente.Text = "0";
            // 
            // checkBoxSeguroTerceiro
            // 
            this.checkBoxSeguroTerceiro.AutoSize = true;
            this.checkBoxSeguroTerceiro.Location = new System.Drawing.Point(26, 58);
            this.checkBoxSeguroTerceiro.Name = "checkBoxSeguroTerceiro";
            this.checkBoxSeguroTerceiro.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSeguroTerceiro.TabIndex = 1;
            this.checkBoxSeguroTerceiro.Text = "Seguro Terceiro";
            this.checkBoxSeguroTerceiro.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Location = new System.Drawing.Point(26, 33);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(95, 17);
            this.checkBoxCliente.TabIndex = 0;
            this.checkBoxCliente.Text = "Seguro Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIdCondutor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cboxCondutor);
            this.tabPage2.Controls.Add(this.txtIdCliente);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cboxCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIdCondutor
            // 
            this.txtIdCondutor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdCondutor.Enabled = false;
            this.txtIdCondutor.Location = new System.Drawing.Point(240, 18);
            this.txtIdCondutor.Name = "txtIdCondutor";
            this.txtIdCondutor.Size = new System.Drawing.Size(104, 20);
            this.txtIdCondutor.TabIndex = 22;
            this.txtIdCondutor.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Condutor";
            // 
            // cboxCondutor
            // 
            this.cboxCondutor.FormattingEnabled = true;
            this.cboxCondutor.Location = new System.Drawing.Point(240, 54);
            this.cboxCondutor.Name = "cboxCondutor";
            this.cboxCondutor.Size = new System.Drawing.Size(104, 21);
            this.cboxCondutor.TabIndex = 19;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(51, 15);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(104, 20);
            this.txtIdCliente.TabIndex = 18;
            this.txtIdCliente.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cliente";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboxGrupoVeiculo);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtQuilometragemDevolucao);
            this.tabPage3.Controls.Add(this.txtIdVeiculo);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.labeld);
            this.tabPage3.Controls.Add(this.cboxVeiculo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(354, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Veiculo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Veiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cListBoxTaxasServicos);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.txtIdTaxasServicos);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(354, 213);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Taxas e Serviços Adicionais";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cListBoxTaxasServicos
            // 
            this.cListBoxTaxasServicos.FormattingEnabled = true;
            this.cListBoxTaxasServicos.Location = new System.Drawing.Point(101, 55);
            this.cListBoxTaxasServicos.Name = "cListBoxTaxasServicos";
            this.cListBoxTaxasServicos.Size = new System.Drawing.Size(157, 79);
            this.cListBoxTaxasServicos.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Taxas e Serviços";
            // 
            // txtIdTaxasServicos
            // 
            this.txtIdTaxasServicos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdTaxasServicos.Enabled = false;
            this.txtIdTaxasServicos.Location = new System.Drawing.Point(101, 15);
            this.txtIdTaxasServicos.Name = "txtIdTaxasServicos";
            this.txtIdTaxasServicos.Size = new System.Drawing.Size(104, 20);
            this.txtIdTaxasServicos.TabIndex = 93;
            this.txtIdTaxasServicos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "ID";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(205, 257);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 83;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(286, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Categoria";
            // 
            // cboxGrupoVeiculo
            // 
            this.cboxGrupoVeiculo.FormattingEnabled = true;
            this.cboxGrupoVeiculo.Location = new System.Drawing.Point(144, 40);
            this.cboxGrupoVeiculo.Name = "cboxGrupoVeiculo";
            this.cboxGrupoVeiculo.Size = new System.Drawing.Size(104, 21);
            this.cboxGrupoVeiculo.TabIndex = 26;
            // 
            // TelaLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 303);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLocacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Locações";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdVeiculo;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.ComboBox cboxVeiculo;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.ComboBox cboxPlano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLocacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDataLocacao;
        private System.Windows.Forms.Label labelPlano;
        private System.Windows.Forms.TextBox txtQuilometragemDevolucao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtIdCondutor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxCondutor;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cListBoxTaxasServicos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdTaxasServicos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSeguroTerceiro;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeguroTerceiro;
        private System.Windows.Forms.TextBox txtSeguroCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDevolucao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLocacao;
        private System.Windows.Forms.ComboBox cboxFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxGrupoVeiculo;
        private System.Windows.Forms.Label label13;
    }
}