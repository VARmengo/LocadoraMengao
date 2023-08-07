using LocadoraMengão.WinApp.Compartilhado;

namespace LocadoraMengão.WinApp.ModuloFuncionário
{
    public class ConfigurarToolboxFuncionario : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Funcionário";

        public override string TooltipInserir => "Inserir novo Funcionário";

        public override string TooltipEditar => "Editar um Funcionário existente";

        public override string TooltipExcluir => "Excluir um Funcionário existente";
    }
}
