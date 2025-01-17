﻿using e_Locadora.Dominio.ParceirosModule;
using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.CupomModule
{
    public class Cupons : EntidadeBase
    {
        public string Nome { get; }

        public int ValorPercentual { get; }

        public double ValorFixo { get; }

        public DateTime DataValidade { get; }

        public Parceiro Parceiro { get; }

        public double ValorMinimo { get; }


        public Cupons(string nome, int valorPercentual, double valorFixo, DateTime dataValidade, Parceiro parceiro, double valorMInimo)
        {
            Nome = nome;
            ValorPercentual = valorPercentual;
            ValorFixo = valorFixo;
            DataValidade = dataValidade;
            Parceiro = parceiro;
            ValorMinimo = valorMInimo;

        }

        public double CalcularDesconto(double valorTotal)
        {
            double valor = 0;

            if (valorTotal <= ValorMinimo)
                valor = 0;

            else if (ValorFixo > 0)
                valor = ValorFixo;

            else if (ValorPercentual > 0)
                valor = (valorTotal / 100) * ValorPercentual;

            return valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cupons);
        }
        public bool Equals(Cupons other)
        {
            return other != null
                && Id == other.Id
                && Nome == other.Nome
                && ValorPercentual == other.ValorPercentual
                && ValorFixo == other.ValorFixo
                && DataValidade == other.DataValidade
                && Parceiro.Equals(other.Parceiro)
                && ValorMinimo == other.ValorMinimo;
        }
        public override int GetHashCode()
        {
            int hashCode = 918716981;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + ValorPercentual.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorFixo.GetHashCode();
            hashCode = hashCode * -1521134295 + DataValidade.GetHashCode();
            hashCode = hashCode * -1521134295 + Parceiro.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorMinimo.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
           return Nome;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "O campo nome é obrigatório e não pode ser vazio.";

            if (ValorPercentual < 0)
                resultadoValidacao += "Valor Percentual não pode ser menor que Zero.";

            if (ValorFixo < 0)
                resultadoValidacao += "Valor Fixo não pode ser Menor que Zero.";

            if(ValorPercentual > 100)
                resultadoValidacao += "Valor Percentual não pode ser maior que Cem.";

            if (DataValidade == DateTime.MinValue || DataValidade == DateTime.MaxValue)
                resultadoValidacao += "A data Invalida, Insira uma data valida";

            if (Parceiro == null)
                resultadoValidacao += "O campo Parceiro é obrigatório e não pode ser vazio.";

            if(ValorMinimo < 0)
                resultadoValidacao += "O campo Valor Minimo não pode ser menor que Zero.";

            if (ValorFixo > ValorMinimo)
                resultadoValidacao += "O valor Minimo não pode ser menor que o valor de Desconto";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;

        }
    }
}
