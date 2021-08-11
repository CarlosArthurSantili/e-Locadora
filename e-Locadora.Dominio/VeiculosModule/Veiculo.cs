using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace e_Locadora.Dominio.VeiculosModule
{
    public class Veiculo : EntidadeBase
    {
        public Veiculo(string placa,string fabricante,int qtdlitros,int qtdPortas, string chassi,string cor,
            int passageiros,int ano,string portamalas, string combustivel,GrupoVeiculo grupo, byte[] imagem)
        {
            Placa = placa;
            Fabricante = fabricante;
            QtdLitrosTanque = qtdlitros;
            QtdPortas = qtdPortas;
            NumeroChassi = chassi;
            Cor = cor;
            CapacidadeOcupantes = passageiros;
            AnoFabricacao = ano;
            TamanhoPortaMalas = portamalas;
            Combustivel = combustivel;
            GrupoVeiculo = grupo;
            Imagem = imagem;
        }
        public Veiculo(string placa, string fabricante, int qtdlitros, int qtdPortas, string chassi, string cor,
            int passageiros, int ano, string portamalas, string combustivel, GrupoVeiculo grupo)
        {
            Placa = placa;
            Fabricante = fabricante;
            QtdLitrosTanque = qtdlitros;
            QtdPortas = qtdPortas;
            NumeroChassi = chassi;
            Cor = cor;
            CapacidadeOcupantes = passageiros;
            AnoFabricacao = ano;
            TamanhoPortaMalas = portamalas;
            Combustivel = combustivel;
            GrupoVeiculo = grupo;
        }

        public string Placa { get; }
        public string Fabricante { get; }
        public int QtdLitrosTanque { get; }
        public int QtdPortas { get; }
        public string NumeroChassi { get; }
        public string Cor { get; }
        public int CapacidadeOcupantes { get; }
        public int AnoFabricacao { get; }
        public string TamanhoPortaMalas { get; }
        public string Combustivel { get; }
        public GrupoVeiculo GrupoVeiculo { get; }

        public byte[] Imagem { get; }

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

            if (string.IsNullOrEmpty(TamanhoPortaMalas.ToString()))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Tamanho do Porta Malas é obrigatório";

            if (string.IsNullOrEmpty(Combustivel.ToString()))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Tipo de combustivel é obrigatório";

            if (string.IsNullOrEmpty(GrupoVeiculo.ToString()))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Grupo de Veiculo é obrigatório";

            if (Imagem.Length == 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Imagem é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
