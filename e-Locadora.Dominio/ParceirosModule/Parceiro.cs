using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.ParceirosModule
{
    public class Parceiro : EntidadeBase
    {
        public string parceiro { get; }

        public Parceiro(string parceiro)
        {
            this.parceiro = parceiro;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if(string.IsNullOrEmpty(parceiro))
                resultadoValidacao = "O Nome do Parceiro é obrigatório .";
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
