using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraMengão.WinApp.Compartilhado
{
    public abstract class ConfiguracaoToolboxBase
    {
        public abstract string TipoCadastro { get; }

        public abstract string TooltipInserir { get; }

        public abstract string TooltipEditar { get; }

        public abstract string TooltipExcluir { get; }

        public virtual string TooltipAdicionarItens { get; }

        public virtual string TooltipAtualizarItens { get; }

        public virtual string TooltipFiltrar { get; }

        public virtual string TooltipGerarPdf { get; }

        public virtual string TooltipDuplicar { get; }

        public virtual string TooltipVisualizar { get; }

    }
}
