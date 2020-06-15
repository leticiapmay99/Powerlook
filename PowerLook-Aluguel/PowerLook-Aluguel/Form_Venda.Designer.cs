namespace PowerLook_Aluguel
{
    partial class Form_Venda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_usuarioLabel;
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorLabel1;
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.groupBoxNovaVenda = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.BtnFinalizarPedido = new System.Windows.Forms.Button();
            this.TextBoxValorTotal = new System.Windows.Forms.TextBox();
            this.TextBoxDesconto = new System.Windows.Forms.TextBox();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.DataGridItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.ComboBoxProduto = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_vendaTextBox = new System.Windows.Forms.TextBox();
            id_usuarioLabel = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBoxNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(139, 44);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(42, 13);
            id_usuarioLabel.TabIndex = 1;
            id_usuarioLabel.Text = "Cliente:";
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Location = new System.Drawing.Point(53, 49);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(40, 13);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Código";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(47, 75);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(44, 13);
            id_produtoLabel.TabIndex = 2;
            id_produtoLabel.Text = "Produto";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(32, 102);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(62, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(62, 128);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(31, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Location = new System.Drawing.Point(203, 471);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(58, 13);
            valor_pagoLabel.TabIndex = 16;
            valor_pagoLabel.Text = "Valor Total";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(209, 441);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(53, 13);
            descontoLabel.TabIndex = 14;
            descontoLabel.Text = "Desconto";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(230, 415);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(31, 13);
            valorLabel1.TabIndex = 12;
            valorLabel1.Text = "Valor";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(DBPowerLook.DAL.Venda);
            // 
            // id_usuarioComboBox
            // 
            this.id_usuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "id_usuario", true));
            this.id_usuarioComboBox.DataSource = this.usuariosBindingSource;
            this.id_usuarioComboBox.DisplayMember = "nome";
            this.id_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_usuarioComboBox.FormattingEnabled = true;
            this.id_usuarioComboBox.Location = new System.Drawing.Point(187, 41);
            this.id_usuarioComboBox.Name = "id_usuarioComboBox";
            this.id_usuarioComboBox.Size = new System.Drawing.Size(282, 21);
            this.id_usuarioComboBox.TabIndex = 2;
            this.id_usuarioComboBox.ValueMember = "id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(DBPowerLook.DAL.Usuarios);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(498, 39);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(90, 23);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // groupBoxNovaVenda
            // 
            this.groupBoxNovaVenda.Controls.Add(this.btnImprimir);
            this.groupBoxNovaVenda.Controls.Add(this.btnFinalizarVenda);
            this.groupBoxNovaVenda.Controls.Add(this.BtnFinalizarPedido);
            this.groupBoxNovaVenda.Controls.Add(valor_pagoLabel);
            this.groupBoxNovaVenda.Controls.Add(this.TextBoxValorTotal);
            this.groupBoxNovaVenda.Controls.Add(descontoLabel);
            this.groupBoxNovaVenda.Controls.Add(this.TextBoxDesconto);
            this.groupBoxNovaVenda.Controls.Add(valorLabel1);
            this.groupBoxNovaVenda.Controls.Add(this.TextBoxValor);
            this.groupBoxNovaVenda.Controls.Add(this.btnNovoItem);
            this.groupBoxNovaVenda.Controls.Add(this.DataGridItem);
            this.groupBoxNovaVenda.Controls.Add(valorLabel);
            this.groupBoxNovaVenda.Controls.Add(this.valorTextBox);
            this.groupBoxNovaVenda.Controls.Add(quantidadeLabel);
            this.groupBoxNovaVenda.Controls.Add(this.quantidadeTextBox);
            this.groupBoxNovaVenda.Controls.Add(id_produtoLabel);
            this.groupBoxNovaVenda.Controls.Add(this.ComboBoxProduto);
            this.groupBoxNovaVenda.Controls.Add(id_vendaLabel);
            this.groupBoxNovaVenda.Controls.Add(this.id_vendaTextBox);
            this.groupBoxNovaVenda.Location = new System.Drawing.Point(104, 97);
            this.groupBoxNovaVenda.Name = "groupBoxNovaVenda";
            this.groupBoxNovaVenda.Size = new System.Drawing.Size(616, 516);
            this.groupBoxNovaVenda.TabIndex = 4;
            this.groupBoxNovaVenda.TabStop = false;
            this.groupBoxNovaVenda.Text = "Nova Venda";
            this.groupBoxNovaVenda.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(101, 471);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 23);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Enabled = false;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(101, 442);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(90, 23);
            this.btnFinalizarVenda.TabIndex = 19;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // BtnFinalizarPedido
            // 
            this.BtnFinalizarPedido.Location = new System.Drawing.Point(101, 409);
            this.BtnFinalizarPedido.Name = "BtnFinalizarPedido";
            this.BtnFinalizarPedido.Size = new System.Drawing.Size(90, 23);
            this.BtnFinalizarPedido.TabIndex = 17;
            this.BtnFinalizarPedido.Text = "Finalizar Pedido";
            this.BtnFinalizarPedido.UseVisualStyleBackColor = true;
            this.BtnFinalizarPedido.Click += new System.EventHandler(this.BtnFinalizarPedido_Click);
            // 
            // TextBoxValorTotal
            // 
            this.TextBoxValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor_pago", true));
            this.TextBoxValorTotal.Location = new System.Drawing.Point(269, 468);
            this.TextBoxValorTotal.Name = "TextBoxValorTotal";
            this.TextBoxValorTotal.ReadOnly = true;
            this.TextBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValorTotal.TabIndex = 18;
            // 
            // TextBoxDesconto
            // 
            this.TextBoxDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "desconto", true));
            this.TextBoxDesconto.Location = new System.Drawing.Point(269, 438);
            this.TextBoxDesconto.Name = "TextBoxDesconto";
            this.TextBoxDesconto.ReadOnly = true;
            this.TextBoxDesconto.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDesconto.TabIndex = 15;
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor", true));
            this.TextBoxValor.Location = new System.Drawing.Point(269, 412);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.ReadOnly = true;
            this.TextBoxValor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValor.TabIndex = 13;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(275, 125);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(90, 23);
            this.btnNovoItem.TabIndex = 5;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // DataGridItem
            // 
            this.DataGridItem.AllowUserToAddRows = false;
            this.DataGridItem.AllowUserToDeleteRows = false;
            this.DataGridItem.AutoGenerateColumns = false;
            this.DataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ValorTotal});
            this.DataGridItem.DataSource = this.itensVendaBindingSource;
            this.DataGridItem.Location = new System.Drawing.Point(83, 173);
            this.DataGridItem.Name = "DataGridItem";
            this.DataGridItem.ReadOnly = true;
            this.DataGridItem.Size = new System.Drawing.Size(460, 220);
            this.DataGridItem.TabIndex = 8;
            this.DataGridItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridItem_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produtos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produtos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "id_item";
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(DBPowerLook.DAL.itensVenda);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(101, 125);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(101, 99);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // ComboBoxProduto
            // 
            this.ComboBoxProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "id_produto", true));
            this.ComboBoxProduto.DataSource = this.produtosBindingSource;
            this.ComboBoxProduto.DisplayMember = "nome";
            this.ComboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduto.FormattingEnabled = true;
            this.ComboBoxProduto.Location = new System.Drawing.Point(101, 72);
            this.ComboBoxProduto.Name = "ComboBoxProduto";
            this.ComboBoxProduto.Size = new System.Drawing.Size(222, 21);
            this.ComboBoxProduto.TabIndex = 3;
            this.ComboBoxProduto.ValueMember = "id";
            this.ComboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.id_produtoComboBox_SelectedIndexChanged);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(DBPowerLook.DAL.Produtos);
            // 
            // id_vendaTextBox
            // 
            this.id_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_venda", true));
            this.id_vendaTextBox.Location = new System.Drawing.Point(101, 46);
            this.id_vendaTextBox.Name = "id_vendaTextBox";
            this.id_vendaTextBox.ReadOnly = true;
            this.id_vendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_vendaTextBox.TabIndex = 1;
            // 
            // Form_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 625);
            this.Controls.Add(this.groupBoxNovaVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(id_usuarioLabel);
            this.Controls.Add(this.id_usuarioComboBox);
            this.Name = "Form_Venda";
            this.Text = "FormVenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Venda_FormClosed);
            this.Load += new System.EventHandler(this.Form_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBoxNovaVenda.ResumeLayout(false);
            this.groupBoxNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox id_usuarioComboBox;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.GroupBox groupBoxNovaVenda;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.DataGridView DataGridItem;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox ComboBoxProduto;
        private System.Windows.Forms.TextBox id_vendaTextBox;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button BtnFinalizarPedido;
        private System.Windows.Forms.TextBox TextBoxValorTotal;
        private System.Windows.Forms.TextBox TextBoxDesconto;
        private System.Windows.Forms.TextBox TextBoxValor;
    }
}