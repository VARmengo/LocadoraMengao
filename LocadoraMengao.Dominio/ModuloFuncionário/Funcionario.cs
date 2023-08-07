using LocadoraMengão.Domínio;

namespace LocadoraMengão.Domínio.ModuloFuncionário
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public Funcionario()
        {

        }

        public Funcionario(string nome, string admissao, int salario) : this()
        {
            Nome = nome;
            Admissao = admissao;
            Salario = salario;
        }

        public Funcionario(int id, string nome, string admissao, int salario) : this(nome , admissao, salario)
        {
            this.Id = id;
            this.Admissao = admissao;
            this.Salario = salario;
        }

        public string Nome { get; set; }
        public string Admissao { get; set; }
        public int Salario { get; set; }



        public override string ToString()
        {
            return Nome;
        }

        public override void Atualizar(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Admissao = funcionario.Admissao;
            Salario = funcionario.Salario;
        }

        public override bool Equals(object obj)
        {
            return obj is Funcionario funcionario &&
                   Id == funcionario.Id &&
                   Nome == funcionario.Nome &&
                   Admissao == funcionario.Admissao &&
                   Salario == funcionario.Salario;
        }

    }
}