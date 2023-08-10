using FluentResults;
using LocadoraMengão.Aplicacao.ModuloCliente;
using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.WinApp.Compartilhado;
using LocadoraMengão.WinApp.ModuloFuncionário;

namespace LocadoraMengão.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;

        private TabelaClienteControl tabelaCliente;

        private ServicoCliente servicoCliente;

        public ControladorCliente(
            IRepositorioCliente repositorioCliente,
            ServicoCliente servicoCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.servicoCliente = servicoCliente;
        }

        public override void Inserir()
        {
            FormCliente tela = new FormCliente();

            tela.onGravarRegistro += servicoCliente.Inserir;

            tela.ConfigurarCliente(new Cliente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }

        public override void Editar()
        {
            int id = tabelaCliente.ObtemIdSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormCliente tela = new FormCliente();

            tela.onGravarRegistro += servicoCliente.Editar;

            tela.ConfigurarCliente(clienteSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }

        public override void Excluir()
        {
            int id = tabelaCliente.ObtemIdSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Exclusão de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o cliente?",
               "Exclusão de Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCliente.Excluir(clienteSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarClientes();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxFuncionario();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);

            mensagemRodape = string.Format("Visualizando {0} cliente{1}", clientes.Count, clientes.Count == 1 ? "" : "s");

            FormPrincipal.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
