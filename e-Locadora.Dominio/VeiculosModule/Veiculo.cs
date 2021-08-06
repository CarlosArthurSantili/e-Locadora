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
        public Veiculo(string placa,string fabricante,string qtdlitros,string chassi,string cor,
            int passageiros,int ano,int portamalas, CombustivelEnum combustivel)
        {
            Placa = placa;
            Fabricante = fabricante;
            QtdLitrosTanque = qtdlitros;
            NumeroChassi = chassi;
            Cor = cor;
            CapacidadeOcupantes = passageiros;
            AnoFabricacao = ano;
            TamanhoPortaMalas = portamalas;
            Combustivel = new Combustivel(combustivel);
        }

        public string Placa { get; }
        public string Fabricante { get; }
        public string QtdLitrosTanque { get; }
        public string NumeroChassi { get; }
        public string Cor { get; }
        public int CapacidadeOcupantes { get; }
        public int AnoFabricacao { get; }
        public int TamanhoPortaMalas { get; }
        public Combustivel Combustivel { get; }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Placa))
                resultadoValidacao = "O campo Placa é obrigatório";

            if (string.IsNullOrEmpty(Fabricante))
                resultadoValidacao = "O campo Fabricante é obrigatório";

            if (string.IsNullOrEmpty(QtdLitrosTanque))
                resultadoValidacao = "O campo Quantidade De Litros do Tanque de Combustivel é obrigatório";

            if (string.IsNullOrEmpty(NumeroChassi))
                resultadoValidacao = "O campo Numero do Chassi é obrigatório";

            if (string.IsNullOrEmpty(Cor))
                resultadoValidacao = "O campo Cor do Veiculo é obrigatório";

            if (CapacidadeOcupantes < 2 && CapacidadeOcupantes > 7)
                resultadoValidacao = "O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)";

            if (AnoFabricacao <= 0)
                resultadoValidacao = "O campo Ano de Fabricação do Veiculo nao pode Ser Nullo";

            if (TamanhoPortaMalas <= 0)
                resultadoValidacao = "O campo Tamanho do Porta Malas é Obrigatorio ";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
