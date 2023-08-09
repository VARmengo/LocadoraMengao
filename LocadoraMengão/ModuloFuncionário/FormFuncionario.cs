using FluentResults;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.WinApp.Compartilhado;

namespace LocadoraMengão.WinApp.ModuloFuncionário
{
    public partial class FormFuncionario : Form
    {
        private Funcionario funcionario;
        public event GravarRegistroDelegate<Funcionario> onGravarRegistro;

        public FormFuncionario()
        {
            InitializeComponent();
        }

        public Funcionario ObterFuncionario()
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Admissao = mkdDataAdmissao.Text;
            funcionario.Salario = int.Parse(txtSalario.Text);

            return funcionario;
        }

        public void ConfigurarFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;

            txtNome.Text = funcionario.Nome;
            mkdDataAdmissao.Text = funcionario.Admissao;
            txtSalario.Text = funcionario.Salario.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.funcionario = ObterFuncionario();

            Result resultado = onGravarRegistro(funcionario);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                FormPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
