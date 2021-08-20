using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.FuncionarioModule;
using e_Locadora.Controladores.Shared;
using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.Dominio.FuncionarioModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.Dominio.TaxasServicosModule;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.LocacaoModule
{
    public class ControladorLocacao : Controlador<Locacao>
    {
        ControladorFuncionario controladorFuncionario = new ControladorFuncionario();
        ControladorClientes controladorCliente = new ControladorClientes();
        ControladorCondutor controladorCondutor = new ControladorCondutor();
        ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
        ControladorVeiculos controladorVeiculo = new ControladorVeiculos();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

        #region Queries Locacao
        private const string sqlInserirLocacao =
         @"INSERT INTO TBLOCACAO
	                (
		                [IDFUNCIONARIO], 
		                [IDCLIENTE], 
		                [IDCONDUTOR],
                        [IDGRUPOVEICULO], 
                        [IDVEICULO], 
		                [EMABERTO],
                        [DATALOCACAO],
                        [DATADEVOLUCAO],
                        [QUILOMETRAGEMDEVOLUCAO],
                        [PLANO],
                        [SEGUROCLIENTE],
                        [SEGUROTERCEIRO],
                        [VALORTOTAL]
	                ) 
	                VALUES
	                (
		                @IDFUNCIONARIO, 
		                @IDCLIENTE, 
		                @IDCONDUTOR,
                        @IDGRUPOVEICULO, 
                        @IDVEICULO, 
		                @EMABERTO,
                        @DATALOCACAO,
                        @DATADEVOLUCAO,
                        @QUILOMETRAGEMDEVOLUCAO,
                        @PLANO,
                        @SEGUROCLIENTE,
                        @SEGUROTERCEIRO,
                        @VALORTOTAL
	                )";

        private const string sqlEditarLocacao =
                    @"UPDATE TBLOCACAO
                    SET
		                [IDFUNCIONARIO] = @IDFUNCIONARIO, 
		                [IDCLIENTE] = @IDCLIENTE, 
		                [IDCONDUTOR] = @IDCONDUTOR,
                        [IDGRUPOVEICULO] = @IDGRUPOVEICULO, 
                        [IDVEICULO] = @IDVEICULO, 
		                [EMABERTO] = @EMABERTO,
                        [DATALOCACAO] = @DATALOCACAO,
                        [DATADEVOLUCAO] = @DATADEVOLUCAO,
                        [QUILOMETRAGEMDEVOLUCAO] = @QUILOMETRAGEMDEVOLUCAO,
                        [PLANO] = @PLANO,
                        [SEGUROCLIENTE] = @SEGUROCLIENTE,
                        [SEGUROTERCEIRO] = @SEGUROTERCEIRO,
                        [VALORTOTAL] = @VALORTOTAL
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirLocacao =
         @"DELETE 
	              FROM
                        TBLOCACAO
                    WHERE 
                        ID = @ID";

        private const string sqlExisteLocacao =
        @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarLocacaoPorId =
            @"SELECT 
                [ID],
		        [IDFUNCIONARIO], 
		        [IDCLIENTE], 
		        [IDCONDUTOR],
                [IDGRUPOVEICULO], 
                [IDVEICULO], 
		        [EMABERTO],
                [DATALOCACAO],
                [DATADEVOLUCAO],
                [QUILOMETRAGEMDEVOLUCAO],
                [PLANO],
                [SEGUROCLIENTE],
                [SEGUROTERCEIRO],
                [VALORTOTAL]
            FROM
                [TBLOCACAO]
            WHERE
                [ID] = @ID";

        private const string sqlSelecionarTodasLocacoes =
            @"SELECT 
                [ID],
		        [IDFUNCIONARIO], 
		        [IDCLIENTE], 
		        [IDCONDUTOR],
                [IDGRUPOVEICULO], 
                [IDVEICULO], 
		        [EMABERTO],
                [DATALOCACAO],
                [DATADEVOLUCAO],
                [QUILOMETRAGEMDEVOLUCAO],
                [PLANO],
                [SEGUROCLIENTE],
                [SEGUROTERCEIRO],
                [VALORTOTAL]
            FROM
                [TBLOCACAO]";
        private const string sqlSelecionarLocacoesPendentes =
            @"SELECT 
                [ID],
		        [IDFUNCIONARIO], 
		        [IDCLIENTE], 
		        [IDCONDUTOR],
                [IDGRUPOVEICULO], 
                [IDVEICULO], 
		        [EMABERTO],
                [DATALOCACAO],
                [DATADEVOLUCAO],
                [QUILOMETRAGEMDEVOLUCAO],
                [PLANO],
                [SEGUROCLIENTE],
                [SEGUROTERCEIRO],
                [VALORTOTAL]
            FROM
                [TBLOCACAO]
           WHERE 
                [EMABERTO] == @EMABERTO";


        #endregion


        #region Queries LocacaoTaxaServico
        private const string sqlInserirLocacaoTaxasServicos =
         @"INSERT INTO TBLOCACAO_TBTAXASSERVICOS
	                (
		                [IDLOCACAO], 
		                [IDTAXASSERVICOS]
	                ) 
	                VALUES
	                (
		                @IDLOCACAO, 
		                @IDTAXASSERVICOS
	                )";

        private const string sqlEditarLocacaoTaxasServicos =
                    @"UPDATE TBLOCACAO_TBTAXASSERVICOS
                    SET
		                [IDLOCACAO] = @IDLOCACAO, 
		                [IDTAXASSERVICOS] = @IDTAXASSERVICOS
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirLocacaoTaxasServicos =
         @"DELETE 
	              FROM
                        TBLOCACAO_TBTAXASSERVICOS
                    WHERE 
                        IDLOCACAO = @IDLOCACAO AND IDTAXASSERVICOS = @IDTAXASSERVICOS";

        private const string sqlExisteLocacaoTaxasServicos =
        @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO_TBTAXASSERVICOS]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarLocacaoTaxasServicosPorId =
            @"SELECT 
                [ID],
		        [IDLOCACAO], 
		        [IDTAXASSERVICOS]
            FROM
                [TBLOCACAO_TBTAXASSERVICOS]
            WHERE
                [ID] = @ID";

        private const string sqlSelecionarTodasLocacoesTaxasServicos =
            @"SELECT 
                [ID],
		        [IDLOCACAO], 
		        [IDTAXASSERVICOS]
            FROM
                [TBLOCACAO_TBTAXASSERVICOS]";


        #endregion


        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacaoDominio = registro.Validar();
            string resultadoValidacaoControlador = ValidarLocacao(registro);

            if (resultadoValidacaoDominio == "ESTA_VALIDO" && resultadoValidacaoControlador == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirLocacao, ObtemParametrosLocacao(registro));
                if (!registro.taxasServicos.IsNullOrEmpty())
                    foreach (TaxasServicos taxaServico in registro.taxasServicos)
                    {
                        LocacaoTaxasServicos locacao_TaxaServico = new LocacaoTaxasServicos(registro, taxaServico);
                        Db.Insert(sqlInserirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(locacao_TaxaServico));
                    }
                    
            }

            if (resultadoValidacaoDominio != "ESTA_VALIDO")
                return resultadoValidacaoDominio;
            else
                return resultadoValidacaoControlador;
        }

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacaoDominio = registro.Validar();
            string resultadoValidacaoControlador = ValidarLocacao(registro, id);

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacao, ObtemParametrosLocacao(registro));


                //deletando todas taxas relacionadas
                if (!registro.taxasServicos.IsNullOrEmpty()) {
                    foreach (TaxasServicos taxaServico in registro.taxasServicos)
                    {
                        LocacaoTaxasServicos locacao_TaxaServico = new LocacaoTaxasServicos(registro, taxaServico);
                        Db.Delete(sqlExcluirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(locacao_TaxaServico));
                    }

                    //inserindo novas taxas relacionadas
                    foreach (TaxasServicos taxaServico in registro.taxasServicos)
                    {
                        LocacaoTaxasServicos locacao_TaxaServico = new LocacaoTaxasServicos(registro, taxaServico);
                        Db.Insert(sqlInserirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(locacao_TaxaServico));
                    }
                }
                
            }

            if(resultadoValidacaoDominio != "ESTA_VALIDO")
                return resultadoValidacaoDominio;
            else
                return resultadoValidacaoControlador;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Locacao locacaoExcluida = SelecionarPorId(id);
                Db.Delete(sqlExcluirLocacao, AdicionarParametro("ID", id));
                if (!locacaoExcluida.IsNullOrEmpty())
                {
                    if (!locacaoExcluida.taxasServicos.IsNullOrEmpty())
                        foreach (TaxasServicos taxaServico in locacaoExcluida.taxasServicos)
                        {
                            LocacaoTaxasServicos locacao_TaxaServico = new LocacaoTaxasServicos(locacaoExcluida, taxaServico);
                            Db.Delete(sqlExcluirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(locacao_TaxaServico));
                        }
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteLocacao, AdicionarParametro("ID", id));
        }

        public override Locacao SelecionarPorId(int id)
        {
            Locacao locacaoSelecionada = Db.Get(sqlSelecionarLocacaoPorId, ConverterEmLocacao, AdicionarParametro("ID", id));
            
            if (!locacaoSelecionada.IsNullOrEmpty())
            {
                List<TaxasServicos> taxasServicosIndividuais = SelecionarTaxasServicosPorLocacaoId(locacaoSelecionada.Id);
                locacaoSelecionada.taxasServicos = taxasServicosIndividuais;
            }
            
            return locacaoSelecionada;
        }

        public override List<Locacao> SelecionarTodos()
        {
            List<Locacao> todasLocacoes = new List<Locacao>();
            todasLocacoes = Db.GetAll(sqlSelecionarTodasLocacoes, ConverterEmLocacao);
            
            foreach (Locacao locacaoIndividual in todasLocacoes)
            {
                List<TaxasServicos> taxasServicosIndividuais = SelecionarTaxasServicosPorLocacaoId(locacaoIndividual.Id);
                locacaoIndividual.taxasServicos = taxasServicosIndividuais;
            }

            return todasLocacoes;
        }

        public List<Locacao> SelecionarLocacoesPendentes(bool emAberto)
        {
            List<Locacao> locacoesPendentes = new List<Locacao>();
            locacoesPendentes = Db.GetAll(sqlSelecionarLocacoesPendentes, ConverterEmLocacao, AdicionarParametro("EMABERTO", emAberto));
            foreach (Locacao locacaoIndividual in locacoesPendentes)
            {
                List<TaxasServicos> taxasServicosIndividuais = SelecionarTaxasServicosPorLocacaoId(locacaoIndividual.Id);
                locacaoIndividual.taxasServicos = taxasServicosIndividuais;
            }

            return locacoesPendentes;
        }

        public string ValidarLocacao(Locacao novoLocacao, int id = 0)
        {
            //validar carros alugados
            if (novoLocacao != null)
            {
                if (id != 0)
                {//situação de editar
                    int countVeiculoIndisponivel = 0;
                    List<Locacao> todasLocacoes = SelecionarTodos();
                    foreach (Locacao locacao in todasLocacoes)
                    {
                        if (novoLocacao.veiculo.Id == locacao.veiculo.Id && locacao.emAberto == true && locacao.Id != id)
                            countVeiculoIndisponivel++;
                    }
                    if (countVeiculoIndisponivel > 0)
                        return "Veiculo já alugado, tente novamente.";
                }
                else
                {//situação de inserir
                    int countVeiculoIndisponivel = 0;
                    List<Locacao> todosLocacaos = SelecionarTodos();
                    foreach (Locacao locacao in todosLocacaos)
                    {
                        if (novoLocacao.veiculo.Id == locacao.veiculo.Id && locacao.emAberto == true)
                            countVeiculoIndisponivel++;
                    }
                    if (countVeiculoIndisponivel > 0)
                        return "Veiculo já alugado, tente novamente.";
                }
            }
            return "ESTA_VALIDO";
        }

        private Dictionary<string, object> ObtemParametrosLocacao(Locacao locacao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacao.Id);
            parametros.Add("IDFUNCIONARIO", locacao.funcionario.Id);
            parametros.Add("IDCLIENTE", locacao.cliente.Id);
            parametros.Add("IDCONDUTOR", locacao.condutor.Id);
            parametros.Add("IDGRUPOVEICULO", locacao.grupoVeiculo.Id);
            parametros.Add("IDVEICULO", locacao.veiculo.Id);
            parametros.Add("EMABERTO", locacao.emAberto);
            parametros.Add("DATALOCACAO", locacao.dataLocacao);
            parametros.Add("DATADEVOLUCAO", locacao.dataDevolucao);
            parametros.Add("QUILOMETRAGEMDEVOLUCAO", locacao.quilometragemDevolucao);
            parametros.Add("PLANO", locacao.plano);
            parametros.Add("SEGUROCLIENTE", locacao.seguroCliente);
            parametros.Add("SEGUROTERCEIRO", locacao.seguroTerceiro);
            parametros.Add("VALORTOTAL", locacao.CalcularValorLocacao());

            return parametros;
        }

        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var idFuncionario = Convert.ToInt32(reader["IDFUNCIONARIO"]);
            Funcionario funcionario = controladorFuncionario.SelecionarPorId(idFuncionario);

            var idCliente = Convert.ToInt32(reader["IDCLIENTE"]);
            Clientes cliente = controladorCliente.SelecionarPorId(idCliente);

            var idCondutor = Convert.ToInt32(reader["IDCONDUTOR"]);
            Condutor condutor = controladorCondutor.SelecionarPorId(idCondutor);

            var idGrupoVeiculo = Convert.ToInt32(reader["IDGRUPOVEICULO"]);
            GrupoVeiculo grupoVeiculo = controladorGrupoVeiculo.SelecionarPorId(idGrupoVeiculo);

            var idVeiculo = Convert.ToInt32(reader["IDVEICULO"]);
            Veiculo veiculo = controladorVeiculo.SelecionarPorId(idVeiculo);

            var emAberto = Convert.ToBoolean(reader["EMABERTO"]);
            var dataLocacao = Convert.ToDateTime(reader["DATALOCACAO"]);
            var dataDevolucao = Convert.ToDateTime(reader["DATADEVOLUCAO"]);
            var quilometragemDevolucao = Convert.ToDouble(reader["QUILOMETRAGEMDEVOLUCAO"]);
            var plano = Convert.ToString(reader["PLANO"]);
            var seguroCliente = Convert.ToDouble(reader["SEGUROCLIENTE"]);
            var seguroTerceiro = Convert.ToDouble(reader["SEGUROTERCEIRO"]);



            Locacao locacao = new Locacao(funcionario, dataLocacao, dataDevolucao, quilometragemDevolucao, plano, seguroCliente, seguroTerceiro, grupoVeiculo, veiculo, cliente, condutor, emAberto);

            locacao.Id = Convert.ToInt32(reader["ID"]);

            return locacao;
        }

        //LocacaoTaxaServico

        private Dictionary<string, object> ObtemParametrosLocacaoTaxasServicos(LocacaoTaxasServicos locacaoTaxasServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacaoTaxasServicos.Id);
            parametros.Add("IDLOCACAO", locacaoTaxasServicos.locacao.Id);
            parametros.Add("IDTAXASSERVICOS", locacaoTaxasServicos.taxasServicos.Id);

            return parametros;
        }

        private LocacaoTaxasServicos ConverterEmLocacaoTaxasServicos(IDataReader reader)
        {
            var idLocacao = Convert.ToInt32(reader["IDLOCACAO"]);
            Locacao locacao = SelecionarPorId(idLocacao);

            var idTaxasServicos = Convert.ToInt32(reader["IDTAXASSERVICOS"]);
            TaxasServicos taxasServicos = controladorTaxasServicos.SelecionarPorId(idTaxasServicos);

            LocacaoTaxasServicos locacaoTaxasServicos = new LocacaoTaxasServicos(locacao, taxasServicos);

            locacaoTaxasServicos.Id = Convert.ToInt32(reader["ID"]);

            return locacaoTaxasServicos;
        }

        public List<LocacaoTaxasServicos> SelecionarTodosLocacaoTaxasServicos()
        {
            return Db.GetAll(sqlSelecionarTodasLocacoesTaxasServicos, ConverterEmLocacaoTaxasServicos);
        }

        public List<TaxasServicos> SelecionarTaxasServicosPorLocacaoId(int idLocacao)
        {
            List<TaxasServicos> taxasServicos = new List<TaxasServicos>();
            foreach (LocacaoTaxasServicos Locacao_TaxaServico in SelecionarTodosLocacaoTaxasServicos())
            {
                if (idLocacao == Locacao_TaxaServico.locacao.Id)
                    taxasServicos.Add(Locacao_TaxaServico.taxasServicos);
            }
            return taxasServicos;
        }
    }
}
