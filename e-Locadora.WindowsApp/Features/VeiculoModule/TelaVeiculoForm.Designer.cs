
namespace e_Locadora.WindowsApp.Features.VeiculoModule
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
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelPortaMalas = new System.Windows.Forms.Label();
            this.comboBoxPortaMalas = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelGrupoVeiculo = new System.Windows.Forms.Label();
            this.comboBoxGrupoVeiculo = new System.Windows.Forms.ComboBox();
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
            this.btnCancelar.Location = new System.Drawing.Point(430, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(349, 277);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(121, 42);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(121, 68);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(100, 20);
            this.txtChassi.TabIndex = 6;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(121, 94);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 7;
            // 
            // txtQtdPortas
            // 
            this.txtQtdPortas.Location = new System.Drawing.Point(121, 172);
            this.txtQtdPortas.Name = "txtQtdPortas";
            this.txtQtdPortas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPortas.TabIndex = 10;
            // 
            // txtCapacidadeTanque
            // 
            this.txtCapacidadeTanque.Location = new System.Drawing.Point(121, 146);
            this.txtCapacidadeTanque.Name = "txtCapacidadeTanque";
            this.txtCapacidadeTanque.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadeTanque.TabIndex = 9;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(121, 120);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 8;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(7, 45);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(34, 13);
            this.labelPlaca.TabIndex = 11;
            this.labelPlaca.Text = "Placa";
            this.labelPlaca.Click += new System.EventHandler(this.labelPlaca_Click);
            // 
            // labelChassi
            // 
            this.labelChassi.AutoSize = true;
            this.labelChassi.Location = new System.Drawing.Point(7, 71);
            this.labelChassi.Name = "labelChassi";
            this.labelChassi.Size = new System.Drawing.Size(38, 13);
            this.labelChassi.TabIndex = 12;
            this.labelChassi.Text = "Chassi";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(7, 97);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(23, 13);
            this.labelCor.TabIndex = 13;
            this.labelCor.Text = "Cor";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(7, 123);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(57, 13);
            this.labelFabricante.TabIndex = 14;
            this.labelFabricante.Text = "Fabricante";
            // 
            // labelCapacidadeTanque
            // 
            this.labelCapacidadeTanque.AutoSize = true;
            this.labelCapacidadeTanque.Location = new System.Drawing.Point(8, 149);
            this.labelCapacidadeTanque.Name = "labelCapacidadeTanque";
            this.labelCapacidadeTanque.Size = new System.Drawing.Size(104, 13);
            this.labelCapacidadeTanque.TabIndex = 15;
            this.labelCapacidadeTanque.Text = "Capacidade Tanque";
            // 
            // labelQtdPortas
            // 
            this.labelQtdPortas.AutoSize = true;
            this.labelQtdPortas.Location = new System.Drawing.Point(8, 178);
            this.labelQtdPortas.Name = "labelQtdPortas";
            this.labelQtdPortas.Size = new System.Drawing.Size(110, 13);
            this.labelQtdPortas.TabIndex = 16;
            this.labelQtdPortas.Text = "Quantidade de Portas";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(8, 201);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 18;
            this.labelAno.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(121, 198);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 17;
            // 
            // labelCapacidadePessoas
            // 
            this.labelCapacidadePessoas.AutoSize = true;
            this.labelCapacidadePessoas.Location = new System.Drawing.Point(8, 227);
            this.labelCapacidadePessoas.Name = "labelCapacidadePessoas";
            this.labelCapacidadePessoas.Size = new System.Drawing.Size(107, 13);
            this.labelCapacidadePessoas.TabIndex = 20;
            this.labelCapacidadePessoas.Text = "Capacidade Pessoas";
            // 
            // txtCapacidadePessoas
            // 
            this.txtCapacidadePessoas.Location = new System.Drawing.Point(121, 224);
            this.txtCapacidadePessoas.Name = "txtCapacidadePessoas";
            this.txtCapacidadePessoas.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadePessoas.TabIndex = 19;
            // 
            // comboBoxGasolina
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Diesel",
            "Flex"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(121, 250);
            this.comboBoxCombustivel.Name = "comboBoxGasolina";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCombustivel.TabIndex = 21;
            this.comboBoxCombustivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxGasolina_SelectedIndexChanged);
            // 
            // labelGasolina
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(8, 253);
            this.labelCombustivel.Name = "labelGasolina";
            this.labelCombustivel.Size = new System.Drawing.Size(87, 13);
            this.labelCombustivel.TabIndex = 22;
            this.labelCombustivel.Text = "Tipo de Gasolina";
            this.labelCombustivel.Click += new System.EventHandler(this.labelGasolina_Click);
            // 
            // labelPortaMalas
            // 
            this.labelPortaMalas.AutoSize = true;
            this.labelPortaMalas.Location = new System.Drawing.Point(8, 280);
            this.labelPortaMalas.Name = "labelPortaMalas";
            this.labelPortaMalas.Size = new System.Drawing.Size(111, 13);
            this.labelPortaMalas.TabIndex = 24;
            this.labelPortaMalas.Text = "Tamanho Porta Malas";
            this.labelPortaMalas.Click += new System.EventHandler(this.labelPortaMalas_Click);
            // 
            // comboBoxPortaMalas
            // 
            this.comboBoxPortaMalas.FormattingEnabled = true;
            this.comboBoxPortaMalas.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.comboBoxPortaMalas.Location = new System.Drawing.Point(121, 279);
            this.comboBoxPortaMalas.Name = "comboBoxPortaMalas";
            this.comboBoxPortaMalas.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPortaMalas.TabIndex = 23;
            this.comboBoxPortaMalas.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortaMalas_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(7, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 25;
            this.id.Text = "Id";
            this.id.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(121, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 26;
            // 
            // labelGrupoVeiculo
            // 
            this.labelGrupoVeiculo.AutoSize = true;
            this.labelGrupoVeiculo.Location = new System.Drawing.Point(257, 228);
            this.labelGrupoVeiculo.Name = "labelGrupoVeiculo";
            this.labelGrupoVeiculo.Size = new System.Drawing.Size(90, 13);
            this.labelGrupoVeiculo.TabIndex = 28;
            this.labelGrupoVeiculo.Text = "Categoria Veiculo";
            // 
            // comboBoxGrupoVeiculo
            // 
            this.comboBoxGrupoVeiculo.FormattingEnabled = true;
            this.comboBoxGrupoVeiculo.Location = new System.Drawing.Point(353, 224);
            this.comboBoxGrupoVeiculo.Name = "comboBoxGrupoVeiculo";
            this.comboBoxGrupoVeiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGrupoVeiculo.TabIndex = 27;
            // 
            // TelaVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.labelGrupoVeiculo);
            this.Controls.Add(this.comboBoxGrupoVeiculo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.id);
            this.Controls.Add(this.labelPortaMalas);
            this.Controls.Add(this.comboBoxPortaMalas);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.comboBoxCombustivel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaVeiculoForm";
            this.Text = "TelaVeiculoForm";
            this.Load += new System.EventHandler(this.TelaVeiculoForm_Load);
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
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelPortaMalas;
        private System.Windows.Forms.ComboBox comboBoxPortaMalas;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelGrupoVeiculo;
        private System.Windows.Forms.ComboBox comboBoxGrupoVeiculo;
    }
}