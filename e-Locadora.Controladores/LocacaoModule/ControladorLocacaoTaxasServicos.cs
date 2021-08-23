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
    public class ControladorLocacaoTaxasServicos : Controlador<LocacaoTaxasServicos>
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

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
                        ID = @ID";

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

        private const string sqlSelecionarTodasLocacoes =
            @"SELECT 
                [ID],
		        [IDLOCACAO], 
		        [IDTAXASSERVICOS]
            FROM
                [TBLOCACAO_TBTAXASSERVICOS]";


        #endregion
        public override string InserirNovo(LocacaoTaxasServicos registro)
        {
            string resultadoValidacaoDominio = registro.Validar();

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(registro));
            }

            return resultadoValidacaoDominio;
        }

        public override string Editar(int id, LocacaoTaxasServicos registro)
        {
            string resultadoValidacaoDominio = registro.Validar();

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacaoTaxasServicos, ObtemParametrosLocacaoTaxasServicos(registro));
            }
            
            return resultadoValidacaoDominio;
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

        public bool ExcluirPorIdLocacaoEIdTaxa(int idLocacao, int idTaxaServico)
        {
            List<LocacaoTaxasServicos> todosLocacaoTaxasServicos = SelecionarTodos();
            int quantidadeExclusoes = 0;
            foreach (LocacaoTaxasServicos locacaoTaxa in todosLocacaoTaxasServicos)
            {
                if (locacaoTaxa.locacao.Equals(controladorLocacao.SelecionarPorId(idLocacao))
                    && locacaoTaxa.taxasServicos.Equals(controladorTaxasServicos.SelecionarPorId(idTaxaServico)))
                { 
                    Excluir(locacaoTaxa.Id);
                    quantidadeExclusoes++; 
                }
            }
            return (quantidadeExclusoes > 0);
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteLocacaoTaxasServicos, AdicionarParametro("ID", id));
        }

        public override LocacaoTaxasServicos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarLocacaoTaxasServicosPorId, ConverterEmLocacaoTaxasServicos, AdicionarParametro("ID", id));
        }

        public override List<LocacaoTaxasServicos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasLocacoes, ConverterEmLocacaoTaxasServicos);
        }

        public List<TaxasServicos> SelecionarTaxasServicosPorLocacaoId(int idLocacao) 
        {
            List<TaxasServicos> taxasServicos = new List<TaxasServicos>();
            foreach (LocacaoTaxasServicos Locacao_TaxaServico in SelecionarTodos())
            {
                if (idLocacao == Locacao_TaxaServico.locacao.Id)
                    taxasServicos.Add(Locacao_TaxaServico.taxasServicos);
            }
            return taxasServicos;
        }


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
            Locacao locacao = controladorLocacao.SelecionarPorId(idLocacao);

            var idTaxasServicos = Convert.ToInt32(reader["IDTAXASSERVICOS"]);
            TaxasServicos taxasServicos = controladorTaxasServicos.SelecionarPorId(idTaxasServicos);

            LocacaoTaxasServicos locacaoTaxasServicos = new LocacaoTaxasServicos(locacao, taxasServicos);

            locacaoTaxasServicos.Id = Convert.ToInt32(reader["ID"]);

            return locacaoTaxasServicos;
        }

    }
}
