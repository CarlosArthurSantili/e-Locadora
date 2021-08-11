using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.WindowsApp.ClientesModule
{
    public class ConfiguracaoClientesToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro 
        {
            get { return "Cadastro de Clientes"; }
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
                Adicionar = "Adicionar um novo Cliente",
                Editar = "Atualizar um Cliente existente",
                Excluir = "Excluir um Cliente existente",
                Agrupar = "Agrupar Clientes",
                Desagrupar = "Desagrupar Clientes"
            };
        }
    }
}
