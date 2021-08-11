using e_Locadora.Controladores.Shared;
using e_Locadora.Dominio;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.VeiculoModule
{
    public class ControladorVeiculos : Controlador<Veiculo>
    {
        #region Queries
        private const string sqlInserirVeiculo =
         @"INSERT INTO TBVEICULOS
	                (
		                [PLACA], 
		                [FABRICANTE], 
		                [QTDLITROSTANQUE],
                        [QTDPORTAS],
                        [NUMEROCHASSI], 
		                [COR],
                        [CAPACIDADEOCUPANTES],
                        [ANOFABRICACAO],
                        [TAMANHOPORTAMALAS],
                        [TIPOCOMBUSTIVEL],
                        [IDGRUPOVEICULO]
	                ) 
	                VALUES
	                (
                        @PLACA, 
		                @FABRICANTE, 
		                @QTDLITROSTANQUE,
                        @QTDPORTAS,
                        @NUMEROCHASSI,
                        @COR, 
		                @CAPACIDADEOCUPANTES,
                        @ANOFABRICACAO,
                        @TAMANHOPORTAMALAS,
                        @TIPOCOMBUSTIVEL,
                        @IDGRUPOVEICULO
	                )";



        private const string sqlEditarVeiculo =
         @"UPDATE TBVEICULOS
                    SET
                        [PLACA] = @PLACA,
		                [FABRICANTE] = @FABRICANTE, 
		                [QTDLITROSTANQUE] = @QTDLITROSTANQUE,
                        [QTDPORTAS] = @QTDPORTAS,
                        [NUMEROCHASSI] = @NUMEROCHASSI, 
		                [COR] = @COR,
                        [CAPACIDADEOCUPANTES] = @CAPACIDADEOCUPANTES,
                        [ANOFABRICACAO] = @ANOFABRICACAO,
                        [TAMANHOPORTAMALAS] = @TAMANHOPORTAMALAS,
                        [TIPOCOMBUSTIVEL] = @TIPOCOMBUSTIVEL,
                        [IDGRUPOVEICULO] = @IDGRUPOVEICULO
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirVeiculo =
         @"DELETE 
	              FROM
                        TBVEICULOS
                    WHERE 
                        ID = @ID";

        private const string sqlExisteVeiculo =
        @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULOS]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarVeiculoPorId =
        @"SELECT
                        [ID],
                        [PLACA], 
		                [FABRICANTE], 
		                [QTDLITROSTANQUE],
                        [QTDPORTAS],
                        [NUMEROCHASSI], 
		                [COR],
                        [CAPACIDADEOCUPANTES],
                        [ANOFABRICACAO],
                        [TAMANHOPORTAMALAS],
                        [TIPOCOMBUSTIVEL],
                        [IDGRUPOVEICULO],
                        [IMAGEM]
	                FROM
                        TBVEICULOS
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosVeiculos =
        @"SELECT
                        [ID],
                        [PLACA], 
		                [FABRICANTE], 
		                [QTDLITROSTANQUE],
                        [QTDPORTAS],
                        [NUMEROCHASSI], 
		                [COR],
                        [CAPACIDADEOCUPANTES],
                        [ANOFABRICACAO],
                        [TAMANHOPORTAMALAS],
                        [TIPOCOMBUSTIVEL],
                        [IDGRUPOVEICULO],
                        [IMAGEM]
                        FROM TBVEICULOS";


        #endregion
        public override string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirVeiculo, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteVeiculo, AdicionarParametro("ID", id));
        }

        public override Veiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarVeiculoPorId, ConverterEmVeiculo, AdicionarParametro("ID", id));
        }

        public override List<Veiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosVeiculos, ConverterEmVeiculo);
        }


        #region Metodos Privados

        private Veiculo ConverterEmVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string placa = Convert.ToString(reader["PLACA"]);
            string fabricante = Convert.ToString(reader["FABRICANTE"]);
            int qtdLitrosTanque = Convert.ToInt32(reader["QTDLITROSTANQUE"]);
            int qtdPortas = Convert.ToInt32(reader["QTDPORTAS"]);
            string numeroChassi = Convert.ToString(reader["NUMEROCHASSI"]);
            string cor = Convert.ToString(reader["COR"]);
            int capacidadeDeOcupantes = Convert.ToInt32(reader["CAPACIDADEOCUPANTES"]);
            int anoFabricacao = Convert.ToInt32(reader["ANOFABRICACAO"]);
            string tamanhoPortaMalas = Convert.ToString(reader["TAMANHOPORTAMALAS"]);
            string combustivel  = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            int idGrupoVeiculo = Convert.ToInt32(reader["IDGRUPOVEICULO"]);

            ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
            GrupoVeiculo grupoVeiculo = controladorGrupoVeiculo.SelecionarPorId(idGrupoVeiculo);

            Veiculo veiculo = new Veiculo(placa, fabricante, qtdLitrosTanque, qtdPortas, numeroChassi, cor, capacidadeDeOcupantes, anoFabricacao, tamanhoPortaMalas, combustivel, grupoVeiculo);

            veiculo.Id = id;

            return veiculo;
        }
        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", veiculo.Id);
            parametros.Add("PLACA", veiculo.Placa);
            parametros.Add("FABRICANTE", veiculo.Fabricante);
            parametros.Add("QTDLITROSTANQUE", veiculo.QtdLitrosTanque);
            parametros.Add("QTDPORTAS", veiculo.QtdPortas);
            parametros.Add("NUMEROCHASSI", veiculo.NumeroChassi);
            parametros.Add("COR", veiculo.Cor);
            parametros.Add("CAPACIDADEOCUPANTES", veiculo.CapacidadeOcupantes);
            parametros.Add("ANOFABRICACAO", veiculo.AnoFabricacao);
            parametros.Add("TAMANHOPORTAMALAS", veiculo.TamanhoPortaMalas);
            parametros.Add("TIPOCOMBUSTIVEL", veiculo.Combustivel);
            parametros.Add("IDGRUPOVEICULO", veiculo.GrupoVeiculo.Id);


            return parametros;
        }

        #endregion
    }
}
