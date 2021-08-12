using e_Locadora.Controladores.CondutorModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.CondutorModule
{
    public class OperacoesCondutores : ICadastravel
    {
        private ControladorCondutor controlador = null;
        private TabelaCondutorControl tabelaCondutor = null;

        public OperacoesCondutores(ControladorCondutor controlador)
        {
            this.controlador = controlador;
            tabelaCondutor = new TabelaCondutorControl(controlador);
        }

        public void InserirNovoRegistro()
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
