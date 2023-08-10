using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;

namespace LocadoraMengão.Aplicacao.ModuloCliente
{
    public class ServicoCliente
    {
        private IRepositorioCliente repositorioCliente;
        private ValidadorCliente validadorCliente;

        public ServicoCliente(
            IRepositorioCliente repositorioCliente,
            ValidadorCliente validadorCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.validadorCliente = validadorCliente;
        }

        public Result Inserir(Cliente cliente)
        {
            Log.Debug("Tentando inserir cliente...{@d}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCliente.Inserir(cliente);

                Log.Debug("Cliente {ClienteId} inserida com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar inserir cliente.";

                Log.Error(exc, msgErro + "{@d}", cliente);

                return Result.Fail(msgErro);
            }
        }

        public Result Editar(Cliente cliente)
        {
            Log.Debug("Tentando editar cliente...{@d}", cliente);

            List<string> erros = ValidarCliente(cliente);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCliente.Editar(cliente);

                Log.Debug("Cliente {ClienteId} editado com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar editar cliente.";

                Log.Error(exc, msgErro + "{@d}", cliente);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Cliente cliente)
        {
            Log.Debug("Tentando excluir cliente...{@d}", cliente);

            try
            {
                repositorioCliente.Excluir(cliente);

                Log.Debug("Cliente {ClienteId} excluída com sucesso", cliente.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro = ObterMensagemDeErro(ex);

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {ClienteId}", cliente.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarCliente(Cliente cliente)
        {
            List<string> erros = validadorCliente.Validate(cliente)
                .Errors.Select(x => x.ErrorMessage).ToList();

            if (NomeDuplicado(cliente))
                erros.Add($"Este nome '{cliente.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Cliente cliente)
        {
            Cliente clienteEncontrado = repositorioCliente.SelecionarPorNome(cliente.Nome);

            if (clienteEncontrado != null &&
                clienteEncontrado.Id != cliente.Id &&
                clienteEncontrado.Nome == cliente.Nome)
            {
                return true;
            }

            return false;
        }

        #region Arrumar após ter metodo Aluguel
        private static string ObterMensagemDeErro(SqlException ex)
        {
            string msgErro;

            if (ex.Message.Contains("FK_TBMateria_TBDisciplina"))
                msgErro = "Este cliente está relacionada com um aluguel e não pode ser excluído";
            else
                msgErro = "Esta cliente não pode ser excluído";

            return msgErro;
        }
        #endregion

    }
}
