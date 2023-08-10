using FluentResults;
using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.WinApp.Compartilhado;

namespace LocadoraMengão.WinApp.ModuloCliente
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        public event GravarRegistroDelegate<Cliente> onGravarRegistro;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                FormPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
            else if (resultado.IsSuccess)
            {
                FormPrincipal.Instancia.AtualizarRodape("Cliente cadastrado com sucesso!");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Cliente ObterCliente()
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Rua = txtRua.Text;


            return cliente;
        }

        public void ConfigurarCliente(Cliente cliente)
        {
            this.cliente = cliente;

            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtEstado.Text = cliente.Estado;
            txtNumero.Text = cliente.Numero.ToString();
            txtRua.Text = cliente.Rua;            
        }
    }
}
