using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.CondutoresModule
{
    public class Condutor : EntidadeBase
    {
        public string Nome { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public string Rg { get; }
        public string Cpf { get; }
        public string NumeroCNH { get; }
        public DateTime ValidadeCNH { get; }
        public Clientes Cliente { get; }

        public Condutor(string nome, string endereco, string telefone, string rg, string cpf, 
            string numeroCNH, DateTime validadeCNH, Clientes cliente)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Rg = rg;
            Cpf = cpf;
            NumeroCNH = numeroCNH;
            ValidadeCNH = validadeCNH;
            Cliente = cliente;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
