using LocadoraMengão.WinApp.Compartilhado;

namespace LocadoraMengão.WinApp.ModuloCliente
{
    public class ConfigurarToolboxCliente : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Cliente";

        public override string TooltipInserir => "Inserir novo Cliente";

        public override string TooltipEditar => "Editar um Cliente existente";

        public override string TooltipExcluir => "Excluir um Cliente existente";
    }
}
