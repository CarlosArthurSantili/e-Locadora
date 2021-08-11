using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.VeiculosModule
{
    public class Veiculo : EntidadeBase
    {
        public Veiculo(string placa, string fabricante, int qtdLitrosTanque, int qtdPortas, string chassi, string cor,
            int capacidadeOcupantes, int ano, string tamanhoPortaMalas, string combustivel, GrupoVeiculo grupoVeiculo)
        {
            Placa = placa;
            Fabricante = fabricante;
            QtdLitrosTanque = qtdLitrosTanque;
            QtdPortas = qtdPortas;
            NumeroChassi = chassi;
            Cor = cor;
            CapacidadeOcupantes = capacidadeOcupantes;
            AnoFabricacao = ano;
            TamanhoPortaMalas = tamanhoPortaMalas;
            Combustivel = combustivel;
            GrupoVeiculo = grupoVeiculo;
        }

        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public int QtdLitrosTanque { get; set; }
        public int QtdPortas { get; set; }
        public string NumeroChassi { get; set; }
        public string Cor { get; set; }
        public int CapacidadeOcupantes { get; set; }
        public int AnoFabricacao { get; set; }
        public string TamanhoPortaMalas { get; set; }
        public string Combustivel { get; set; }
        public GrupoVeiculo GrupoVeiculo { get; set; }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Placa))
                resultadoValidacao = "O campo Placa é obrigatório";

            if (string.IsNullOrEmpty(Fabricante))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Fabricante é obrigatório";

            if (QtdLitrosTanque <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Quantidade De Litros do Tanque de Combustivel é obrigatório";

            if (string.IsNullOrEmpty(NumeroChassi))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Numero do Chassi é obrigatório";

            if (string.IsNullOrEmpty(Cor))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Cor do Veiculo é obrigatório";

            if (CapacidadeOcupantes < 2 || CapacidadeOcupantes > 7)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)";

            if (AnoFabricacao <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Ano de Fabricação do Veiculo nao pode Ser Nullo";

            if (string.IsNullOrEmpty(TamanhoPortaMalas))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Tamanho do Porta Malas é obrigatório";

            if (string.IsNullOrEmpty(Combustivel))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O Campo Tipo de combustivel é obrigatório";

            if (string.IsNullOrEmpty(GrupoVeiculo.ToString()))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O Campo Grupo de Veiculo é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
