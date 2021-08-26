using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.CupomModule
{
    public class Cupons : EntidadeBase
    {
        public string Nome;

        public int ValorPercentual;

        public double ValorFixo;


        public Cupons(string nome, int valorPercentual, double valorFixo)
        {
            Nome = nome;
            ValorPercentual = valorPercentual;
            ValorFixo = valorFixo;
        }

        public override bool Equals(object obj)
        {
            return obj is Cupons cupons &&
                   Nome == cupons.Nome &&
                   ValorPercentual == cupons.ValorPercentual &&
                   ValorFixo == cupons.ValorFixo;
        }

        public override int GetHashCode()
        {
            int hashCode = 918716981;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + ValorPercentual.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorFixo.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
           return Nome;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "O campo nome é obrigatório e não pode ser vazio.";

            if (ValorPercentual < 0)
                resultadoValidacao += "Valor Percentual não pode ser menor que Zero.";

            if (ValorFixo < 0)
                resultadoValidacao += "Valor Fixo não pode ser Menor que Zero.";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;

        }
    }
}
