using LocadoraMengão.Domínio.Compartilhado;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LocadoraMengão.Domínio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente
    {
        public ValidadorCliente()
        {
            RuleFor(c => c.Nome)
                .MinimumLength(3).WithMessage(@"'Nome' deve ser maior ou igual a 3 caracteres.")
                .Custom(ValidarCaractereInvalido)
                .NotEmpty();

            RuleFor(c => c.Email)
            .NotEmpty()
            .Must(ValidarFormatoEmail).WithMessage("'Email' inválido.");


            RuleFor(c => c.NumeroDocumento)
            .NotEmpty().WithMessage("'CPF' não pode ser vazio.")
            .Custom(ValidarCPF)
            .When(c => c.TipoCliente == TipoClienteEnum.CPF);

            RuleFor(c => c.NumeroDocumento)
            .NotEmpty().WithMessage("'CNPJ' não pode ser vazio.")
            .Custom(ValidarCNPJ)
            .When(c => c.TipoCliente == TipoClienteEnum.CNPJ);

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("'Estado' não pode ser vazio.")
                .MinimumLength(3).WithMessage("'Estado' deve ser maior ou igual a 3 caracteres.");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("'Cidade' não pode ser vazio.")
                .MinimumLength(3).WithMessage("'Cidade' deve ser maior ou igual a 3 caracteres.");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("'Bairro' não pode ser vazio.")
                .MinimumLength(3).WithMessage("'Bairro' deve ser maior ou igual a 3 caracteres.");

            RuleFor(c => c.Rua)
                .NotEmpty().WithMessage("'Rua' não pode ser vazio.")
                .MinimumLength(3).WithMessage("'Rua' deve ser maior ou igual a 3 caracteres.");

        }

        private void ValidarCaractereInvalido(string nome, ValidationContext<Cliente> contexto)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return;

            if (!Regex.IsMatch(nome, @"^[\p{L}\p{M}'\s-\d]+$"))
                contexto.AddFailure("Caractere Inválido");
        }

        private bool ValidarFormatoEmail(string email)
        {
            string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regexEmail = new Regex(padraoEmail);

            return regexEmail.IsMatch(email);
        }

        private void ValidarCPF(string document, ValidationContext<Cliente> contexto)
        {
            if (Regex.IsMatch(document, @"^\d{3}.\d{3}.\d{3}-\d{2}$"))
                return;

            else
                contexto.AddFailure("CPF", "CPF inválido.");
        }

        private void ValidarCNPJ(string document, ValidationContext<Cliente> contexto)
        {
            if (Regex.IsMatch(document, @"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$"))
                return;

            else
                contexto.AddFailure("CNPJ", "CNPJ inválido!");
        }

        private bool ValidarTelefone(string telefone)
        {
            return Regex.IsMatch(telefone, @"^\(\d{2}\) \d{4,5}-\d{4}$");
        }

        ValidationResult IValidador<Cliente>.Validate(Cliente instance)
        {
            throw new NotImplementedException();
        }
    }
}
