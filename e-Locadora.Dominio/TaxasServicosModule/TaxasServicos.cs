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
        public double TaxaFixa { get; }
        public double TaxaDiaria { get; }

        public TaxasServicos(string descricao, double taxaFixa, double taxaDiaria)
        {
            Descricao = descricao;
            TaxaFixa = taxaFixa;
            TaxaDiaria = taxaDiaria;    
        }
        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Descricao))
                resultadoValidacao = "O campo descrição é obrigatório e não pode ser vazio.";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is TaxasServicos servicos &&
                   Descricao == servicos.Descricao &&
                   TaxaFixa == servicos.TaxaFixa &&
                   TaxaDiaria == servicos.TaxaDiaria;
        }

        public override int GetHashCode()
        {
            int hashCode = -44572661;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + EqualityComparer<double>.Default.GetHashCode(TaxaFixa);
            hashCode = hashCode * -1521134295 + EqualityComparer<double>.Default.GetHashCode(TaxaDiaria);
            return hashCode;
        }
    }
}
