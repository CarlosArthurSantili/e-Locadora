using e_Locadora.Controladores.Shared;
using e_Locadora.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.CupomModule
{
    public class ControladorCupons : Controlador<Cupons>
    {
        #region Queries


        private const string sqlInserirCupom =
        @"INSERT INTO TBCUPONS
	                (	
		                [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [PARCEIRO]
	                )
	                VALUES
	                (
                        @NOME, 
		                @VALOR_PERCENTUAL, 
		                @VALOR_FIXO,
                        @DATA_VALIDADE,
                        @PARCEIRO
	                )";

        private const string sqlEditarCupom =
        @"UPDATE TBCUPONS
                    SET
                        [NOME] = @NOME, 
		                [VALOR_PERCENTUAL] = @VALOR_PERCENTUAL, 
		                [VALOR_FIXO] = @VALOR_FIXO,
                        [DATA_VALIDADE] = @DATA_VALIDADE,
                        [PARCEIRO] = @PARCEIRO
                     
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCupom =
        @"DELETE 
	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";

        private const string sqlExisteCupom =
         @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBCUPONS]
                WHERE 
                    [ID] = @ID";

        private const string sqlSelecionarTodosCupons =
        @"SELECT
                        [ID],
                        [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [PARCEIRO]

                        FROM TBCUPONS";

        private const string sqlSelecionarCupomPorId =
         @"SELECT
                        [ID],
                        [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [PARCEIRO]
	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";

        #endregion

        public override string Editar(int id, Cupons registro)
        {
            string resultadoValidacao = registro.Validar();
            string resultadoValidacaoControlador = ValidarCupons(registro, id);

            if (resultadoValidacao == "ESTA_VALIDO" && resultadoValidacaoControlador == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCupom, ObtemParametrosCupons(registro));
            }

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                return resultadoValidacao;
            }
            else
            {
                return resultadoValidacaoControlador;
            }
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCupom, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCupom, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Cupons registro)
        {
            string resultadoValidacao = registro.Validar();
            string resultadoValidacaoControlador = ValidarCupons(registro);

            if (resultadoValidacao == "ESTA_VALIDO" && resultadoValidacaoControlador == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCupom, ObtemParametrosCupons(registro));
            }

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                return resultadoValidacao;
            }
            else
            {
                return resultadoValidacaoControlador;
            }
        }

        private Dictionary<string, object> ObtemParametrosCupons(Cupons cupons)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", cupons.Id);
            parametros.Add("NOME", cupons.Nome);
            parametros.Add("VALOR_PERCENTUAL", cupons.ValorPercentual);
            parametros.Add("VALOR_FIXO", cupons.ValorFixo);
            parametros.Add("DATA_VALIDADE", cupons.DataValidade);
            parametros.Add("PARCEIRO", cupons.Parceiro);
            return parametros;
        }

        private string ValidarCupons(Cupons novoCupons, int id = 0)
        {
            //validar placas iguais
            if (novoCupons != null)
            {
                if (id != 0)
                {//situação de editar
                    int countCuponsIguaiss = 0;
                    List<Cupons> todosCupons = SelecionarTodos();
                    foreach (Cupons cupons in todosCupons)
                    {
                        if (novoCupons.Nome.Equals(cupons.Nome) && cupons.Id != id)
                            countCuponsIguaiss++;
                    }
                    if (countCuponsIguaiss > 0)
                        return "Cupom já cadastrada, tente novamente.";
                }
                else
                {//situação de inserir
                    int countTaxasIguais = 0;
                    List<Cupons> todosCupons = SelecionarTodos();
                    foreach (Cupons cupons in todosCupons)
                    {
                        if (novoCupons.Nome.Equals(cupons.Nome))
                            countTaxasIguais++;
                    }
                    if (countTaxasIguais > 0)
                        return "Cupom já cadastrada, tente novamente.";
                }
            }
            return "ESTA_VALIDO";
        }

        public override Cupons SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCupomPorId, ConverterEmCupom, AdicionarParametro("ID", id));
        }

        public override List<Cupons> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCupons, ConverterEmCupom);
        }

        private Cupons ConverterEmCupom(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            int valor_Percentual = Convert.ToInt32(reader["VALOR_PERCENTUAL"]);
            double valor_Fixo = Convert.ToDouble(reader["VALOR_FIXO"]);
            DateTime data = Convert.ToDateTime(reader["DATA_VALIDADE"]);
            string parceiro = Convert.ToString(reader["PARCEIRO"]);

            Cupons cupons = new Cupons(nome, valor_Percentual, valor_Fixo, data, parceiro);

            cupons.Id = id;

            return cupons;
        }
    }
}
