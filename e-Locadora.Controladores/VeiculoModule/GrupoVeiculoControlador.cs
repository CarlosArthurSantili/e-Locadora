using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.VeiculoModule
{
    public class GrupoVeiculoControlador
    {
        private const string sqlInserirGrupoVeiculo =
            @"INSERT INTO TBCATEGORIAS 
	                (
		                [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADORDIARIO],
                        [VALORLIVRE]
	                ) 
	                VALUES
	                (
                        @CATEGORIA, 
		                @VALORDIARIOKM, 
		                @VALORDIARIO,
                        @VALORCONTROLADODIARIOKM, 
		                @VALORCONTROLADORDIARIO,
                        @VALORLIVRE
	                )";

        private const string sqlEditarGrupoVeiculo =
            @"UPDATE TBCATEGORIAS
                    SET
                        [CATEGORIA], 
		                [VALORDIARIOKM], 
		                [VALORDIARIO],
                        [VALORCONTROLADODIARIOKM], 
		                [VALORCONTROLADORDIARIO],
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
		                [VALORCONTROLADORDIARIO],
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
		                [VALORCONTROLADORDIARIO],
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
    }
}
