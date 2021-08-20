using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.Dominio.FuncionarioModule;
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
        
        public DateTime dataLocacao { get; set; }
        public DateTime dataDevolucao { get; set; }
        public double quilometragemDevolucao { get; set; }
        public string plano { get; set; }
        public double seguroCliente { get; set; }
        public double seguroTerceiro { get; set; }
        public Funcionario funcionario { get; set; }
        public GrupoVeiculo grupoVeiculo { get; set; }
        public Veiculo veiculo { get; set; }
        public Clientes cliente { get; set; }
        public Condutor condutor { get; set; }

        //public List<TaxasServicos> taxasServicos { get; set; }

        public bool emAberto { get; set; }


        public Locacao(Funcionario funcionario, DateTime dataLocacao, DateTime dataDevolucao, double quilometragemDevolucao, string plano, double seguroCliente, double seguroTerceiro, GrupoVeiculo grupoVeiculo, Veiculo veiculo, Clientes cliente, Condutor condutor, bool emAberto)
        {
            this.funcionario = funcionario;
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
            this.quilometragemDevolucao = quilometragemDevolucao;
            this.plano = plano;
            this.seguroCliente = seguroCliente;
            this.seguroTerceiro = seguroTerceiro;
            this.grupoVeiculo = grupoVeiculo;
            this.veiculo = veiculo;
            this.cliente = cliente;
            this.condutor = condutor;
            this.emAberto = emAberto;
        }

        public double CalcularValorLocacao()
        {
            double valorTotal = 0;
            switch (plano)
            {
                case "Diário": 
                    {
                        double qtdDias = (dataDevolucao - dataLocacao).TotalDays;
                        double kmUsados = quilometragemDevolucao - veiculo.Quilometragem;
                        valorTotal = (grupoVeiculo.planoDiarioValorDiario * qtdDias) + (grupoVeiculo.planoDiarioValorKm * kmUsados);
                        
                        break; 
                    }
                case "Controlado": //Pedir detalhes sobre cálculo desse plano no caso "kmUsados > qtdKmEsperado"
                    { 
                        double qtdDias = (dataDevolucao - dataLocacao).TotalDays;
                        double kmUsados = quilometragemDevolucao - veiculo.Quilometragem;
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
                        double qtdDias = (dataDevolucao - dataLocacao).TotalDays;
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

        public void AdicionarTaxasServicos(TaxasServicos taxaServico)
        {
            //taxasServicos.Add(taxaServico);
        }

        public void RemoverTaxasServicos(TaxasServicos taxaServico)
        {
            //taxasServicos.Remove(taxaServico);
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
                && funcionario.Equals(other.funcionario)
                && dataLocacao == other.dataLocacao
                && dataDevolucao == other.dataDevolucao
                && quilometragemDevolucao == other.quilometragemDevolucao
                && plano == other.plano
                && grupoVeiculo.Equals(grupoVeiculo)
                && veiculo.Equals(veiculo)
                && cliente.Equals(other.cliente)
                && condutor.Equals(other.condutor)
                && emAberto == other.emAberto;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
