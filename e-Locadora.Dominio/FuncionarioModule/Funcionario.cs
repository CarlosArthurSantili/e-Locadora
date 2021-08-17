using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.FuncionarioModule
{
    public class Funcionario : EntidadeBase
    {
        public string Nome { get; }
        public string Usuario { get; }
        public string Senha { get; }
        public DateTime DataAdimicao { get; }
        public double Salario { get; }

        public Funcionario(string nome, string usuario, string senha, DateTime dataAdimicao, double salario)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            DataAdimicao = dataAdimicao;
            Salario = salario;
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
