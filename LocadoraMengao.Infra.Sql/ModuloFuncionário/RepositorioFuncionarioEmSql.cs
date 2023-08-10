using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.Infra.Sql.Compartilhado;


namespace LocadoraMengão.Infra.Sql.ModuloFuncionário
{
    public class RepositorioFuncionarioEmSql :
        RepositorioEmSqlBase<Funcionario, MapeadorFuncionarioSql>, IRepositorioFuncionario
    {
        public RepositorioFuncionarioEmSql(string connectionString)
        {

        }

        #region slq queries
        protected override string sqlInserir =>
            @"INSERT INTO [tb_funcionarios]
                (
                    [Nome]                   
                   ,[DataAdmissao]
                   ,[Salario]
                )    
                 VALUES
                (
                    @NOME
                   ,@ADMISSAO
                   ,@SALARIO
                )";

        protected override string sqlEditar =>
            @"UPDATE [tb_funcionarios]	
		        SET
			        [Nome] = @NOME
			       ,[DataAdmissao] = @ADMISSAO
			       ,[Salario] = @SALARIO
		        WHERE
			        [Id] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [tb_funcionarios]
		        WHERE
			        [Id] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
		            [Id]    FUNCIONARIO_ID
		           ,[Nome]  FUNCIONARIO_NOME
		           ,[DataAdmissao]  FUNCIONARIO_ADMISSAO
		           ,[Salario]  FUNCIONARIO_SALARIO

	            FROM 
		            [tb_funcionarios]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
		            [Id]    FUNCIONARIO_ID
		           ,[Nome]  FUNCIONARIO_NOME
		           ,[DataAdmissao]  FUNCIONARIO_ADMISSAO
		           ,[Salario]  FUNCIONARIO_SALARIO

	            FROM 
		            [tb_funcionarios]

                 WHERE
                    [Id] = @ID";

        private string sqlSelecionarPorNome =>
            @"SELECT 
		            [Id]    FUNCIONARIO_ID
		           ,[Nome]  FUNCIONARIO_NOME
		           ,[DataAdmissao]  FUNCIONARIO_ADMISSAO
		           ,[Salario]  FUNCIONARIO_SALARIO

	            FROM 
		            [tb_funcionarios]

                 WHERE
                    [Nome] = @NOME";

        protected override string sqlExisteRegistro =>
             @"SELECT 

		            COUNT(*)

	            FROM 
		            [tb_funcionarios]

		        WHERE
                    [Id] = @ID";


        #endregion

        public List<Funcionario> SelecionarTodos()
        {
            List<Funcionario> funcionarios = base.SelecionarTodos();

            return funcionarios;
        }

        public Funcionario SelecionarPorNome(string nome)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("NOME", nome) };

            return base.SelecionarRegistroPorParametro(sqlSelecionarPorNome, parametros);
        }

        public Funcionario SelecionarPorId(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("ID", id) };

            return base.SelecionarRegistroPorParametro(sqlSelecionarPorId, parametros);
        }
    }
}
