namespace LocadoraMengão.Domínio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public TipoClienteEnum TipoCliente { get; set; }
        public string NumeroDocumento { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, string email) : this()
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public Cliente(string nome, string email, string telefone, TipoClienteEnum tipoCliente, string numeroDocumento, string estado, string cidade, string bairro, string rua, int numero)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            TipoCliente = tipoCliente;
            NumeroDocumento = numeroDocumento;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }

        public Cliente(int id , string nome, string telefone, string email) : this(nome, telefone, email)
        {
            this.Id = id;
            this.Telefone = telefone;
            this.Email = email;
        }

        public override void Atualizar(Cliente cliente)
        {
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Email = cliente.Email;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email &&
                   Telefone == cliente.Telefone &&
                   TipoCliente == cliente.TipoCliente &&
                   NumeroDocumento == cliente.NumeroDocumento &&
                   Estado == cliente.Estado &&
                   Cidade == cliente.Cidade &&
                   Bairro == cliente.Bairro &&
                   Rua == cliente.Rua &&
                   Numero == cliente.Numero;
        }
    }
}
