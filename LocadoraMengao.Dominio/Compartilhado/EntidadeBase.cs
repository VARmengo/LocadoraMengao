namespace LocadoraMengão.Domínio
{
    public abstract class EntidadeBase<T>
    {
        public int Id { get; set; }

        public EntidadeBase()
        {
            Id = Id++;
        }

        public abstract void Atualizar(T registro);
    }
}