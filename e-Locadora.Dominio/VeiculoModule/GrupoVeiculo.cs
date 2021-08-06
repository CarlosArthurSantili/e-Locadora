using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio
{
    public class GrupoVeiculo : EntidadeBase
    {

        public string categoria { get; set; }

        public double planoDiarioValorKm { get; set; }
        public double planoDiarioValorDiario { get; set; }

        public double planoKmControladoValorKm { get; set; }
        public double planoKmControladoValorDiario { get; set; }

        public double planoKmLivreValorDiario { get; set; }



        public GrupoVeiculo(string categoria, double planoDiarioValorKm, double planoDiarioValorDiario, double planoKmControladoValorKm, double planoKmControladoValorDiario, double planoKmLivreValorDiario)
        {
            this.categoria = categoria;
            this.planoDiarioValorKm = planoDiarioValorKm;
            this.planoDiarioValorDiario = planoDiarioValorDiario;
            this.planoKmControladoValorKm = planoKmControladoValorKm;
            this.planoKmControladoValorDiario = planoKmControladoValorDiario;
            this.planoKmLivreValorDiario = planoKmLivreValorDiario;
        }

        public override string Validar() {
            string resultadoValidacao = "";
            if (string.IsNullOrEmpty(categoria))
                resultadoValidacao = "O atributo categoria é obrigatório e não pode ser vazio.";
            if (planoDiarioValorKm <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo planoDiarioValorKm deve ser maior que zero.";
            if (planoDiarioValorDiario <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo planoDiarioValorDiario deve ser maior que zero.";
            if (planoKmControladoValorKm <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo planoKmControladoValorKm deve ser maior que zero.";
            if (planoKmControladoValorKm <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo planoKmControladoValorDiario deve ser maior que zero.";
            if (planoKmLivreValorDiario <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo planoKmLivreValorDiario deve ser maior que zero.";

            
            return resultadoValidacao;
        }
    }
}
