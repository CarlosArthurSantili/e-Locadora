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
            throw new NotImplementedException();
        }
    }
}
