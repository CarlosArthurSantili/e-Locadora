using e_Locadora.Dominio;
using e_Locadora.Controladores.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace e_Locadora.Controladores.VeiculoModule
{
    public class GrupoVeiculoControlador : Controlador<GrupoVeiculo>
    {
        private const string sqlInserirGrupoVeiculo =
            @"INSERT INTO TBCATEGORIAS 
	                (
		                [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADODIARIO],
                        [VALORLIVRE]
	                ) 
	                VALUES
	                (
                        @CATEGORIA, 
		                @VALORDIARIOKM, 
		                @VALORDIARIO,
                        @VALORCONTROLADODIARIOKM, 
		                @VALORCONTROLADODIARIO,
                        @VALORLIVRE
	                )";

        private const string sqlEditarGrupoVeiculo =
            @"UPDATE TBCATEGORIAS
                    SET
                        [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADODIARIO],
                        [VALORLIVRE]
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirGrupoVeiculo =
            @"DELETE 
	                FROM
                        TBCATEGORIAS
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarGrupoVeiculoPorId =
            @"SELECT
                        [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADODIARIO],
                        [VALORLIVRE]
	                FROM
                        TBCATEGORIAS
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosGrupoVeiculos =
            @"SELECT
                        [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADODIARIO],
                        [VALORLIVRE]
	                FROM
                        TBCATEGORIAS ORDER BY CATEGORIA;";

        private const string sqlExisteGrupoVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCATEGORIAS]
            WHERE 
                [ID] = @ID";

        public override string InserirNovo(GrupoVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoVeiculo, ObtemParametrosGrupoVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, GrupoVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoVeiculo, ObtemParametrosGrupoVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoVeiculo, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoVeiculo, AdicionarParametro("ID", id));
        }

        public override GrupoVeiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoVeiculoPorId, ConverterEmGrupoVeiculo, AdicionarParametro("ID", id));
        }

        public override List<GrupoVeiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoVeiculos, ConverterEmGrupoVeiculo);
        }

        private GrupoVeiculo ConverterEmGrupoVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string categoria = Convert.ToString(reader["CATEGORIA"]);
            double planoDiarioValorKm = Convert.ToDouble(reader["VALORDIARIOKM"]);
            double planoDiarioValorDiario = Convert.ToDouble(reader["VALORDIARIO"]);
            double planoKmControladoValorKm = Convert.ToDouble(reader["VALORCONTROLADODIARIOKM"]);
            double planoKmControladoValorDiario = Convert.ToDouble(reader["VALORCONTROLADODIARIO"]);
            double planoKmLivreValorDiario = Convert.ToDouble(reader["VALORLIVRE"]);

            GrupoVeiculo contato = new GrupoVeiculo(categoria, planoDiarioValorKm, planoDiarioValorDiario, planoKmControladoValorKm, planoKmControladoValorDiario, planoKmLivreValorDiario);

            contato.Id = id;

            return contato;
        }

        private Dictionary<string, object> ObtemParametrosGrupoVeiculo(GrupoVeiculo grupoVeiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", grupoVeiculo.Id);
            parametros.Add("CATEGORIA", grupoVeiculo.categoria);
            parametros.Add("VALORDIARIOKM", grupoVeiculo.planoDiarioValorKm);
            parametros.Add("VALORDIARIO", grupoVeiculo.planoDiarioValorDiario);
            parametros.Add("VALORCONTROLADODIARIOKM", grupoVeiculo.planoKmControladoValorKm);
            parametros.Add("VALORCONTROLADODIARIO", grupoVeiculo.planoKmControladoValorDiario);
            parametros.Add("VALORLIVRE", grupoVeiculo.planoKmLivreValorDiario);

            return parametros;
        }
    }
}
