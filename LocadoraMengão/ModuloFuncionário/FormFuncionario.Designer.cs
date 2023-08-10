namespace LocadoraMengão.WinApp.ModuloFuncionário
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            txtNome = new TextBox();
            mkdDataAdmissao = new MaskedTextBox();
            txtSalario = new TextBox();
            nome = new Label();
            label1 = new Label();
            labelSalario = new Label();
            btnSalvar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(64, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 23);
            txtNome.TabIndex = 0;
            // 
            // mkdDataAdmissao
            // 
            mkdDataAdmissao.Location = new Point(107, 79);
            mkdDataAdmissao.Mask = "00/00/0000";
            mkdDataAdmissao.Name = "mkdDataAdmissao";
            mkdDataAdmissao.Size = new Size(84, 23);
            mkdDataAdmissao.TabIndex = 1;
            mkdDataAdmissao.ValidatingType = typeof(DateTime);
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(70, 123);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(92, 23);
            txtSalario.TabIndex = 2;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(12, 36);
            nome.Name = "nome";
            nome.Size = new Size(46, 15);
            nome.TabIndex = 3;
            nome.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Data Admissão:";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(12, 126);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(45, 15);
            labelSalario.TabIndex = 5;
            labelSalario.Text = "Salário:";
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.Location = new Point(83, 176);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 75);
            btnSalvar.TabIndex = 6;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = Properties.Resources.close;
            btnSair.Location = new Point(198, 176);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 75);
            btnSair.TabIndex = 7;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 263);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(labelSalario);
            Controls.Add(label1);
            Controls.Add(nome);
            Controls.Add(txtSalario);
            Controls.Add(mkdDataAdmissao);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Funcionários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private MaskedTextBox mkdDataAdmissao;
        private TextBox txtSalario;
        private Label nome;
        private Label label1;
        private Label labelSalario;
        private Button btnSalvar;
        private Button btnSair;
    }
}