
namespace e_Locadora.WindowsApp.Features.DevolucaoModule
{
    partial class TelaDevolucaoForm
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
            this.groupBoxDatas = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDataRetornoAtual = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataRetornoPrevisto = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVeiculo = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtTipoCombustivel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuilometragemInicial = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdCombustivelRetorno = new System.Windows.Forms.TextBox();
            this.labelQuantidadeCombustivel = new System.Windows.Forms.Label();
            this.txtQuilometragemAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxResumoFinanceiro = new System.Windows.Forms.GroupBox();
            this.labelVariavelCombustivel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelVariavelSeguros = new System.Windows.Forms.Label();
            this.labelSeguros = new System.Windows.Forms.Label();
            this.labelVariavelValorTotal = new System.Windows.Forms.Label();
            this.labelVariavelCustosTaxasServicos = new System.Windows.Forms.Label();
            this.labelVariavelCustosPlano = new System.Windows.Forms.Label();
            this.labelVariavelDiasPrevistos = new System.Windows.Forms.Label();
            this.labelCustosTaxasServicos = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelCustosPlano = new System.Windows.Forms.Label();
            this.labelDiasPrevistos = new System.Windows.Forms.Label();
            this.tabControlLocacao = new System.Windows.Forms.TabControl();
            this.tabPageLocacao = new System.Windows.Forms.TabPage();
            this.groupBoxLocacao = new System.Windows.Forms.GroupBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtIdLocacao = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.labelPlano = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageClienteVeiculo = new System.Windows.Forms.TabPage();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageAdicionais = new System.Windows.Forms.TabPage();
            this.groupBoxTaxasServicos = new System.Windows.Forms.GroupBox();
            this.cListBoxTaxasServicos = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeguroTerceiro = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxSeguroTerceiro = new System.Windows.Forms.CheckBox();
            this.txtSeguroCliente = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxSeguroCliente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDatas.SuspendLayout();
            this.groupBoxVeiculo.SuspendLayout();
            this.groupBoxResumoFinanceiro.SuspendLayout();
            this.tabControlLocacao.SuspendLayout();
            this.tabPageLocacao.SuspendLayout();
            this.groupBoxLocacao.SuspendLayout();
            this.tabPageClienteVeiculo.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.tabPageAdicionais.SuspendLayout();
            this.groupBoxTaxasServicos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatas
            // 
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataRetornoAtual);
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataLocacao);
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataRetornoPrevisto);
            this.groupBoxDatas.Controls.Add(this.label7);
            this.groupBoxDatas.Controls.Add(this.label6);
            this.groupBoxDatas.Controls.Add(this.label1);
            this.groupBoxDatas.Location = new System.Drawing.Point(6, 118);
            this.groupBoxDatas.Name = "groupBoxDatas";
            this.groupBoxDatas.Size = new System.Drawing.Size(267, 107);
            this.groupBoxDatas.TabIndex = 91;
            this.groupBoxDatas.TabStop = false;
            this.groupBoxDatas.Text = "Datas";
            // 
            // maskedTextBoxDataRetornoAtual
            // 
            this.maskedTextBoxDataRetornoAtual.Location = new System.Drawing.Point(118, 71);
            this.maskedTextBoxDataRetornoAtual.Mask = "00/00/0000";
            this.maskedTextBoxDataRetornoAtual.Name = "maskedTextBoxDataRetornoAtual";
            this.maskedTextBoxDataRetornoAtual.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataRetornoAtual.TabIndex = 38;
            this.maskedTextBoxDataRetornoAtual.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataRetornoAtual.TextChanged += new System.EventHandler(this.maskedTextBoxDataRetornoAtual_TextChanged);
            // 
            // maskedTextBoxDataLocacao
            // 
            this.maskedTextBoxDataLocacao.Enabled = false;
            this.maskedTextBoxDataLocacao.Location = new System.Drawing.Point(118, 19);
            this.maskedTextBoxDataLocacao.Mask = "00/00/0000";
            this.maskedTextBoxDataLocacao.Name = "maskedTextBoxDataLocacao";
            this.maskedTextBoxDataLocacao.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataLocacao.TabIndex = 35;
            this.maskedTextBoxDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataRetornoPrevisto
            // 
            this.maskedTextBoxDataRetornoPrevisto.Enabled = false;
            this.maskedTextBoxDataRetornoPrevisto.Location = new System.Drawing.Point(118, 45);
            this.maskedTextBoxDataRetornoPrevisto.Mask = "00/00/0000";
            this.maskedTextBoxDataRetornoPrevisto.Name = "maskedTextBoxDataRetornoPrevisto";
            this.maskedTextBoxDataRetornoPrevisto.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataRetornoPrevisto.TabIndex = 36;
            this.maskedTextBoxDataRetornoPrevisto.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Data Locação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Devolução Prevista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Devolução Atual";
            // 
            // groupBoxVeiculo
            // 
            this.groupBoxVeiculo.Controls.Add(this.groupBox2);
            this.groupBoxVeiculo.Controls.Add(this.txtCategoria);
            this.groupBoxVeiculo.Controls.Add(this.txtVeiculo);
            this.groupBoxVeiculo.Controls.Add(this.label13);
            this.groupBoxVeiculo.Controls.Add(this.txtQuilometragemInicial);
            this.groupBoxVeiculo.Controls.Add(this.labelModelo);
            this.groupBoxVeiculo.Controls.Add(this.label5);
            this.groupBoxVeiculo.Controls.Add(this.txtQuilometragemAtual);
            this.groupBoxVeiculo.Controls.Add(this.label4);
            this.groupBoxVeiculo.Location = new System.Drawing.Point(6, 94);
            this.groupBoxVeiculo.Name = "groupBoxVeiculo";
            this.groupBoxVeiculo.Size = new System.Drawing.Size(264, 211);
            this.groupBoxVeiculo.TabIndex = 39;
            this.groupBoxVeiculo.TabStop = false;
            this.groupBoxVeiculo.Text = "Veículo";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(146, 19);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(104, 20);
            this.txtCategoria.TabIndex = 40;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Enabled = false;
            this.txtVeiculo.Location = new System.Drawing.Point(146, 45);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(104, 20);
            this.txtVeiculo.TabIndex = 39;
            // 
            // txtTipoCombustivel
            // 
            this.txtTipoCombustivel.Enabled = false;
            this.txtTipoCombustivel.Location = new System.Drawing.Point(155, 19);
            this.txtTipoCombustivel.Name = "txtTipoCombustivel";
            this.txtTipoCombustivel.Size = new System.Drawing.Size(89, 20);
            this.txtTipoCombustivel.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Categoria";
            // 
            // txtQuilometragemInicial
            // 
            this.txtQuilometragemInicial.Enabled = false;
            this.txtQuilometragemInicial.Location = new System.Drawing.Point(146, 71);
            this.txtQuilometragemInicial.Name = "txtQuilometragemInicial";
            this.txtQuilometragemInicial.Size = new System.Drawing.Size(104, 20);
            this.txtQuilometragemInicial.TabIndex = 33;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(98, 48);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 30;
            this.labelModelo.Text = "Modelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quilometragem Inicial";
            // 
            // txtQtdCombustivelRetorno
            // 
            this.txtQtdCombustivelRetorno.Location = new System.Drawing.Point(155, 45);
            this.txtQtdCombustivelRetorno.Name = "txtQtdCombustivelRetorno";
            this.txtQtdCombustivelRetorno.Size = new System.Drawing.Size(89, 20);
            this.txtQtdCombustivelRetorno.TabIndex = 35;
            this.txtQtdCombustivelRetorno.Text = "0";
            this.txtQtdCombustivelRetorno.TextChanged += new System.EventHandler(this.txtQtdCombustivelRetorno_TextChanged);
            // 
            // labelQuantidadeCombustivel
            // 
            this.labelQuantidadeCombustivel.AutoSize = true;
            this.labelQuantidadeCombustivel.Location = new System.Drawing.Point(6, 48);
            this.labelQuantidadeCombustivel.Name = "labelQuantidadeCombustivel";
            this.labelQuantidadeCombustivel.Size = new System.Drawing.Size(146, 13);
            this.labelQuantidadeCombustivel.TabIndex = 34;
            this.labelQuantidadeCombustivel.Text = "Quantidade a ser resposto (L)";
            // 
            // txtQuilometragemAtual
            // 
            this.txtQuilometragemAtual.Location = new System.Drawing.Point(146, 97);
            this.txtQuilometragemAtual.Name = "txtQuilometragemAtual";
            this.txtQuilometragemAtual.Size = new System.Drawing.Size(104, 20);
            this.txtQuilometragemAtual.TabIndex = 31;
            this.txtQuilometragemAtual.TextChanged += new System.EventHandler(this.txtQuilometragemAtual_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quilometragem Atual";
            // 
            // groupBoxResumoFinanceiro
            // 
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelCombustivel);
            this.groupBoxResumoFinanceiro.Controls.Add(this.label10);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelSeguros);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelSeguros);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelValorTotal);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelCustosTaxasServicos);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelCustosPlano);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelVariavelDiasPrevistos);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelCustosTaxasServicos);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelValorTotal);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelCustosPlano);
            this.groupBoxResumoFinanceiro.Controls.Add(this.labelDiasPrevistos);
            this.groupBoxResumoFinanceiro.Location = new System.Drawing.Point(305, 12);
            this.groupBoxResumoFinanceiro.Name = "groupBoxResumoFinanceiro";
            this.groupBoxResumoFinanceiro.Size = new System.Drawing.Size(213, 337);
            this.groupBoxResumoFinanceiro.TabIndex = 91;
            this.groupBoxResumoFinanceiro.TabStop = false;
            this.groupBoxResumoFinanceiro.Text = "Resumo Financeiro";
            // 
            // labelVariavelCombustivel
            // 
            this.labelVariavelCombustivel.AutoSize = true;
            this.labelVariavelCombustivel.Location = new System.Drawing.Point(81, 73);
            this.labelVariavelCombustivel.Name = "labelVariavelCombustivel";
            this.labelVariavelCombustivel.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelCombustivel.TabIndex = 11;
            this.labelVariavelCombustivel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Combustível:";
            // 
            // labelVariavelSeguros
            // 
            this.labelVariavelSeguros.AutoSize = true;
            this.labelVariavelSeguros.Location = new System.Drawing.Point(67, 122);
            this.labelVariavelSeguros.Name = "labelVariavelSeguros";
            this.labelVariavelSeguros.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelSeguros.TabIndex = 9;
            this.labelVariavelSeguros.Text = "0";
            // 
            // labelSeguros
            // 
            this.labelSeguros.AutoSize = true;
            this.labelSeguros.Location = new System.Drawing.Point(6, 122);
            this.labelSeguros.Name = "labelSeguros";
            this.labelSeguros.Size = new System.Drawing.Size(55, 13);
            this.labelSeguros.TabIndex = 8;
            this.labelSeguros.Text = "Seguro(s):";
            // 
            // labelVariavelValorTotal
            // 
            this.labelVariavelValorTotal.AutoSize = true;
            this.labelVariavelValorTotal.Location = new System.Drawing.Point(73, 149);
            this.labelVariavelValorTotal.Name = "labelVariavelValorTotal";
            this.labelVariavelValorTotal.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelValorTotal.TabIndex = 7;
            this.labelVariavelValorTotal.Text = "0";
            // 
            // labelVariavelCustosTaxasServicos
            // 
            this.labelVariavelCustosTaxasServicos.AutoSize = true;
            this.labelVariavelCustosTaxasServicos.Location = new System.Drawing.Point(104, 97);
            this.labelVariavelCustosTaxasServicos.Name = "labelVariavelCustosTaxasServicos";
            this.labelVariavelCustosTaxasServicos.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelCustosTaxasServicos.TabIndex = 6;
            this.labelVariavelCustosTaxasServicos.Text = "0";
            // 
            // labelVariavelCustosPlano
            // 
            this.labelVariavelCustosPlano.AutoSize = true;
            this.labelVariavelCustosPlano.Location = new System.Drawing.Point(124, 47);
            this.labelVariavelCustosPlano.Name = "labelVariavelCustosPlano";
            this.labelVariavelCustosPlano.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelCustosPlano.TabIndex = 5;
            this.labelVariavelCustosPlano.Text = "0";
            // 
            // labelVariavelDiasPrevistos
            // 
            this.labelVariavelDiasPrevistos.AutoSize = true;
            this.labelVariavelDiasPrevistos.Location = new System.Drawing.Point(70, 22);
            this.labelVariavelDiasPrevistos.Name = "labelVariavelDiasPrevistos";
            this.labelVariavelDiasPrevistos.Size = new System.Drawing.Size(13, 13);
            this.labelVariavelDiasPrevistos.TabIndex = 4;
            this.labelVariavelDiasPrevistos.Text = "0";
            // 
            // labelCustosTaxasServicos
            // 
            this.labelCustosTaxasServicos.AutoSize = true;
            this.labelCustosTaxasServicos.Location = new System.Drawing.Point(6, 97);
            this.labelCustosTaxasServicos.Name = "labelCustosTaxasServicos";
            this.labelCustosTaxasServicos.Size = new System.Drawing.Size(92, 13);
            this.labelCustosTaxasServicos.TabIndex = 3;
            this.labelCustosTaxasServicos.Text = "Taxas e Serviços:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(6, 149);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(61, 13);
            this.labelValorTotal.TabIndex = 2;
            this.labelValorTotal.Text = "Valor Total:";
            // 
            // labelCustosPlano
            // 
            this.labelCustosPlano.AutoSize = true;
            this.labelCustosPlano.Location = new System.Drawing.Point(6, 47);
            this.labelCustosPlano.Name = "labelCustosPlano";
            this.labelCustosPlano.Size = new System.Drawing.Size(112, 13);
            this.labelCustosPlano.TabIndex = 1;
            this.labelCustosPlano.Text = "Custos Final do Plano:";
            // 
            // labelDiasPrevistos
            // 
            this.labelDiasPrevistos.AutoSize = true;
            this.labelDiasPrevistos.Location = new System.Drawing.Point(6, 22);
            this.labelDiasPrevistos.Name = "labelDiasPrevistos";
            this.labelDiasPrevistos.Size = new System.Drawing.Size(58, 13);
            this.labelDiasPrevistos.TabIndex = 0;
            this.labelDiasPrevistos.Text = "Total Dias:";
            // 
            // tabControlLocacao
            // 
            this.tabControlLocacao.Controls.Add(this.tabPageLocacao);
            this.tabControlLocacao.Controls.Add(this.tabPageClienteVeiculo);
            this.tabControlLocacao.Controls.Add(this.tabPageAdicionais);
            this.tabControlLocacao.Location = new System.Drawing.Point(12, 12);
            this.tabControlLocacao.Name = "tabControlLocacao";
            this.tabControlLocacao.SelectedIndex = 0;
            this.tabControlLocacao.Size = new System.Drawing.Size(287, 337);
            this.tabControlLocacao.TabIndex = 90;
            // 
            // tabPageLocacao
            // 
            this.tabPageLocacao.Controls.Add(this.groupBoxLocacao);
            this.tabPageLocacao.Controls.Add(this.groupBoxDatas);
            this.tabPageLocacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocacao.Name = "tabPageLocacao";
            this.tabPageLocacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocacao.Size = new System.Drawing.Size(279, 291);
            this.tabPageLocacao.TabIndex = 0;
            this.tabPageLocacao.Text = "Locação";
            this.tabPageLocacao.UseVisualStyleBackColor = true;
            // 
            // groupBoxLocacao
            // 
            this.groupBoxLocacao.Controls.Add(this.txtPlano);
            this.groupBoxLocacao.Controls.Add(this.txtIdLocacao);
            this.groupBoxLocacao.Controls.Add(this.txtFuncionario);
            this.groupBoxLocacao.Controls.Add(this.labelPlano);
            this.groupBoxLocacao.Controls.Add(this.label8);
            this.groupBoxLocacao.Controls.Add(this.label3);
            this.groupBoxLocacao.Location = new System.Drawing.Point(6, 6);
            this.groupBoxLocacao.Name = "groupBoxLocacao";
            this.groupBoxLocacao.Size = new System.Drawing.Size(267, 106);
            this.groupBoxLocacao.TabIndex = 92;
            this.groupBoxLocacao.TabStop = false;
            this.groupBoxLocacao.Text = "Locação";
            // 
            // txtPlano
            // 
            this.txtPlano.Enabled = false;
            this.txtPlano.Location = new System.Drawing.Point(117, 71);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(113, 20);
            this.txtPlano.TabIndex = 92;
            // 
            // txtIdLocacao
            // 
            this.txtIdLocacao.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdLocacao.Enabled = false;
            this.txtIdLocacao.Location = new System.Drawing.Point(118, 19);
            this.txtIdLocacao.Name = "txtIdLocacao";
            this.txtIdLocacao.Size = new System.Drawing.Size(77, 20);
            this.txtIdLocacao.TabIndex = 1;
            this.txtIdLocacao.Text = "0";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(118, 45);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(113, 20);
            this.txtFuncionario.TabIndex = 26;
            // 
            // labelPlano
            // 
            this.labelPlano.AutoSize = true;
            this.labelPlano.Location = new System.Drawing.Point(76, 74);
            this.labelPlano.Name = "labelPlano";
            this.labelPlano.Size = new System.Drawing.Size(34, 13);
            this.labelPlano.TabIndex = 15;
            this.labelPlano.Text = "Plano";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // tabPageClienteVeiculo
            // 
            this.tabPageClienteVeiculo.Controls.Add(this.groupBoxCliente);
            this.tabPageClienteVeiculo.Controls.Add(this.groupBoxVeiculo);
            this.tabPageClienteVeiculo.Location = new System.Drawing.Point(4, 22);
            this.tabPageClienteVeiculo.Name = "tabPageClienteVeiculo";
            this.tabPageClienteVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClienteVeiculo.Size = new System.Drawing.Size(279, 311);
            this.tabPageClienteVeiculo.TabIndex = 1;
            this.tabPageClienteVeiculo.Text = "Cliente e Veículo";
            this.tabPageClienteVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.txtCondutor);
            this.groupBoxCliente.Controls.Add(this.txtCliente);
            this.groupBoxCliente.Controls.Add(this.label15);
            this.groupBoxCliente.Controls.Add(this.label14);
            this.groupBoxCliente.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(264, 82);
            this.groupBoxCliente.TabIndex = 92;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // txtCondutor
            // 
            this.txtCondutor.Enabled = false;
            this.txtCondutor.Location = new System.Drawing.Point(146, 45);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(104, 20);
            this.txtCondutor.TabIndex = 42;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(146, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(104, 20);
            this.txtCliente.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Condutor";
            // 
            // tabPageAdicionais
            // 
            this.tabPageAdicionais.Controls.Add(this.groupBoxTaxasServicos);
            this.tabPageAdicionais.Controls.Add(this.groupBox1);
            this.tabPageAdicionais.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdicionais.Name = "tabPageAdicionais";
            this.tabPageAdicionais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdicionais.Size = new System.Drawing.Size(279, 291);
            this.tabPageAdicionais.TabIndex = 4;
            this.tabPageAdicionais.Text = "Adicionais";
            this.tabPageAdicionais.UseVisualStyleBackColor = true;
            // 
            // groupBoxTaxasServicos
            // 
            this.groupBoxTaxasServicos.Controls.Add(this.cListBoxTaxasServicos);
            this.groupBoxTaxasServicos.Location = new System.Drawing.Point(5, 6);
            this.groupBoxTaxasServicos.Name = "groupBoxTaxasServicos";
            this.groupBoxTaxasServicos.Size = new System.Drawing.Size(268, 199);
            this.groupBoxTaxasServicos.TabIndex = 97;
            this.groupBoxTaxasServicos.TabStop = false;
            this.groupBoxTaxasServicos.Text = "Taxas e Serviços";
            // 
            // cListBoxTaxasServicos
            // 
            this.cListBoxTaxasServicos.Enabled = false;
            this.cListBoxTaxasServicos.FormattingEnabled = true;
            this.cListBoxTaxasServicos.Location = new System.Drawing.Point(6, 19);
            this.cListBoxTaxasServicos.Name = "cListBoxTaxasServicos";
            this.cListBoxTaxasServicos.Size = new System.Drawing.Size(256, 169);
            this.cListBoxTaxasServicos.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeguroTerceiro);
            this.groupBox1.Controls.Add(this.checkBoxSeguroTerceiro);
            this.groupBox1.Controls.Add(this.txtSeguroCliente);
            this.groupBox1.Controls.Add(this.checkBoxSeguroCliente);
            this.groupBox1.Location = new System.Drawing.Point(6, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 74);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguros";
            // 
            // txtSeguroTerceiro
            // 
            this.txtSeguroTerceiro.Enabled = false;
            this.txtSeguroTerceiro.Location = new System.Drawing.Point(121, 46);
            this.txtSeguroTerceiro.Mask = "000000000000000";
            this.txtSeguroTerceiro.Name = "txtSeguroTerceiro";
            this.txtSeguroTerceiro.Size = new System.Drawing.Size(104, 20);
            this.txtSeguroTerceiro.TabIndex = 10;
            this.txtSeguroTerceiro.Text = "0";
            // 
            // checkBoxSeguroTerceiro
            // 
            this.checkBoxSeguroTerceiro.AutoSize = true;
            this.checkBoxSeguroTerceiro.Enabled = false;
            this.checkBoxSeguroTerceiro.Location = new System.Drawing.Point(13, 47);
            this.checkBoxSeguroTerceiro.Name = "checkBoxSeguroTerceiro";
            this.checkBoxSeguroTerceiro.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSeguroTerceiro.TabIndex = 1;
            this.checkBoxSeguroTerceiro.Text = "Seguro Terceiro";
            this.checkBoxSeguroTerceiro.UseVisualStyleBackColor = true;
            // 
            // txtSeguroCliente
            // 
            this.txtSeguroCliente.Enabled = false;
            this.txtSeguroCliente.Location = new System.Drawing.Point(121, 20);
            this.txtSeguroCliente.Mask = "000000000000000";
            this.txtSeguroCliente.Name = "txtSeguroCliente";
            this.txtSeguroCliente.Size = new System.Drawing.Size(104, 20);
            this.txtSeguroCliente.TabIndex = 4;
            this.txtSeguroCliente.Text = "0";
            this.txtSeguroCliente.ValidatingType = typeof(int);
            // 
            // checkBoxSeguroCliente
            // 
            this.checkBoxSeguroCliente.AutoSize = true;
            this.checkBoxSeguroCliente.Enabled = false;
            this.checkBoxSeguroCliente.Location = new System.Drawing.Point(13, 22);
            this.checkBoxSeguroCliente.Name = "checkBoxSeguroCliente";
            this.checkBoxSeguroCliente.Size = new System.Drawing.Size(95, 17);
            this.checkBoxSeguroCliente.TabIndex = 0;
            this.checkBoxSeguroCliente.Text = "Seguro Cliente";
            this.checkBoxSeguroCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(443, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 89;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(362, 355);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 88;
            this.btnGravar.Text = "Devolver";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTipoCombustivel);
            this.groupBox2.Controls.Add(this.txtQtdCombustivelRetorno);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelQuantidadeCombustivel);
            this.groupBox2.Location = new System.Drawing.Point(6, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 79);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combustível";
            // 
            // TelaDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 386);
            this.Controls.Add(this.groupBoxResumoFinanceiro);
            this.Controls.Add(this.tabControlLocacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDevolucaoForm";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.TelaDevolucaoForm_Load);
            this.groupBoxDatas.ResumeLayout(false);
            this.groupBoxDatas.PerformLayout();
            this.groupBoxVeiculo.ResumeLayout(false);
            this.groupBoxVeiculo.PerformLayout();
            this.groupBoxResumoFinanceiro.ResumeLayout(false);
            this.groupBoxResumoFinanceiro.PerformLayout();
            this.tabControlLocacao.ResumeLayout(false);
            this.tabPageLocacao.ResumeLayout(false);
            this.groupBoxLocacao.ResumeLayout(false);
            this.groupBoxLocacao.PerformLayout();
            this.tabPageClienteVeiculo.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.tabPageAdicionais.ResumeLayout(false);
            this.groupBoxTaxasServicos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRetornoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRetornoPrevisto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataLocacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtdCombustivelRetorno;
        private System.Windows.Forms.Label labelQuantidadeCombustivel;
        private System.Windows.Forms.TextBox txtQuilometragemInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuilometragemAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoCombustivel;
        private System.Windows.Forms.GroupBox groupBoxDatas;
        private System.Windows.Forms.GroupBox groupBoxVeiculo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.GroupBox groupBoxResumoFinanceiro;
        private System.Windows.Forms.Label labelVariavelSeguros;
        private System.Windows.Forms.Label labelSeguros;
        private System.Windows.Forms.Label labelVariavelValorTotal;
        private System.Windows.Forms.Label labelVariavelCustosTaxasServicos;
        private System.Windows.Forms.Label labelVariavelCustosPlano;
        private System.Windows.Forms.Label labelVariavelDiasPrevistos;
        private System.Windows.Forms.Label labelCustosTaxasServicos;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelCustosPlano;
        private System.Windows.Forms.Label labelDiasPrevistos;
        private System.Windows.Forms.TabControl tabControlLocacao;
        private System.Windows.Forms.TabPage tabPageLocacao;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdLocacao;
        private System.Windows.Forms.Label labelPlano;
        private System.Windows.Forms.TabPage tabPageClienteVeiculo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPageAdicionais;
        private System.Windows.Forms.GroupBox groupBoxTaxasServicos;
        private System.Windows.Forms.CheckedListBox cListBoxTaxasServicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtSeguroTerceiro;
        private System.Windows.Forms.CheckBox checkBoxSeguroTerceiro;
        private System.Windows.Forms.MaskedTextBox txtSeguroCliente;
        private System.Windows.Forms.CheckBox checkBoxSeguroCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBoxLocacao;
        private System.Windows.Forms.Label labelVariavelCombustivel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}