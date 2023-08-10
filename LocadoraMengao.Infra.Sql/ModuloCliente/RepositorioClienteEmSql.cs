using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.Infra.Sql.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraMengão.Infra.Sql.ModuloCliente
{
    public class RepositorioClienteEmSql : RepositorioEmSqlBase<Cliente, MapeadorClienteSql>, IRepositorioCliente
    {
        public RepositorioClienteEmSql(string connectionString)
        {

        }

        #region slq queries
        protected override string sqlInserir =>
            @"INSERT INTO [tb_clientes]
                (
                    [Nome]                   
                    ,[Telefone]
                    ,[Email]
                )    
                 VALUES
                (
                    @NOME
                    ,@TELEFONE
                    ,@EMAIL
                )";

        protected override string sqlEditar =>
            @"UPDATE [tb_clientes]	
		        SET
			        [Nome] = @NOME
			        ,[Telefone] = @TELEFONE
			        ,[Email] = @EMAIL
		        WHERE
			        [Id] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [tb_clientes]
		        WHERE
			        [Id] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
		            [Id]    CLIENTE_ID
		            ,[Nome]  CLIENTE_NOME
		            ,[Telefone]  CLIENTE_TELEFONE
		           ,[Email]  CLIENTE_EMAIL

	            FROM 
		            [tb_clientes]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
		            [Id]    CLIENTE_ID
		            ,[Nome]  CLIENTE_NOME
		            ,[Telefone]  CLIENTE_TELEFONE
		            ,[Email]  CLIENTE_EMAIL

	            FROM 
		            [tb_clientes]

                 WHERE
                    [Id] = @ID";

        private string sqlSelecionarPorNome =>
            @"SELECT 
		            [Id]    CLIENTE_ID
		            ,[Nome]  CLIENTE_NOME
		            ,[Telefone]  CLIENTE_TELEFONE
		            ,[Email]  CLIENTE_EMAIL

	            FROM 
		            [tb_clientes]

                 WHERE
                    [Nome] = @NOME";

        protected override string sqlExisteRegistro =>
             @"SELECT 

		            COUNT(*)

	            FROM 
		            [tb_clientes]

		        WHERE
                    [Id] = @ID";


        #endregion

        public Cliente SelcionarPorNome(string nome)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("NOME", nome) };

            return base.SelecionarRegistroPorParametro(sqlSelecionarPorNome, parametros);
        }

        public Cliente SelecionarPorId(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("ID", id) };

            return base.SelecionarRegistroPorParametro(sqlSelecionarPorId, parametros);
        }

        public List<Cliente> SelecionarTodos()
        {
            List<Cliente> clientes = base.SelecionarTodos();

            return clientes;
        }

        public Cliente SelecionarPorNome(string nome)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("NOME", nome) };

            return base.SelecionarRegistroPorParametro(sqlSelecionarPorNome, parametros);
        }
    }
}
