using FluentResults;
using LocadoraMengão.Aplicacao.ModuloFuncionário;
using LocadoraMengão.Domínio.ModuloFuncionário;
using LocadoraMengão.WinApp.Compartilhado;

namespace LocadoraMengão.WinApp.ModuloFuncionário
{
    public class ControladorFuncionario : ControladorBase
    {
        private IRepositorioFuncionario repositorioFuncionario;

        private TabelaFuncionarioControl tabelaFuncionario;

        private ServicoFuncionario servicoFuncionario;

        public ControladorFuncionario(
            IRepositorioFuncionario repositorioFuncionario,
            ServicoFuncionario servicoFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoFuncionario = servicoFuncionario;
        }

        public override void Inserir()
        {
            FormFuncionario tela = new FormFuncionario();

            tela.onGravarRegistro += servicoFuncionario.Inserir;

            tela.ConfigurarFuncionario(new Funcionario());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }
        }

        public override void Editar()
        {
            int id = tabelaFuncionario.ObtemIdSelecionado();

            Funcionario funcionarioSelecionado = repositorioFuncionario.SelecionarPorId(id);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionário primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormFuncionario tela = new FormFuncionario();

            tela.onGravarRegistro += servicoFuncionario.Editar;

            tela.ConfigurarFuncionario(funcionarioSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }
        }

        public override void Excluir()
        {
            int id = tabelaFuncionario.ObtemIdSelecionado();

            Funcionario disciplinaSelecionada = repositorioFuncionario.SelecionarPorId(id);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione um funcionário primeiro",
                "Exclusão de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o funcionário?",
               "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoFuncionario.Excluir(disciplinaSelecionada);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Funcionários",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarFuncionarios();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxFuncionario();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }

        private void CarregarFuncionarios()
        {
            List<Funcionario> disciplinas = repositorioFuncionario.SelecionarTodos();

            tabelaFuncionario.AtualizarRegistros(disciplinas);

            mensagemRodape = string.Format("Visualizando {0} disciplina{1}", disciplinas.Count, disciplinas.Count == 1 ? "" : "s");

            FormPrincipal.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
