using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.Shared;
using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
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
        ControladorClientes controladorCliente = new ControladorClientes();
        ControladorCondutor controladorCondutor = new ControladorCondutor();
        ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
        ControladorVeiculos controladorVeiculo = new ControladorVeiculos();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

        #region Queries
        private const string sqlInserirLocacao =
         @"INSERT INTO TBLOCACAO
	                (
		                [ID_FUNCIONARIO], 
		                [ID_CLIENTE], 
		                [ID_CONDUTOR],
                        [ID_GRUPOVEICULO], 
                        [ID_VEICULO], 
		                [EMABERTO],
                        [DATAINICIAL],
                        [DATAFINAL],
                        [VALORTOTAL]
	                ) 
	                VALUES
	                (
                        @ID_FUNCIONARIO, 
		                @ID_CLIENTE, 
		                @ID_CONDUTOR,
                        @ID_GRUPOVEICULO,
                        @ID_VEICULO,
                        @EMABERTO, 
		                @DATAINICIAL,
                        @DATAFINAL
	                )";

        private const string sqlEditarLocacao =
         @"UPDATE TBLOCACAO
                    SET
                        [ID_FUNCIONARIO] = @ID_FUNCIONARIO,
		                [ID_CLIENTE] = @ID_CLIENTE, 
		                [ID_CONDUTOR] = @ID_CONDUTOR,
                        [ID_VEICULO] = @ID_VEICULO, 
		                [EMABERTO] = @EMABERTO,
                        [DATAINICIAL] = @DATAINICIAL,
                        [DATAFINAL] = @DATAFINAL
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
                CP.[ID],       
                CP.[ID_FUNCIONARIO],
                CP.[ID_CLIENTE],
                CP.[ID_CONDUTOR],             
                CP.[ID_VEICULO],                    
                CP.[EMABERTO],                                
                CP.[DATAINICIAL],
                CP.[DATAFINAL],
                CP.[ID_CLIENTE],
                CT.[ID_FUNCIONARIO],       
                CT.[ID_CLIENTE],             
                CT.[ID_CONDUTOR],                    
                CT.[RG], 
                CT.[CPF],
                CT.[CNPJ]
            FROM
                [TBLOCACAO] AS CP LEFT JOIN 
                [TBCLIENTES] AS CT
            ON
                CT.ID = CP.ID_CLIENTE
            WHERE
                 CP.[ID] = @ID";

        private const string sqlSelecionarTodosLocacaoes =
            @"SELECT 
                CP.[ID],       
                CP.[ID_FUNCIONARIO],
                CP.[ID_CLIENTE],
                CP.[ID_CONDUTOR],             
                CP.[ID_VEICULO],                    
                CP.[EMABERTO],                                
                CP.[DATAINICIAL],
                CP.[DATAFINAL],
                CP.[ID_CLIENTE],
                CT.[ID_FUNCIONARIO],       
                CT.[ID_CLIENTE],             
                CT.[ID_CONDUTOR],                    
                CT.[RG], 
                CT.[CPF],
                CT.[CNPJ]
            FROM
                [TBLOCACAO] AS CP LEFT JOIN 
                [TBCLIENTES] AS CT
            ON
                CT.ID = CP.ID_CLIENTE";
        private const string sqlSelecionarLocacaoesEmAberto =
            @"SELECT 
                CP.[ID],       
                CP.[ID_FUNCIONARIO],
                CP.[ID_CLIENTE],
                CP.[ID_CONDUTOR],             
                CP.[ID_VEICULO],                    
                CP.[EMABERTO],                                
                CP.[DATAINICIAL],
                CP.[DATAFINAL],
                CP.[ID_CLIENTE],
                CT.[ID_FUNCIONARIO],       
                CT.[ID_CLIENTE],             
                CT.[ID_CONDUTOR],                    
                CT.[RG], 
                CT.[CPF],
                CT.[CNPJ]
            FROM
                [TBLOCACAO] AS CP LEFT JOIN 
                [TBCLIENTES] AS CT
            ON
                CT.ID = CP.ID_CLIENTE
           WHERE 
                CP.[DATAFINAL] <= @DATAFINAL";


        #endregion
        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirLocacao, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacao, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {

            try
            {
                Db.Delete(sqlExcluirLocacao, AdicionarParametro("ID", id));
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
            return Db.Get(sqlSelecionarLocacaoPorId, ConverterEmLocacao, AdicionarParametro("ID", id));
        }

        public override List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosLocacaoes, ConverterEmLocacao);
        }
        public List<Locacao> SelecionarLocacaoesEmAberto(DateTime data)
        {
            return Db.GetAll(sqlSelecionarLocacaoesEmAberto, ConverterEmLocacao, AdicionarParametro("DATAFINAL", data));
        }

        
        

        private Dictionary<string, object> ObtemParametrosLocacao(Locacao locacao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", locacao.Id);
            parametros.Add("ID_FUNCIONARIO", locacao.funcionario);
            parametros.Add("ID_CLIENTE", locacao.cliente.Id);
            parametros.Add("ID_CONDUTOR", locacao.condutor.Id);
            parametros.Add("ID_GRUPOVEICULO", locacao.grupoVeiculo);
            parametros.Add("ID_VEICULO", locacao.veiculo.Id);
            parametros.Add("EMABERTO", locacao.emAberto);
            parametros.Add("DATAINICIAL", locacao.dataLocacao);
            parametros.Add("DATAFINAL", locacao.dataDevolucao);

            return parametros;
        }
        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            //var idFuncionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
            //Funcionario funcionario = controladorFuncionario.SelecionarPorId(idFuncionario);
            string funcionario = "Rech";

            var idCliente = Convert.ToInt32(reader["ID_CLIENTE"]);
            Clientes cliente = controladorCliente.SelecionarPorId(idCliente);

            var idCondutor = Convert.ToInt32(reader["ID_CONDUTOR"]);
            Condutor condutor = controladorCondutor.SelecionarPorId(idCondutor);

            var idGrupoVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            GrupoVeiculo grupoVeiculo = controladorGrupoVeiculo.SelecionarPorId(idGrupoVeiculo);

            var idVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            Veiculo veiculo = controladorVeiculo.SelecionarPorId(idVeiculo);

            var idTaxasServicoes = Convert.ToString(reader["ID_VEICULO"]);
            //transformar string em array de ints;
            //foreach taxasServicos
            //lista de taxasServicoes.add()
            List<TaxasServicos> taxasServicos = new List<TaxasServicos>();

            var emAberto = Convert.ToBoolean(reader["EMABERTO"]);
            var dataInicial = Convert.ToDateTime(reader["DATAINICIAL"]);
            var dataFinal = Convert.ToDateTime(reader["DATAFINAL"]);
            var plano = Convert.ToString(reader["PLANO"]);




            Locacao locacao = new Locacao(funcionario, dataInicial, dataFinal, plano, grupoVeiculo, veiculo, cliente, condutor, taxasServicos, emAberto);

            locacao.Id = Convert.ToInt32(reader["ID"]);

            return locacao;
        }



    }
}
