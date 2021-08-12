using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.WindowsApp.VeiculoModule
{
    public class ConfiguracaoVeiculoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro de Veiculo";  }
        }
        public string ObterDescricao()
        {
            return TipoCadastro;
        }

        public ConfiguracaoEstadoBotoes ObterEstadoBotoes()
        {
            return new ConfiguracaoEstadoBotoes()
            {
                Agrupar = false,
                Desagrupar = false,
                Filtrar = false
            };
        }

        public ConfiguracaoToolTips ObterToolTips()
        {
            return new ConfiguracaoToolTips()
            {
                Adicionar = "Adicionar um novo Grupo de Veiculo",
                Editar = "Atualizar um Grupo de Veiculo existente",
                Excluir = "Excluir um Grupo de Veiculo existente",
                Filtrar = "Filtrar Grupo de Veiculos"
            };
        }
    }
}
