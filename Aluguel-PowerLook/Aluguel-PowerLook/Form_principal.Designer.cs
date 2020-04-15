namespace Aluguel_PowerLook
{
    partial class Form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vestidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_cadFornecedor = new System.Windows.Forms.Button();
            this.btn_cadVestido = new System.Windows.Forms.Button();
            this.btn_cadFuncionario = new System.Windows.Forms.Button();
            this.btn_cadCliente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.cToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.vestidoToolStripMenuItem,
            this.funcionárioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // vestidoToolStripMenuItem
            // 
            this.vestidoToolStripMenuItem.Name = "vestidoToolStripMenuItem";
            this.vestidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vestidoToolStripMenuItem.Text = "Vestido";
            this.vestidoToolStripMenuItem.Click += new System.EventHandler(this.vestidoToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cToolStripMenuItem.Text = "Consulta";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // button8
            // 
            this.button8.Image = global::Aluguel_PowerLook.Properties.Resources.Busca;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(692, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 56);
            this.button8.TabIndex = 8;
            this.button8.Text = "Busca";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::Aluguel_PowerLook.Properties.Resources.Relatorio;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(692, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 56);
            this.button7.TabIndex = 7;
            this.button7.Text = "Relatório";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::Aluguel_PowerLook.Properties.Resources.Devolução;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(416, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "Devolução";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Aluguel_PowerLook.Properties.Resources.Aluguel;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(416, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "Aluguel";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_cadFornecedor
            // 
            this.btn_cadFornecedor.Image = global::Aluguel_PowerLook.Properties.Resources.Fornecedor;
            this.btn_cadFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadFornecedor.Location = new System.Drawing.Point(134, 185);
            this.btn_cadFornecedor.Name = "btn_cadFornecedor";
            this.btn_cadFornecedor.Size = new System.Drawing.Size(189, 56);
            this.btn_cadFornecedor.TabIndex = 4;
            this.btn_cadFornecedor.Text = "Cadastro Fornecedor";
            this.btn_cadFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadFornecedor.UseVisualStyleBackColor = true;
            this.btn_cadFornecedor.Click += new System.EventHandler(this.btn_cadFornecedor_Click);
            // 
            // btn_cadVestido
            // 
            this.btn_cadVestido.Image = global::Aluguel_PowerLook.Properties.Resources.Vestido;
            this.btn_cadVestido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadVestido.Location = new System.Drawing.Point(134, 260);
            this.btn_cadVestido.Name = "btn_cadVestido";
            this.btn_cadVestido.Size = new System.Drawing.Size(189, 56);
            this.btn_cadVestido.TabIndex = 3;
            this.btn_cadVestido.Text = "Cadastro Vestido";
            this.btn_cadVestido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadVestido.UseVisualStyleBackColor = true;
            this.btn_cadVestido.Click += new System.EventHandler(this.btn_cadVestido_Click);
            // 
            // btn_cadFuncionario
            // 
            this.btn_cadFuncionario.Image = global::Aluguel_PowerLook.Properties.Resources.Funcionario;
            this.btn_cadFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadFuncionario.Location = new System.Drawing.Point(134, 336);
            this.btn_cadFuncionario.Name = "btn_cadFuncionario";
            this.btn_cadFuncionario.Size = new System.Drawing.Size(189, 56);
            this.btn_cadFuncionario.TabIndex = 2;
            this.btn_cadFuncionario.Text = "Cadastro Funcionário";
            this.btn_cadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadFuncionario.UseVisualStyleBackColor = true;
            this.btn_cadFuncionario.Click += new System.EventHandler(this.btn_cadFuncionario_Click);
            // 
            // btn_cadCliente
            // 
            this.btn_cadCliente.Image = global::Aluguel_PowerLook.Properties.Resources.Cliente;
            this.btn_cadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadCliente.Location = new System.Drawing.Point(134, 108);
            this.btn_cadCliente.Name = "btn_cadCliente";
            this.btn_cadCliente.Size = new System.Drawing.Size(189, 56);
            this.btn_cadCliente.TabIndex = 1;
            this.btn_cadCliente.Text = "Cadastro Cliente";
            this.btn_cadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadCliente.UseVisualStyleBackColor = true;
            this.btn_cadCliente.Click += new System.EventHandler(this.btn_cadCliente_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 592);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_cadFornecedor);
            this.Controls.Add(this.btn_cadVestido);
            this.Controls.Add(this.btn_cadFuncionario);
            this.Controls.Add(this.btn_cadCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vestidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.Button btn_cadCliente;
        private System.Windows.Forms.Button btn_cadFuncionario;
        private System.Windows.Forms.Button btn_cadVestido;
        private System.Windows.Forms.Button btn_cadFornecedor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

