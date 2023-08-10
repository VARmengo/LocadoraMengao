﻿using LocadoraMengão.Domínio.ModuloFuncionário;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraMengão.WinApp.ModuloFuncionário
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible=false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Admissão", HeaderText = "Admissão", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Salário", HeaderText = "Salário", FillWeight=85F }
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return grid.SelecionarIdInt();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                grid.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Admissao, funcionario.Salario);
            }
        }
    }
}
