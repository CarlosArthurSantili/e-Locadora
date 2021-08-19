using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.FuncionarioModule;
using e_Locadora.Controladores.LocacaoModule;
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

namespace e_Locadora.Controladores.LocacaoTaxasServicosModule
{
    public class ControladorLocacaoTaxasServicos : Controlador<Locacao>
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

        #region Queries
        private const string sqlInserirLocacaoTaxasServicos =
         @"INSERT INTO TBLOCACAO
	                (
                        [ID],
		                [IDLOCACAO], 
		                [IDTAXASSERVICOS]
	                ) 
	                VALUES
	                (
                        @ID,
		                @IDLOCACAO, 
		                @IDTAXASSERVICOS
	                )";

        private const string sqlEditarLocacaoTaxasServicos =
                    @"UPDATE TBLOCACAO
                    SET
                        [ID] = @ID,
		                [IDLOCACAO] = @IDLOCACAO, 
		                [IDTAXASSERVICOS] = @IDTAXASSERVICOS
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirLocacaoTaxasServicos =
         @"DELETE 
	              FROM
                        TBLOCACAO
                    WHERE 
                        ID = @ID";

        private const string sqlExisteLocacaoTaxasServicos =
        @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarLocacaoTaxasServicosPorId =
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
        private const string sqlSelecionarLocacaoTaxasServicosesEmAberto =
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
        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacaoDominio = registro.Validar();
            string resultadoValidacaoControlador = ValidarLocacaoTaxasServicos(registro);

            if (resultadoValidacaoDominio == "ESTA_VALIDO" && resultadoValidacaoControlador == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(registro));
            }

            if (resultadoValidacaoDominio != "ESTA_VALIDO")
                return resultadoValidacaoDominio;
            else
                return resultadoValidacaoControlador;
        }

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacaoDominio = registro.Validar();
            string resultadoValidacaoControlador = ValidarLocacaoTaxasServicos(registro, id);

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(registro));
            }

            if (resultadoValidacaoDominio != "ESTA_VALIDO")
                return resultadoValidacaoDominio;
            else
                return resultadoValidacaoControlador;
        }

        public override bool Excluir(int id)
        {

            try
            {
                Db.Delete(sqlExcluirLocacaoTaxasServicos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteLocacaoTaxasServicos, AdicionarParametro("ID", id));
        }

        public override Locacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarLocacaoTaxasServicosPorId, ConverterEmLocacaoTaxasServicos, AdicionarParametro("ID", id));
        }

        public override List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasLocacoes, ConverterEmLocacaoTaxasServicos);
        }
        public List<Locacao> SelecionarLocacaoTaxasServicosesEmAberto(DateTime data)
        {
            return Db.GetAll(sqlSelecionarLocacaoTaxasServicosesEmAberto, ConverterEmLocacaoTaxasServicos);
        }




        private Dictionary<string, object> ObtemParametrosLocacaoTaxasServicos(LocacaoTaxasServicos locacao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacao.Id);
            parametros.Add("ID_LOCACAO", locacao.funcionario);
            parametros.Add("ID_TAXASSERVICOS", locacao.cliente.Id);

            return parametros;
        }
        private LocacaoTaxasServicos ConverterEmLocacaoTaxasServicos(IDataReader reader)
        {
            var idLocacao = Convert.ToInt32(reader["ID_LOCACAO"]);
            Locacao locacao = controladorLocacao.SelecionarPorId(idLocacao);

            var idTaxasServicos = Convert.ToInt32(reader["ID_TAXASSERVICOS"]);
            TaxasServicos taxasServicos = controladorTaxasServicos.SelecionarPorId(idTaxasServicos);

            LocacaoTaxasServicos locacaoTaxasServicos = new LocacaoTaxasServicos(locacao, taxasServicos);

            locacao.Id = Convert.ToInt32(reader["ID"]);

            return locacao;
        }

        public string ValidarLocacaoTaxasServicos(LocacaoTaxasServicos novoLocacaoTaxasServicos, int id = 0)
        {
            //validar carros alugados
            if (novoLocacaoTaxasServicos != null)
            {
                if (id != 0)
                {//situação de editar
                    int countVeiculoIndisponivel = 0;
                    List<LocacaoTaxasServicos> todasLocacoes = SelecionarTodos();
                    foreach (LocacaoTaxasServicos locacao in todasLocacoes)
                    {
                        if (novoLocacaoTaxasServicos.veiculo.Id == locacao.veiculo.Id && locacao.emAberto == true && locacao.Id != id)
                            countVeiculoIndisponivel++;
                    }
                    if (countVeiculoIndisponivel > 0)
                        return "Veiculo já alugado, tente novamente.";
                }
                else
                {//situação de inserir
                    int countVeiculoIndisponivel = 0;
                    List<LocacaoTaxasServicos> todosLocacaoTaxasServicoss = SelecionarTodos();
                    foreach (LocacaoTaxasServicos locacao in todosLocacaoTaxasServicoss)
                    {
                        if (novoLocacaoTaxasServicos.veiculo.Id == locacao.veiculo.Id && locacao.emAberto == true)
                            countVeiculoIndisponivel++;
                    }
                    if (countVeiculoIndisponivel > 0)
                        return "Veiculo já alugado, tente novamente.";
                }
            }
            return "ESTA_VALIDO";
        }//
    }
}
