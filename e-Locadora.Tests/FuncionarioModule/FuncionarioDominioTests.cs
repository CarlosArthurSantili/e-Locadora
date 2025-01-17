﻿using e_Locadora.Dominio.FuncionarioModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.FuncionarioModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class FuncionarioDominioTests
    {
        [TestMethod]
        public void Deve_Validar_Funcionario()
        {
            Funcionario funcionario = new Funcionario("Rodrigo Constantino","10140440499", "rodconsta", "consta123", new DateTime(2021, 08, 17), 1752.48);

            var validar = funcionario.Validar();

            validar.Should().Be("ESTA_VALIDO");

        }
        [TestMethod]
        public void Deve_Validar_Informacoes()
        {
            Funcionario funcionario = new Funcionario("", "","", "", new DateTime(2022,08,17), 0);

            var validar = funcionario.Validar();

            var resultadoEsperado =
                "O atributo nome é obrigatório e não pode ser vazio."
                + Environment.NewLine
               + "O CPF digitado está inválido. Tente Novamente."
               + Environment.NewLine
               + "O atributo usuário é obrigatório e não pode ser vazio."
               + Environment.NewLine
               + "O atributo senha é obrigatório e não pode ser vazio."
               + Environment.NewLine
               + "A data de admissão do funcionário não pode ser maior que a Data atual."
               + Environment.NewLine
               + "O atributo salário é obrigatório e não pode ser vazio.";


            validar.Should().Be(resultadoEsperado);

        }

    }
}
