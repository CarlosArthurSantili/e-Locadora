
namespace e_Locadora.WindowsApp.Features.Veiculo
{
    partial class TelaVeiculoForm
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
            this.pictureBoxVeiculo = new System.Windows.Forms.PictureBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.groupBoxImagemVeiculo = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtQtdPortas = new System.Windows.Forms.TextBox();
            this.txtCapacidadeTanque = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelChassi = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelCapacidadeTanque = new System.Windows.Forms.Label();
            this.labelQtdPortas = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.labelCapacidadePessoas = new System.Windows.Forms.Label();
            this.txtCapacidadePessoas = new System.Windows.Forms.TextBox();
            this.comboBoxGasolina = new System.Windows.Forms.ComboBox();
            this.labelGasolina = new System.Windows.Forms.Label();
            this.labelPortaMalas = new System.Windows.Forms.Label();
            this.comboBoxPortaMalas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeiculo)).BeginInit();
            this.groupBoxImagemVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxVeiculo
            // 
            this.pictureBoxVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxVeiculo.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxVeiculo.Name = "pictureBoxVeiculo";
            this.pictureBoxVeiculo.Size = new System.Drawing.Size(258, 146);
            this.pictureBoxVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVeiculo.TabIndex = 0;
            this.pictureBoxVeiculo.TabStop = false;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(340, 183);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(75, 23);
            this.btnImagem.TabIndex = 1;
            this.btnImagem.Text = "Upload";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // groupBoxImagemVeiculo
            // 
            this.groupBoxImagemVeiculo.Controls.Add(this.pictureBoxVeiculo);
            this.groupBoxImagemVeiculo.Location = new System.Drawing.Point(241, 12);
            this.groupBoxImagemVeiculo.Name = "groupBoxImagemVeiculo";
            this.groupBoxImagemVeiculo.Size = new System.Drawing.Size(264, 165);
            this.groupBoxImagemVeiculo.TabIndex = 2;
            this.groupBoxImagemVeiculo.TabStop = false;
            this.groupBoxImagemVeiculo.Text = "Imagem do Veículo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(427, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(346, 244);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(126, 9);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(126, 35);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(100, 20);
            this.txtChassi.TabIndex = 6;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(126, 61);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 7;
            // 
            // txtQtdPortas
            // 
            this.txtQtdPortas.Location = new System.Drawing.Point(126, 139);
            this.txtQtdPortas.Name = "txtQtdPortas";
            this.txtQtdPortas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPortas.TabIndex = 10;
            // 
            // txtCapacidadeTanque
            // 
            this.txtCapacidadeTanque.Location = new System.Drawing.Point(126, 113);
            this.txtCapacidadeTanque.Name = "txtCapacidadeTanque";
            this.txtCapacidadeTanque.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadeTanque.TabIndex = 9;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(126, 87);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 8;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(13, 12);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(34, 13);
            this.labelPlaca.TabIndex = 11;
            this.labelPlaca.Text = "Placa";
            // 
            // labelChassi
            // 
            this.labelChassi.AutoSize = true;
            this.labelChassi.Location = new System.Drawing.Point(12, 41);
            this.labelChassi.Name = "labelChassi";
            this.labelChassi.Size = new System.Drawing.Size(38, 13);
            this.labelChassi.TabIndex = 12;
            this.labelChassi.Text = "Chassi";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(13, 67);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(23, 13);
            this.labelCor.TabIndex = 13;
            this.labelCor.Text = "Cor";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(13, 93);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(57, 13);
            this.labelFabricante.TabIndex = 14;
            this.labelFabricante.Text = "Fabricante";
            // 
            // labelCapacidadeTanque
            // 
            this.labelCapacidadeTanque.AutoSize = true;
            this.labelCapacidadeTanque.Location = new System.Drawing.Point(13, 119);
            this.labelCapacidadeTanque.Name = "labelCapacidadeTanque";
            this.labelCapacidadeTanque.Size = new System.Drawing.Size(104, 13);
            this.labelCapacidadeTanque.TabIndex = 15;
            this.labelCapacidadeTanque.Text = "Capacidade Tanque";
            // 
            // labelQtdPortas
            // 
            this.labelQtdPortas.AutoSize = true;
            this.labelQtdPortas.Location = new System.Drawing.Point(13, 145);
            this.labelQtdPortas.Name = "labelQtdPortas";
            this.labelQtdPortas.Size = new System.Drawing.Size(110, 13);
            this.labelQtdPortas.TabIndex = 16;
            this.labelQtdPortas.Text = "Quantidade de Portas";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(13, 168);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 18;
            this.labelAno.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(126, 165);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 17;
            // 
            // labelCapacidadePessoas
            // 
            this.labelCapacidadePessoas.AutoSize = true;
            this.labelCapacidadePessoas.Location = new System.Drawing.Point(13, 194);
            this.labelCapacidadePessoas.Name = "labelCapacidadePessoas";
            this.labelCapacidadePessoas.Size = new System.Drawing.Size(107, 13);
            this.labelCapacidadePessoas.TabIndex = 20;
            this.labelCapacidadePessoas.Text = "Capacidade Pessoas";
            // 
            // txtCapacidadePessoas
            // 
            this.txtCapacidadePessoas.Location = new System.Drawing.Point(126, 191);
            this.txtCapacidadePessoas.Name = "txtCapacidadePessoas";
            this.txtCapacidadePessoas.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadePessoas.TabIndex = 19;
            // 
            // comboBoxGasolina
            // 
            this.comboBoxGasolina.FormattingEnabled = true;
            this.comboBoxGasolina.Location = new System.Drawing.Point(126, 217);
            this.comboBoxGasolina.Name = "comboBoxGasolina";
            this.comboBoxGasolina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGasolina.TabIndex = 21;
            // 
            // labelGasolina
            // 
            this.labelGasolina.AutoSize = true;
            this.labelGasolina.Location = new System.Drawing.Point(13, 220);
            this.labelGasolina.Name = "labelGasolina";
            this.labelGasolina.Size = new System.Drawing.Size(87, 13);
            this.labelGasolina.TabIndex = 22;
            this.labelGasolina.Text = "Tipo de Gasolina";
            // 
            // labelPortaMalas
            // 
            this.labelPortaMalas.AutoSize = true;
            this.labelPortaMalas.Location = new System.Drawing.Point(13, 247);
            this.labelPortaMalas.Name = "labelPortaMalas";
            this.labelPortaMalas.Size = new System.Drawing.Size(111, 13);
            this.labelPortaMalas.TabIndex = 24;
            this.labelPortaMalas.Text = "Tamanho Porta Malas";
            // 
            // comboBoxPortaMalas
            // 
            this.comboBoxPortaMalas.FormattingEnabled = true;
            this.comboBoxPortaMalas.Location = new System.Drawing.Point(126, 244);
            this.comboBoxPortaMalas.Name = "comboBoxPortaMalas";
            this.comboBoxPortaMalas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortaMalas.TabIndex = 23;
            // 
            // TelaVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 282);
            this.Controls.Add(this.labelPortaMalas);
            this.Controls.Add(this.comboBoxPortaMalas);
            this.Controls.Add(this.labelGasolina);
            this.Controls.Add(this.comboBoxGasolina);
            this.Controls.Add(this.labelCapacidadePessoas);
            this.Controls.Add(this.txtCapacidadePessoas);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.labelQtdPortas);
            this.Controls.Add(this.labelCapacidadeTanque);
            this.Controls.Add(this.labelFabricante);
            this.Controls.Add(this.labelCor);
            this.Controls.Add(this.labelChassi);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.txtQtdPortas);
            this.Controls.Add(this.txtCapacidadeTanque);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxImagemVeiculo);
            this.Controls.Add(this.btnImagem);
            this.Name = "TelaVeiculoForm";
            this.Text = "TelaVeiculoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeiculo)).EndInit();
            this.groupBoxImagemVeiculo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVeiculo;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.GroupBox groupBoxImagemVeiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtQtdPortas;
        private System.Windows.Forms.TextBox txtCapacidadeTanque;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelChassi;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelCapacidadeTanque;
        private System.Windows.Forms.Label labelQtdPortas;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label labelCapacidadePessoas;
        private System.Windows.Forms.TextBox txtCapacidadePessoas;
        private System.Windows.Forms.ComboBox comboBoxGasolina;
        private System.Windows.Forms.Label labelGasolina;
        private System.Windows.Forms.Label labelPortaMalas;
        private System.Windows.Forms.ComboBox comboBoxPortaMalas;
    }
}