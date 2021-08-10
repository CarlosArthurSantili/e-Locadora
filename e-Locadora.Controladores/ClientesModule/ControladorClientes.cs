using e_Locadora.Controladores.Shared;
using e_Locadora.Dominio.ClientesModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.ClientesModule
{
    public class ControladorClientes : Controlador<Clientes>
    {
        public override string InserirNovo(Clientes registro)
        {
            throw new NotImplementedException();
        }
        public override string Editar(int id, Clientes registro)
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

        public override Clientes SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Clientes> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
