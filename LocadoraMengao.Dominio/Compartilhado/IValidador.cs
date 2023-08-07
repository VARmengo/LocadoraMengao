using System.ComponentModel.DataAnnotations;

namespace LocadoraMengão.Domínio.Compartilhado
{
    public interface IValidador<T> where T : EntidadeBase<T>
    {
        public ValidationResult Validate(T instance);
    }
}
