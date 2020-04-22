namespace PowerLook_Aluguel
{
    partial class Form_cad_produto
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
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label tamanhoLabel;
            System.Windows.Forms.Label tipo_decoteLabel;
            System.Windows.Forms.Label tipo_mangaLabel;
            System.Windows.Forms.Label id_fornecedorLabel;
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tamanhoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_decoteTextBox = new System.Windows.Forms.TextBox();
            this.tipo_mangaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_fornecedorComboBox = new System.Windows.Forms.ComboBox();
            corLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            tamanhoLabel = new System.Windows.Forms.Label();
            tipo_decoteLabel = new System.Windows.Forms.Label();
            tipo_mangaLabel = new System.Windows.Forms.Label();
            id_fornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(39, 96);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(26, 13);
            corLabel.TabIndex = 7;
            corLabel.Text = "Cor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(216, 99);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 8;
            descricaoLabel.Text = "Descricao:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(28, 69);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(235, 129);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 13;
            precoLabel.Text = "Preço:";
            // 
            // tamanhoLabel
            // 
            tamanhoLabel.AutoSize = true;
            tamanhoLabel.Location = new System.Drawing.Point(13, 126);
            tamanhoLabel.Name = "tamanhoLabel";
            tamanhoLabel.Size = new System.Drawing.Size(55, 13);
            tamanhoLabel.TabIndex = 15;
            tamanhoLabel.Text = "Tamanho:";
            // 
            // tipo_decoteLabel
            // 
            tipo_decoteLabel.AutoSize = true;
            tipo_decoteLabel.Location = new System.Drawing.Point(21, 153);
            tipo_decoteLabel.Name = "tipo_decoteLabel";
            tipo_decoteLabel.Size = new System.Drawing.Size(45, 13);
            tipo_decoteLabel.TabIndex = 17;
            tipo_decoteLabel.Text = "Decote:";
            // 
            // tipo_mangaLabel
            // 
            tipo_mangaLabel.AutoSize = true;
            tipo_mangaLabel.Location = new System.Drawing.Point(21, 179);
            tipo_mangaLabel.Name = "tipo_mangaLabel";
            tipo_mangaLabel.Size = new System.Drawing.Size(43, 13);
            tipo_mangaLabel.TabIndex = 19;
            tipo_mangaLabel.Text = "Manga:";
            // 
            // id_fornecedorLabel
            // 
            id_fornecedorLabel.AutoSize = true;
            id_fornecedorLabel.Location = new System.Drawing.Point(200, 68);
            id_fornecedorLabel.Name = "id_fornecedorLabel";
            id_fornecedorLabel.Size = new System.Drawing.Size(64, 13);
            id_fornecedorLabel.TabIndex = 9;
            id_fornecedorLabel.Text = "Fornecedor:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(14, 244);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 33);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(108, 244);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 33);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(295, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Location = new System.Drawing.Point(14, 283);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.Size = new System.Drawing.Size(878, 220);
            this.produtosDataGridView.TabIndex = 7;
            this.produtosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.produtosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tamanho";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tamanho";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipo_manga";
            this.dataGridViewTextBoxColumn5.HeaderText = "Manga";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tipo_decote";
            this.dataGridViewTextBoxColumn6.HeaderText = "Decote";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "preco";
            this.dataGridViewTextBoxColumn8.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fornecedores";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(DBPowerLook.DAL.Produtos);
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "cor", true));
            this.corTextBox.Location = new System.Drawing.Point(70, 93);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(100, 20);
            this.corTextBox.TabIndex = 8;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(278, 96);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 9;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(70, 66);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 12;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(278, 126);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 14;
            // 
            // tamanhoTextBox
            // 
            this.tamanhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "tamanho", true));
            this.tamanhoTextBox.Location = new System.Drawing.Point(70, 123);
            this.tamanhoTextBox.Name = "tamanhoTextBox";
            this.tamanhoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tamanhoTextBox.TabIndex = 16;
            // 
            // tipo_decoteTextBox
            // 
            this.tipo_decoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "tipo_decote", true));
            this.tipo_decoteTextBox.Location = new System.Drawing.Point(70, 150);
            this.tipo_decoteTextBox.Name = "tipo_decoteTextBox";
            this.tipo_decoteTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipo_decoteTextBox.TabIndex = 18;
            // 
            // tipo_mangaTextBox
            // 
            this.tipo_mangaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "tipo_manga", true));
            this.tipo_mangaTextBox.Location = new System.Drawing.Point(70, 176);
            this.tipo_mangaTextBox.Name = "tipo_mangaTextBox";
            this.tipo_mangaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipo_mangaTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cadastro de Vestido";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataSource = typeof(DBPowerLook.DAL.Fornecedores);
            // 
            // id_fornecedorComboBox
            // 
            this.id_fornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "id_fornecedor", true));
            this.id_fornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.id_fornecedorComboBox.DisplayMember = "nome_fantasia";
            this.id_fornecedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_fornecedorComboBox.FormattingEnabled = true;
            this.id_fornecedorComboBox.Location = new System.Drawing.Point(278, 65);
            this.id_fornecedorComboBox.Name = "id_fornecedorComboBox";
            this.id_fornecedorComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_fornecedorComboBox.TabIndex = 10;
            this.id_fornecedorComboBox.ValueMember = "id";
            // 
            // Form_cad_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(904, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(tipo_mangaLabel);
            this.Controls.Add(this.tipo_mangaTextBox);
            this.Controls.Add(tipo_decoteLabel);
            this.Controls.Add(this.tipo_decoteTextBox);
            this.Controls.Add(tamanhoLabel);
            this.Controls.Add(this.tamanhoTextBox);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(id_fornecedorLabel);
            this.Controls.Add(this.id_fornecedorComboBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form_cad_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Produtos - Vestidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cad_produto_FormClosed);
            this.Load += new System.EventHandler(this.Form_cad_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox tamanhoTextBox;
        private System.Windows.Forms.TextBox tipo_decoteTextBox;
        private System.Windows.Forms.TextBox tipo_mangaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.ComboBox id_fornecedorComboBox;
    }
}