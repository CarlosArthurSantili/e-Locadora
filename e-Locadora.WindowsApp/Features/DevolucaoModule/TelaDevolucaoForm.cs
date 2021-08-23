﻿using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.DevolucaoModule
{
    public partial class TelaDevolucaoForm : Form
    {
        private Locacao locacao;
        

        public TelaDevolucaoForm()
        {
            InitializeComponent();
        }


        public Locacao Locacao
        {
            get
            {
                return locacao;
            } 
            set
            {
                locacao = value;

                txtVeiculo.Text = locacao.veiculo.ToString();
                txtCliente.Text = locacao.cliente.ToString();
                txtCondutor.Text = locacao.condutor.ToString();
                maskedTextBoxDataLocacao.Text = locacao.dataLocacao.ToString();
                maskedTextBoxDataRetornoPrevisto.Text = locacao.dataDevolucao.ToString();
                maskedTextBoxDataRetornoAtual.Text = Convert.ToDateTime(DateTime.Now).ToString();
                txtTipoCombustivel.Text = locacao.veiculo.Combustivel.ToString();
                txtQuilometragemInicial.Text = locacao.veiculo.Quilometragem.ToString();
                txtQuilometragemAtual.Text = locacao.quilometragemDevolucao.ToString();
                txtValorTotal.Text = Convert.ToDouble(locacao.CalcularValorLocacao()).ToString();
            }
        }
        public string ValidarCampos()
        {
            if(txtVeiculo.Text == "")
            {
                return "Veículo é obrigatório";
            }
            if(txtCliente.Text == "")
            {
                return "Cliente é obrigatório";
            }
            if(txtCondutor.Text == "")
            {
                return "Condutor é obrigatório";
            }
            if(maskedTextBoxDataLocacao.Text == "")
            {
                return "Data de Locação é obrigatório";
            }
            if(maskedTextBoxDataRetornoPrevisto.Text == "")
            {
                return "Data de Retorno Previsto é obrigatório";
            }
            if(maskedTextBoxDataRetornoAtual.Text == "")
            {
                return "Data de Retorno Atual é Obrigatório";
            }
            if(!ValidarTipoInt(txtQuilometragemInicial.Text))
            {
                return "Valor Quilometragem Inicial inválido";
            }
            if (Convert.ToDouble(txtQuilometragemInicial.Text) < 0)
            {
                return "Valor Inicial nao pode ser menos que ZERO!";
            }
            if (!ValidarTipoInt(txtQuilometragemAtual.Text))
            {
                return "Valor Quilometragem Atual inválido";
            }
            if (Convert.ToDouble(txtQuilometragemAtual.Text) < 0)
            {
                return "Valor Atual nao pode ser menos que ZERO!";
            }
            if(!ValidarTipoInt(txtQtdCombustivelRetorno.Text))
            {
                return "Valor de Quantidade de Combustivel Inválida";
            }
            if (Convert.ToDouble(txtQtdCombustivelRetorno.Text) < 0)
            {
                return "Valor da Quantidade de Combustivel nao pode ser menos que ZERO!";
            }
            if(!ValidarTipoDouble(txtCaucao.Text))
            {
                return "Valor de Cauçaão Inválido";
            }
            if(Convert.ToDouble(txtCaucao.Text) < 0)
            {
                return "Valor de Caução não pode ser menor que ZERO!";
            }
            if(!ValidarTipoDouble(txtValorTotal.Text))
            {
                return "Valor Total Inválido";
            }
            if(Convert.ToDouble(txtValorTotal) < 0)
            {
                return "Valor Total não pode ser menor que ZERO!";
            }

            return "ESTA_VALIDO";
        }

        private bool ValidarTipoInt(string texto)
        {
            try
            {
                double numeroConvertido = Convert.ToInt32(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarTipoDouble(string texto)
        {
            try
            {
                double numeroConvertido = Convert.ToDouble(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
        //public List<LocacaoTaxasServicos> LocacaoTaxasServicos
        //{
        //    get
        //    {
        //        return locacaoTaxasServicos;
        //    }
        //    set
        //    {
        //        locacaoTaxasServicos.Clear();

        //        for (int i = 0; i <= (cListBoxTaxasServicos.Items.Count - 1); i++)
        //        {
        //            if (cListBoxTaxasServicos.GetItemChecked(i))
        //            {
        //                TaxasServicos taxaServico = (TaxasServicos)cListBoxTaxasServicos.Items[i];
        //                LocacaoTaxasServicos locacao_TaxaServico = new LocacaoTaxasServicos(locacao, taxaServico);
        //                locacaoTaxasServicos.Add(locacao_TaxaServico);
        //                //controladorLocacaoTaxasServicos.InserirNovo(locacao_TaxaServico);
        //            }
        //        }
        //    }

        //}
    }
}