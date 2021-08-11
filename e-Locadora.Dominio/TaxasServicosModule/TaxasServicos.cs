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

        public TaxasServicos(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Descricao))
                resultadoValidacao = "O campo descrição é obrigatório e não pode ser vazio.";

            if (Valor <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Valor nao pode Ser Nullo";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is TaxasServicos servicos &&
                   Descricao == servicos.Descricao &&
                   Valor == servicos.Valor;
        }

        public override int GetHashCode()
        {
            int hashCode = -44572661;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }
    }
}
