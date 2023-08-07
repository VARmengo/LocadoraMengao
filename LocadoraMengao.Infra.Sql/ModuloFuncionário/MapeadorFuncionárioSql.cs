using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.Infra.Sql.Compartilhado;

namespace LocadoraMengão.Infra.Sql.ModuloFuncionário
{
    public class MapeadorFuncionarioSql : MapeadorBase<Funcionario>
    {
        public override void ConfigurarParametros(SqlCommand comando, Funcionario funcionario)
        {
            comando.Parameters.AddWithValue("ID", funcionario.Id);

            comando.Parameters.AddWithValue("NOME", funcionario.Nome);

            comando.Parameters.AddWithValue("ADMISSAO", funcionario.Admissao);

            comando.Parameters.AddWithValue("SALARIO", funcionario.Salario);
        }

        public override Funcionario ConverterRegistro(SqlDataReader leitorFuncionario)
        {
            if (leitorFuncionario.HasColumn("FUNCIONARIO_ID") == false)
                return null;
            
            int id = int.Parse(leitorFuncionario["FUNCIONARIO_ID"].ToString());

            string nome = Convert.ToString(leitorFuncionario["FUNCIONARIO_NOME"]);

            string admissao = Convert.ToString(leitorFuncionario["FUNCIONARIO_ADMISSAO"]);

            int salario = int.Parse(leitorFuncionario["FUNCIONARIO_SALARIO"].ToString());

            Funcionario funcionario = new Funcionario(id, nome, admissao, salario);

            return funcionario;
        }
    }
}
