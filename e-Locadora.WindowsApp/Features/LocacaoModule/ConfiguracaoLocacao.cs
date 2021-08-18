using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    public class ConfiguracaoLocacao: IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro de Locação"; }
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
                Adicionar = "Adicionar uma nova Locação",
                Editar = "Atualizar uma Locação existente",
                Excluir = "Excluir uma Locação existente"
            };
        }
    }
}
