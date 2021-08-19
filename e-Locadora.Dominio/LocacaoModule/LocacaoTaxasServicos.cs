using e_Locadora.Dominio.TaxasServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.LocacaoModule
{
    public class LocacaoTaxasServicos
    {
        public Locacao locacao { get; set; }
        public TaxasServicos taxasServicos { get; set; }

        public LocacaoTaxasServicos(Locacao locacao, TaxasServicos taxasServicos) 
        {
            this.locacao = locacao;
            this.taxasServicos = taxasServicos;
        }
    }
}
