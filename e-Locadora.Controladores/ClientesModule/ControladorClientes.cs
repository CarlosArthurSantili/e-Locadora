using e_Locadora.Controladores.Shared;
using e_Locadora.Dominio.ClientesModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Controladores.ClientesModule
{
    public class ControladorClientes : Controlador<Clientes>
    {
        #region
        private const string sqlInserirCliente =
            @"INSERT INTO TBCLIENTES 
	                (
		                [NOME], 
		                [ENDERECO], 
		                [TELEFONE],
                        [RG], 
		                [CPF],
                        [CNPJ]
	                ) 
	                VALUES
	                (
                        @NOME, 
		                @ENDERECO, 
		                @TELEFONE,
                        @RG, 
		                @CPF,
                        @CNPJ
	                )";

        private const string sqlEditarCliente =
            @"UPDATE TBCLIENTES
                    SET
                        [NOME] = @NOME, 
		                [ENDERECO] = @ENDERECO, 
		                [TELEFONE] = @TELEFONE,
                        [RG] = @RG, 
		                [CPF] = @CPF,
                        [CNPJ] = @CNPJ
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCliente =
            @"DELETE 
	                FROM
                        TBCLIENTES
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarClientePorId =
            @"SELECT
                        [ID],
                        [NOME], 
		                [ENDERECO], 
		                [TELEFONE],
                        [RG], 
		                [CPF],
                        [CNPJ]
	                FROM
                        TBCLIENTES
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosClientes =
            @"SELECT
                        [ID],
                        [NOME], 
		                [ENDERECO], 
		                [TELEFONE],
                        [RG], 
		                [CPF],
                        [CNPJ] FROM TBCLIENTES";

        private const string sqlExisteCliente =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTES]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string InserirNovo(Clientes registro)
        {
            throw new NotImplementedException();
        }
        public override string Editar(int id, Clientes registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override Clientes SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Clientes> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
