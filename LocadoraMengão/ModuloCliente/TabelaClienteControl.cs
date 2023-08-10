﻿using LocadoraMengão.Domínio.ModuloCliente;
using LocadoraMengão.Domínio.ModuloFuncionário;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraMengão.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
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

                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", FillWeight=85F }
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return grid.SelecionarIdInt();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                grid.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone, cliente.Email);
            }
        }
    }
}
