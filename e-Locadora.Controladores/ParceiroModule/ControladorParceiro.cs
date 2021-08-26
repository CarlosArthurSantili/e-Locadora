using e_Locadora.Controladores.Shared;
using e_Locadora.Dominio.ParceirosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.ParceiroModule
{
    public class ControladorParceiro : Controlador<Parceiro>
    {

        public override string InserirNovo(Parceiro registro)
        {
            throw new NotImplementedException();
        }
        public override string Editar(int id, Parceiro registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }


        public override Parceiro SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Parceiro> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
