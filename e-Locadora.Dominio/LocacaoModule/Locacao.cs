using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.Dominio.Shared;
using e_Locadora.Dominio.TaxasServicosModule;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        
        public DateTime dataInicial { get; set; }
        public DateTime dataFinal { get; set; }
        public double quilometragemFinal { get; set; }
        public string plano { get; set; }
        public string funcionario { get; set; }
        public GrupoVeiculo grupoVeiculo { get; set; }
        public Veiculo veiculo { get; set; }
        public Clientes cliente { get; set; }
        public Condutor condutor { get; set; }

        public List<TaxasServicos> taxasServicos { get; set; }

        public double valorTotal { get; set; }

        public bool emAberto { get; set; }


        public Locacao(string funcionario, DateTime dataInicial, DateTime dataFinal, string plano, GrupoVeiculo grupoVeiculo, Veiculo veiculo, Clientes cliente, Condutor condutor, List<TaxasServicos> taxasServicos, bool emAberto)
        {
            this.funcionario = funcionario;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.quilometragemFinal = quilometragemFinal;
            this.plano = plano;
            this.grupoVeiculo = grupoVeiculo;
            this.veiculo = veiculo;
            this.cliente = cliente;
            this.condutor = condutor;
            this.taxasServicos = taxasServicos;
            this.emAberto = emAberto;
        }

        public double CalcularValorLocacao()
        {
            switch (plano)
            {
                case "Diário": 
                    {
                        double qtdDias = (dataFinal - dataInicial).TotalDays;
                        double kmUsados = quilometragemFinal - veiculo.Quilometragem;
                        valorTotal = (grupoVeiculo.planoDiarioValorDiario * qtdDias) + (grupoVeiculo.planoDiarioValorKm * kmUsados);
                        
                        break; 
                    }
                case "Controlado": //Pedir detalhes sobre cálculo desse plano no caso "kmUsados > qtdKmEsperado"
                    { 
                        double qtdDias = (dataFinal - dataInicial).TotalDays;
                        double kmUsados = quilometragemFinal - veiculo.Quilometragem;
                        if (kmUsados > grupoVeiculo.planoKmControladoQuantidadeKm)
                        {
                            valorTotal = (grupoVeiculo.planoKmControladoValorDiario * qtdDias) + (grupoVeiculo.planoKmControladoValorKm * grupoVeiculo.planoKmControladoValorKm) + (grupoVeiculo.planoKmControladoValorKm * (kmUsados - grupoVeiculo.planoKmControladoQuantidadeKm) * 2);
                        }
                        else
                        {
                            valorTotal = (grupoVeiculo.planoKmControladoValorDiario * qtdDias) + (grupoVeiculo.planoKmControladoValorKm * kmUsados);
                        }
                        break; 
                    }
                case "Livre": 
                    {
                        double qtdDias = (dataFinal - dataInicial).TotalDays;
                        valorTotal = grupoVeiculo.planoKmLivreValorDiario * qtdDias;

                        break; 
                    }

                default: { break; }
            }

            return valorTotal;
        }

        public void FinalizarLocacao() {
            emAberto = false;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Locacao);
        }

        public bool Equals(Locacao other)
        {
            return other != null
                && Id == other.Id
                && funcionario == other.funcionario
                && plano == other.plano
                && grupoVeiculo == other.grupoVeiculo
                && veiculo == other.veiculo
                && cliente == other.cliente
                && condutor == other.condutor
                && taxasServicos == other.taxasServicos;
        }

        public override string ToString()
        {
            return "Funcionario: "+funcionario+"\nCliente: "+cliente+"\n Veículo: "+veiculo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
