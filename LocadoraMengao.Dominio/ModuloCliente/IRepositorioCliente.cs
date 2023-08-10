using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraMengão.Domínio.ModuloCliente
{
    public interface IRepositorioCliente : IRepositorio<Cliente>
    {
        Cliente SelcionarPorNome(string nome);

        Cliente SelecionarPorId(int id);
        Cliente SelecionarPorNome(string nome);
        List<Cliente> SelecionarTodos();
    }
}
