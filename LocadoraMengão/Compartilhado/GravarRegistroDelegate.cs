using FluentResults;
using LocadoraMengão.Domínio;

namespace LocadoraMengão.WinApp.Compartilhado
{
        public delegate Result GravarRegistroDelegate<TEntidade>(TEntidade entidade)
        where TEntidade : EntidadeBase<TEntidade>;
}
