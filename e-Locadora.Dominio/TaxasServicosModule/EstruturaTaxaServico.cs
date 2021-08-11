using e_Locadora.Dominio.TaxasServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.VeiculosModule
{
    public struct EstruturaTaxaServico
    {
        public TaxaServicoEnum taxaServico;

        public EstruturaTaxaServico(TaxaServicoEnum taxaServico)
        {
            this.taxaServico = taxaServico;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
