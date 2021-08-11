using e_Locadora.Dominio.Shared;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.TaxasServicosModule
{
    public class TaxasServicos : EntidadeBase
    {
        public string Descricao { get; }
        public double Valor { get; } 
        public EstruturaTaxaServico EstruturaTaxaServico { get; }

        public TaxasServicos(string descricao, double valor, TaxaServicoEnum taxaServico)
        {
            Descricao = descricao;
            Valor = valor;
            EstruturaTaxaServico = new EstruturaTaxaServico(taxaServico);
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Descricao))
                resultadoValidacao = "O atributo descrição é obrigatório e não pode ser vazio.";

            if (Valor <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Valor nao pode Ser Nullo";

            if (string.IsNullOrEmpty(EstruturaTaxaServico.ToString()))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O Campo Taxa de Serviço é obrigatório";

            return resultadoValidacao;
        }
    }
}
