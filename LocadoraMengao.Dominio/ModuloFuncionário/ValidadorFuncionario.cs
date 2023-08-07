using LocadoraMengão.Domínio.Compartilhado;
using System.ComponentModel.DataAnnotations;

namespace LocadoraMengão.Domínio.ModuloFuncionário
{
    public class ValidadorFuncionario : AbstractValidator<Funcionario>, IValidadorFuncionario
    {
        public ValidadorFuncionario()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(4);
        }
    }
}
