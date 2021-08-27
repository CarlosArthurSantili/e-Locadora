using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.WindowsApp.Features.CuponsModule
{
    public class ConfiguracaoCuponsToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro Cupons"; }
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
                Adicionar = "Adicionar uma Cupom",
                Editar = "Atualizar um Cupom",
                Excluir = "Excluir um Cupom",
                Agrupar = "Agrupar Cupons",
                Desagrupar = "Desagrupar Cupons"
            };
        }
    }
}
