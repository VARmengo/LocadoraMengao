using LocadoraMengão.Domínio.ModuloFuncionário;

namespace LocadoraMengão.Aplicacao.ModuloFuncionário
{
    public class ServicoFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private ValidadorFuncionario validadorFuncionario;

        public ServicoFuncionario(
            IRepositorioFuncionario repositorioFuncionario,
            ValidadorFuncionario validadorFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.validadorFuncionario = validadorFuncionario;
        }

        public Result Inserir(Funcionario funcionario)
        {
            Log.Debug("Tentando inserir funcionário...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioFuncionario.Inserir(funcionario);

                Log.Debug("funcionário {FuncionárioId} inserido com sucesso", funcionario.Id);

                return Result.Ok();
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar inserir funcionário.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Editar(Funcionario funcionario)
        {
            Log.Debug("Tentando editar funcionário...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioFuncionario.Editar(funcionario);

                Log.Debug("Funcionário {FuncionarioId} editada com sucesso", funcionario.Id);

                return Result.Ok();
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar editar funcionário.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Funcionario funcionario)
        {
            Log.Debug("Tentando excluir funcionário...{@d}", funcionario);

            try
            {
                repositorioFuncionario.Excluir(funcionario);

                Log.Debug("Funcionário {FuncionárioId} excluído com sucesso", funcionario.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro = "erro";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {FuncionárioId}", funcionario.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarFuncionario(Funcionario funcionario)
        {
            List<string> erros = validadorFuncionario.Validate(funcionario)
                .Errors.Select(x => x.ErrorMessage).ToList();

            if (NomeDuplicado(funcionario))
                erros.Add($"Este nome '{funcionario.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = repositorioFuncionario.SelecionarPorNome(funcionario.Nome);

            if (funcionarioEncontrado != null &&
                funcionarioEncontrado.Id != funcionario.Id &&
                funcionarioEncontrado.Nome == funcionario.Nome)
            {
                return true;
            }

            return false;
        }

        //private static string ObterMensagemDeErro(SqlException ex)
        //{
        //    string msgErro;

        //    if (ex.Message.Contains("FK_TBMateria_TBDisciplina"))
        //        msgErro = "Esta disciplina está relacionada com uma matéria e não pode ser excluída";
        //    else
        //        msgErro = "Esta disciplina não pode ser excluída";

        //    return msgErro;
        //}
    }
}
