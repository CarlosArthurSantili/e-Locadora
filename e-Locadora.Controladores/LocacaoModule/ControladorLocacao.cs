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
                        [DATALOCACAO],
                        [DATADEVOLUCAO],
                        [DATADEVOLUCAO],
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
		                @DATALOCACAO,
                        @DATADEVOLUCAO
	                )";

        private const string sqlEditarLocacao =
                    @"UPDATE TBLOCACAO
                    SET
                        [ID_FUNCIONARIO] = @ID_FUNCIONARIO,
		                [ID_CLIENTE] = @ID_CLIENTE, 
		                [ID_CONDUTOR] = @ID_CONDUTOR,
                        [ID_VEICULO] = @ID_VEICULO, 
		                [EMABERTO] = @EMABERTO,
                        [DATALOCACAO] = @DATALOCACAO,
                        [DATADEVOLUCAO] = @DATADEVOLUCAO
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
                [ID_FUNCIONARIO],
                [ID_CLIENTE],
                [ID_CONDUTOR], 
                [ID_GRUPOVEICULO],
                [ID_VEICULO],                    
                [EMABERTO],                                
                [DATALOCACAO],
                [DATADEVOLUCAO],
            FROM
                [TBLOCACAO]
            WHERE
                 CP.[ID] = @ID";

        private const string sqlSelecionarTodasLocacoes =
            @"SELECT 
                [ID],       
                [ID_FUNCIONARIO],
                [ID_CLIENTE],
                [ID_CONDUTOR],             
                [ID_VEICULO],                    
                [EMABERTO],                                
                [DATALOCACAO],
                [DATADEVOLUCAO]
            FROM
                [TBLOCACAO]";
        private const string sqlSelecionarLocacaoesEmAberto =
            @"SELECT 
                [ID],       
                [ID_FUNCIONARIO],
                [ID_CLIENTE],
                [ID_CONDUTOR],             
                [ID_VEICULO],                    
                [EMABERTO],                                
                [DATALOCACAO],
                [DATADEVOLUCAO]
            FROM
                [TBLOCACAO]
           WHERE 
                [EMABERTO] == @EMABERTO";


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
            return Db.GetAll(sqlSelecionarTodasLocacoes, ConverterEmLocacao);
        }
        public List<Locacao> SelecionarLocacaoesEmAberto(DateTime data)
        {
            return Db.GetAll(sqlSelecionarLocacaoesEmAberto, ConverterEmLocacao, AdicionarParametro("EMABERTO", data));
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
            //parametros.Add("EMABERTO", locacao.emAberto);
            parametros.Add("DATALOCACAO", locacao.dataLocacao);
            parametros.Add("DATADEVOLUCAO", locacao.dataDevolucao);

            return parametros;
        }
        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var idFuncionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
            Funcionario funcionario = controladorFuncionario.SelecionarPorId(idFuncionario);

            var idCliente = Convert.ToInt32(reader["ID_CLIENTE"]);
            Clientes cliente = controladorCliente.SelecionarPorId(idCliente);

            var idCondutor = Convert.ToInt32(reader["ID_CONDUTOR"]);
            Condutor condutor = controladorCondutor.SelecionarPorId(idCondutor);

            var idGrupoVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            GrupoVeiculo grupoVeiculo = controladorGrupoVeiculo.SelecionarPorId(idGrupoVeiculo);

            var idVeiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            Veiculo veiculo = controladorVeiculo.SelecionarPorId(idVeiculo);

            var emAberto = Convert.ToBoolean(reader["EMABERTO"]);
            var dataLocacao = Convert.ToDateTime(reader["DATALOCACAO"]);
            var dataDevolucao = Convert.ToDateTime(reader["DATADEVOLUCAO"]);
            var quilometragemDevolucao = Convert.ToDouble(reader["QUILOMETRAGEMDEVOLUCAO"]);
            var plano = Convert.ToString(reader["PLANO"]);
            var seguroCliente = Convert.ToDouble(reader["SEGUROCLIENTE"]);
            var seguroTerceiro = Convert.ToDouble(reader["SEGUROTERCEIRO"]);



            Locacao locacao = new Locacao(funcionario, dataLocacao, dataDevolucao, quilometragemDevolucao,plano, seguroCliente, seguroTerceiro, grupoVeiculo, veiculo, cliente, condutor, emAberto);

            locacao.Id = Convert.ToInt32(reader["ID"]);

            return locacao;
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
                        if (novoLocacao.veiculo.Id == locacao.veiculo.Id && locacao.Id != id)
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
                        if (novoLocacao.veiculo.Id == locacao.veiculo.Id)
                            countVeiculoIndisponivel++;
                    }
                    if (countVeiculoIndisponivel > 0)
                        return "Veiculo já alugado, tente novamente.";
                }
            }
            return "ESTA_VALIDO";
        }

        //Clube da Leitura
        /*
        public bool RegistrarDevolucao(int idEmprestimo, DateTime data)
        {
            Emprestimo emprestimo = SelecionarRegistroPorId(idEmprestimo);
            emprestimo.Fechar(data);
            return true;
        }

        internal List<Emprestimo> SelecionarEmprestimosEmAberto()
        {
            return itens.FindAll(emprestimo => emprestimo.estaAberto);
        }

        internal List<Emprestimo> SelecionarEmprestimosFechados(int mes)
        {
            return itens.FindAll(emprestimo => emprestimo.EstaFechado() && emprestimo.Mes == mes);
        }
        */

    }
}
