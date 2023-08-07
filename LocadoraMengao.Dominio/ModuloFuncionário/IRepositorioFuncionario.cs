namespace LocadoraMengão.Domínio.ModuloFuncionário
{
    public interface IRepositorioFuncionario : IRepositorio<Funcionario>
    {
        Funcionario SelecionarPorNome(string nome);
        Funcionario SelecionarPorId(int id);
        List<Funcionario> SelecionarTodos();
    }
}
