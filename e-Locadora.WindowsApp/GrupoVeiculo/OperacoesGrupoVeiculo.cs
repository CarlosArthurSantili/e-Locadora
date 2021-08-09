using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.GrupodeVeiculos
{
    public class OperacoesGrupoVeiculo : ICadastravel
    {
        private readonly ControladorGrupoVeiculo controlador = null;

        private readonly TabelaGrupoVeiculoControl tabela = null;

        public OperacoesGrupoVeiculo(ControladorGrupoVeiculo controlador)
        {
            this.controlador = controlador;
            tabela = new TabelaGrupoVeiculoControl();
        }

        public void InserirNovoRegistro()
        {
       
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

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
