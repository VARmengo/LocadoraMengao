namespace LocadoraMengão
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            toolbox = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDuplicar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnGerarPdf = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            menu = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            funcionarioMenuItem = new ToolStripMenuItem();
            AutomovelMenuItem = new ToolStripMenuItem();
            ClienteMenuItem = new ToolStripMenuItem();
            taxaServicoMenuItem = new ToolStripMenuItem();
            planosDeCobrancasMenuItem = new ToolStripMenuItem();
            automoveisMenuItem = new ToolStripMenuItem();
            condutoresMenuItem = new ToolStripMenuItem();
            alugueisMenuItem = new ToolStripMenuItem();
            parceirosMenuItem = new ToolStripMenuItem();
            cuponsMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            toolbox.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 56);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 372);
            panelRegistros.TabIndex = 7;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodapé]";
            // 
            // toolbox
            // 
            toolbox.Enabled = false;
            toolbox.ImageScalingSize = new Size(20, 20);
            toolbox.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDuplicar, btnExcluir, toolStripSeparator2, btnVisualizar, toolStripSeparator3, toolStripSeparator1, btnFiltrar, toolStripSeparator4, btnGerarPdf, labelTipoCadastro });
            toolbox.Location = new Point(0, 24);
            toolbox.Name = "toolbox";
            toolbox.Size = new Size(800, 32);
            toolbox.TabIndex = 5;
            toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(5);
            btnInserir.Size = new Size(72, 29);
            btnInserir.Text = "Adicionar";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(51, 29);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDuplicar
            // 
            btnDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDuplicar.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicar.ImageTransparentColor = Color.Magenta;
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Padding = new Padding(5);
            btnDuplicar.Size = new Size(65, 29);
            btnDuplicar.Text = "Duplicar";
            btnDuplicar.Click += btnDuplicar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(56, 29);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(5);
            btnVisualizar.Size = new Size(70, 29);
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 32);
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGerarPdf.ImageScaling = ToolStripItemImageScaling.None;
            btnGerarPdf.ImageTransparentColor = Color.Magenta;
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Padding = new Padding(5);
            btnGerarPdf.Size = new Size(70, 29);
            btnGerarPdf.Text = "Gerar Pdf";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 32);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(5);
            btnFiltrar.Size = new Size(51, 29);
            btnFiltrar.Text = "Filtrar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 32);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(90, 29);
            labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 4;
            menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionarioMenuItem, AutomovelMenuItem, ClienteMenuItem, taxaServicoMenuItem, planosDeCobrancasMenuItem, automoveisMenuItem, condutoresMenuItem, alugueisMenuItem, parceirosMenuItem, cuponsMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionarioMenuItem
            // 
            funcionarioMenuItem.Name = "funcionarioMenuItem";
            funcionarioMenuItem.ShortcutKeys = Keys.F1;
            funcionarioMenuItem.Size = new Size(183, 22);
            funcionarioMenuItem.Text = "Funcionários";
            funcionarioMenuItem.Click += funcionarioMenuItem_Click;
            // 
            // AutomovelMenuItem
            // 
            AutomovelMenuItem.Name = "AutomovelMenuItem";
            AutomovelMenuItem.ShortcutKeys = Keys.F2;
            AutomovelMenuItem.Size = new Size(183, 22);
            AutomovelMenuItem.Text = "Automóveis";
            AutomovelMenuItem.Click += AutomovelMenuItem_Click;
            // 
            // ClienteMenuItem
            // 
            ClienteMenuItem.Name = "ClienteMenuItem";
            ClienteMenuItem.ShortcutKeys = Keys.F3;
            ClienteMenuItem.Size = new Size(183, 22);
            ClienteMenuItem.Text = "Clientes";
            ClienteMenuItem.Click += ClienteMenuItem_Click;
            // 
            // taxaServicoMenuItem
            // 
            taxaServicoMenuItem.Name = "taxaServicoMenuItem";
            taxaServicoMenuItem.ShortcutKeys = Keys.F4;
            taxaServicoMenuItem.Size = new Size(183, 22);
            taxaServicoMenuItem.Text = "Taxas de Serviços";
            taxaServicoMenuItem.Click += taxaServicoMenuItem_Click;
            // 
            // planosDeCobrancasMenuItem
            // 
            planosDeCobrancasMenuItem.Name = "planosDeCobrancasMenuItem";
            planosDeCobrancasMenuItem.Size = new Size(183, 22);
            planosDeCobrancasMenuItem.Text = "Plano de Cobrança";
            planosDeCobrancasMenuItem.Click += planosDeCobrancasMenuItem_Click;
            // 
            // automoveisMenuItem
            // 
            automoveisMenuItem.Name = "automoveisMenuItem";
            automoveisMenuItem.Size = new Size(183, 22);
            automoveisMenuItem.Text = "Automóveis";
            automoveisMenuItem.Click += automoveisMenuItem_Click;
            // 
            // condutoresMenuItem
            // 
            condutoresMenuItem.Name = "condutoresMenuItem";
            condutoresMenuItem.Size = new Size(183, 22);
            condutoresMenuItem.Text = "Condutores";
            condutoresMenuItem.Click += condutoresMenuItem_Click;
            // 
            // alugueisMenuItem
            // 
            alugueisMenuItem.Name = "alugueisMenuItem";
            alugueisMenuItem.Size = new Size(183, 22);
            alugueisMenuItem.Text = "Aluguéis";
            alugueisMenuItem.Click += alugueisMenuItem_Click;
            // 
            // parceirosMenuItem
            // 
            parceirosMenuItem.Name = "parceirosMenuItem";
            parceirosMenuItem.Size = new Size(183, 22);
            parceirosMenuItem.Text = "Parceiros";
            parceirosMenuItem.Click += parceirosMenuItem_Click;
            // 
            // cuponsMenuItem
            // 
            cuponsMenuItem.Name = "cuponsMenuItem";
            cuponsMenuItem.Size = new Size(183, 22);
            cuponsMenuItem.Text = "Cupons";
            cuponsMenuItem.Click += cuponsMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolbox);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locadora Mengão";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolbox.ResumeLayout(false);
            toolbox.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStrip toolbox;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDuplicar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnVisualizar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnGerarPdf;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel labelTipoCadastro;
        private MenuStrip menu;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem funcionarioMenuItem;
        private ToolStripMenuItem AutomovelMenuItem;
        private ToolStripMenuItem ClienteMenuItem;
        private ToolStripMenuItem taxaServicoMenuItem;
        private ToolStripMenuItem planosDeCobrancasMenuItem;
        private ToolStripMenuItem automoveisMenuItem;
        private ToolStripMenuItem condutoresMenuItem;
        private ToolStripMenuItem alugueisMenuItem;
        private ToolStripMenuItem parceirosMenuItem;
        private ToolStripMenuItem cuponsMenuItem;
    }
}