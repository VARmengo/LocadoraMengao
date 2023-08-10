using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.Infra.Sql.Compartilhado;

namespace LocadoraMengão.Infra.Sql.ModuloCliente
{
    public class MapeadorClienteSql : MapeadorBase<Cliente>
    {
        public override void ConfigurarParametros(SqlCommand comando, Cliente cliente)
        {
            comando.Parameters.AddWithValue("ID", cliente.Id);

            comando.Parameters.AddWithValue("NOME", cliente.Nome);

            comando.Parameters.AddWithValue("TELEFONE", cliente.Telefone);

            comando.Parameters.AddWithValue("EMAIL", cliente.Email);
        }

        public override Cliente ConverterRegistro(SqlDataReader leitorCliente)
        {
            if (leitorCliente.HasColumn("CLIENTE_ID") == false)
                return null;

            int id = int.Parse(leitorCliente["CLIENTE_ID"].ToString());

            string nome = Convert.ToString(leitorCliente["CLIENTE_NOME"]);

            string telefone = Convert.ToString(leitorCliente["CLIENTE_TELEFONE"]);

            string email = Convert.ToString(leitorCliente["CLIENTE_EMAIL"]);

            Cliente cliente = new Cliente(id, nome, telefone, email);

            return cliente;
        }
    }
}
