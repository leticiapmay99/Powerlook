namespace PowerLook_Aluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vestidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnVestido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVenda = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.vestidoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Enabled = false;
            this.funcionárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionárioToolStripMenuItem.Image")));
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionários";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // vestidoToolStripMenuItem
            // 
            this.vestidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vestidoToolStripMenuItem.Image")));
            this.vestidoToolStripMenuItem.Name = "vestidoToolStripMenuItem";
            this.vestidoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.vestidoToolStripMenuItem.Text = "Vestido";
            this.vestidoToolStripMenuItem.Click += new System.EventHandler(this.vestidoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Enabled = false;
            this.fornecedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedorToolStripMenuItem.Image")));
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Enabled = false;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtoToolStripMenuItem.Text = "Produtos";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem1});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendaToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("vendaToolStripMenuItem1.Image")));
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.vendaToolStripMenuItem1.Text = "Realizar Venda";
            this.vendaToolStripMenuItem1.Click += new System.EventHandler(this.vendaToolStripMenuItem1_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::PowerLook_Aluguel.Properties.Resources.icon_logout;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnCategoria);
            this.groupBox1.Controls.Add(this.btnFuncionario);
            this.groupBox1.Controls.Add(this.btnFornecedor);
            this.groupBox1.Controls.Add(this.btnVestido);
            this.groupBox1.Location = new System.Drawing.Point(33, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros";
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(38, 37);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(112, 58);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(667, 37);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(126, 58);
            this.btnCategoria.TabIndex = 4;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Enabled = false;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(179, 37);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFuncionario.Size = new System.Drawing.Size(145, 58);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Enabled = false;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(488, 37);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFornecedor.Size = new System.Drawing.Size(152, 58);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnVestido
            // 
            this.btnVestido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVestido.Image = ((System.Drawing.Image)(resources.GetObject("btnVestido.Image")));
            this.btnVestido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVestido.Location = new System.Drawing.Point(350, 37);
            this.btnVestido.Name = "btnVestido";
            this.btnVestido.Size = new System.Drawing.Size(112, 58);
            this.btnVestido.TabIndex = 2;
            this.btnVestido.Text = "Vestidos";
            this.btnVestido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVestido.UseVisualStyleBackColor = true;
            this.btnVestido.Click += new System.EventHandler(this.btnVestido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRelatorio);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(501, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Enabled = false;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = global::PowerLook_Aluguel.Properties.Resources.icons8_medical_history_50;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(37, 42);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(120, 58);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(205, 42);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(120, 58);
            this.button8.TabIndex = 7;
            this.button8.Text = "Busca";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVenda);
            this.groupBox3.Location = new System.Drawing.Point(33, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 129);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(38, 42);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(114, 58);
            this.btnVenda.TabIndex = 5;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(896, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVestido;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vestidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

