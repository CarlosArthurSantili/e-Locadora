using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.TaxasServicosModule
{
    public class OperacoesTaxaServicos : ICadastravel
    {
        private ControladorTaxasServicos controlador = null;
        private TabelaTaxaServico tabelaTaxaServicos = null;

        public OperacoesTaxaServicos(ControladorTaxasServicos controlador)
        {
            this.controlador = controlador;
            tabelaTaxaServicos = new TabelaTaxaServico(controlador);
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaTaxaServicosForm tela = new TelaTaxaServicosForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.TaxasServicos);

                tabelaTaxaServicos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Taxa ou Serviço: [{tela.TaxasServicos.Descricao}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
