using System.ComponentModel;

namespace LocadoraMengão.Domínio.ModuloCliente
{
    public enum TipoClienteEnum
    {
        [Description("Pessoa Fisica CPF")]
        CPF = 1,

        [Description("Pessoa Juridica CNPJ")]
        CNPJ = 2,
    }
}
