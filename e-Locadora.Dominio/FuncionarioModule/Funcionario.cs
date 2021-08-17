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
        public DateTime DataAdmissao { get; }
        public double Salario { get; }

        public Funcionario(string nome, string usuario, string senha, DateTime dataAdmissao, double salario)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            DataAdmissao = dataAdmissao;
            Salario = salario;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O atributo nome é obrigatório e não pode ser vazio.";

            if (string.IsNullOrEmpty(Usuario))
                resultadoValidacao = "O atributo usuário é obrigatório e não pode ser vazio.";

            if (string.IsNullOrEmpty(Senha))
                resultadoValidacao = "O atributo senha é obrigatório e não pode ser vazio.";

            if(DataAdmissao < DateTime.Now)
                resultadoValidacao = "A data de admissão do funcionário não pode ser menor que a Data atual.";

            if(Salario <= 0)
                resultadoValidacao = "O atributo salário é obrigatório e não pode ser vazio.";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
