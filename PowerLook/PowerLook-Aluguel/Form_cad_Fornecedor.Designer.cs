﻿namespace PowerLook_Aluguel
{
    partial class Form_cad_Fornecedor
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
            System.Windows.Forms.Label id_enderecoLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nome_fantasiaLabel;
            System.Windows.Forms.Label numero_casaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label inscricao_estadualLabel;
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label cidadeLabel;
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_enderecoComboBox = new System.Windows.Forms.ComboBox();
            this.enderecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nome_fantasiaTextBox = new System.Windows.Forms.TextBox();
            this.numero_casaTextBox = new System.Windows.Forms.TextBox();
            this.inscricao_estadualTextBox = new System.Windows.Forms.TextBox();
            this.razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pessoaJurificaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.powerLookDataSet = new PowerLook_Aluguel.PowerLookDataSet();
            this.enderecosTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.EnderecosTableAdapter();
            this.tableAdapterManager = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.TableAdapterManager();
            id_enderecoLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nome_fantasiaLabel = new System.Windows.Forms.Label();
            numero_casaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            inscricao_estadualLabel = new System.Windows.Forms.Label();
            razao_socialLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaJurificaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerLookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_enderecoLabel
            // 
            id_enderecoLabel.AutoSize = true;
            id_enderecoLabel.Location = new System.Drawing.Point(440, 39);
            id_enderecoLabel.Name = "id_enderecoLabel";
            id_enderecoLabel.Size = new System.Drawing.Size(31, 13);
            id_enderecoLabel.TabIndex = 1;
            id_enderecoLabel.Text = "CEP:";
            id_enderecoLabel.Click += new System.EventHandler(this.id_enderecoLabel_Click);
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(403, 177);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(74, 13);
            complementoLabel.TabIndex = 3;
            complementoLabel.Text = "Complemento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(94, 148);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail:";
            // 
            // nome_fantasiaLabel
            // 
            nome_fantasiaLabel.AutoSize = true;
            nome_fantasiaLabel.Location = new System.Drawing.Point(50, 44);
            nome_fantasiaLabel.Name = "nome_fantasiaLabel";
            nome_fantasiaLabel.Size = new System.Drawing.Size(81, 13);
            nome_fantasiaLabel.TabIndex = 7;
            nome_fantasiaLabel.Text = "Nome Fantasia:";
            // 
            // numero_casaLabel
            // 
            numero_casaLabel.AutoSize = true;
            numero_casaLabel.Location = new System.Drawing.Point(430, 152);
            numero_casaLabel.Name = "numero_casaLabel";
            numero_casaLabel.Size = new System.Drawing.Size(47, 13);
            numero_casaLabel.TabIndex = 9;
            numero_casaLabel.Text = "Número:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(80, 174);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone:";
            // 
            // inscricao_estadualLabel
            // 
            inscricao_estadualLabel.AutoSize = true;
            inscricao_estadualLabel.Location = new System.Drawing.Point(34, 97);
            inscricao_estadualLabel.Name = "inscricao_estadualLabel";
            inscricao_estadualLabel.Size = new System.Drawing.Size(97, 13);
            inscricao_estadualLabel.TabIndex = 15;
            inscricao_estadualLabel.Text = "Inscrição Estadual:";
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(58, 123);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(73, 13);
            razao_socialLabel.TabIndex = 17;
            razao_socialLabel.Text = "Razão Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(611, 66);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(24, 13);
            label5.TabIndex = 38;
            label5.Text = "UF:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(94, 70);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 13;
            cnpjLabel.Text = "CNPJ:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(435, 66);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 39;
            cidadeLabel.Text = "Cidade:";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataSource = typeof(DBPowerLook.DAL.Fornecedores);
            // 
            // fornecedoresDataGridView
            // 
            this.fornecedoresDataGridView.AllowUserToAddRows = false;
            this.fornecedoresDataGridView.AllowUserToDeleteRows = false;
            this.fornecedoresDataGridView.AutoGenerateColumns = false;
            this.fornecedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.fornecedoresDataGridView.DataSource = this.fornecedoresBindingSource;
            this.fornecedoresDataGridView.Location = new System.Drawing.Point(26, 429);
            this.fornecedoresDataGridView.Name = "fornecedoresDataGridView";
            this.fornecedoresDataGridView.ReadOnly = true;
            this.fornecedoresDataGridView.Size = new System.Drawing.Size(762, 220);
            this.fornecedoresDataGridView.TabIndex = 1;
            this.fornecedoresDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.fornecedoresDataGridView_CellFormatting);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_fantasia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Fantasia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PessoaJurifica";
            this.Column1.HeaderText = "CNPJ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PessoaJurifica";
            this.Column2.HeaderText = "Incrição Estadual";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PessoaJurifica";
            this.Column3.HeaderText = "Razão Social";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Enderecos";
            this.dataGridViewTextBoxColumn9.HeaderText = "Enderecos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numero_casa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Complemento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // id_enderecoComboBox
            // 
            this.id_enderecoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "id_endereco", true));
            this.id_enderecoComboBox.DataSource = this.enderecosBindingSource;
            this.id_enderecoComboBox.DisplayMember = "cep";
            this.id_enderecoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_enderecoComboBox.FormattingEnabled = true;
            this.id_enderecoComboBox.Location = new System.Drawing.Point(483, 36);
            this.id_enderecoComboBox.Name = "id_enderecoComboBox";
            this.id_enderecoComboBox.Size = new System.Drawing.Size(237, 21);
            this.id_enderecoComboBox.TabIndex = 7;
            this.id_enderecoComboBox.ValueMember = "id";
            // 
            // enderecosBindingSource
            // 
            this.enderecosBindingSource.DataSource = typeof(DBPowerLook.DAL.Enderecos);
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(483, 174);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(237, 20);
            this.complementoTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 145);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // nome_fantasiaTextBox
            // 
            this.nome_fantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nome_fantasia", true));
            this.nome_fantasiaTextBox.Location = new System.Drawing.Point(137, 41);
            this.nome_fantasiaTextBox.Name = "nome_fantasiaTextBox";
            this.nome_fantasiaTextBox.Size = new System.Drawing.Size(237, 20);
            this.nome_fantasiaTextBox.TabIndex = 1;
            // 
            // numero_casaTextBox
            // 
            this.numero_casaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "numero_casa", true));
            this.numero_casaTextBox.Location = new System.Drawing.Point(483, 148);
            this.numero_casaTextBox.Name = "numero_casaTextBox";
            this.numero_casaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numero_casaTextBox.TabIndex = 8;
            // 
            // inscricao_estadualTextBox
            // 
            this.inscricao_estadualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "PessoaJurifica.inscricao_estadual", true));
            this.inscricao_estadualTextBox.Location = new System.Drawing.Point(137, 93);
            this.inscricao_estadualTextBox.Name = "inscricao_estadualTextBox";
            this.inscricao_estadualTextBox.Size = new System.Drawing.Size(107, 20);
            this.inscricao_estadualTextBox.TabIndex = 3;
            // 
            // razao_socialTextBox
            // 
            this.razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "PessoaJurifica.razao_social", true));
            this.razao_socialTextBox.Location = new System.Drawing.Point(137, 119);
            this.razao_socialTextBox.Name = "razao_socialTextBox";
            this.razao_socialTextBox.Size = new System.Drawing.Size(107, 20);
            this.razao_socialTextBox.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "uf", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(641, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 20);
            this.textBox4.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Bairro:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "bairro", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(483, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Endereço:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "endereco", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(483, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 34;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(350, 34);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(135, 34);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 33);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(28, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 33);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // pessoaJurificaBindingSource
            // 
            this.pessoaJurificaBindingSource.DataSource = typeof(DBPowerLook.DAL.PessoaJurifica);
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(137, 170);
            this.telefoneMaskedTextBox.Mask = "(99) 9999-9999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(107, 20);
            this.telefoneMaskedTextBox.TabIndex = 6;
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "PessoaJurifica.cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(137, 67);
            this.cnpjMaskedTextBox.Mask = "99.999.999/9999-99";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(107, 20);
            this.cnpjMaskedTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(this.razao_socialTextBox);
            this.groupBox1.Controls.Add(this.cnpjMaskedTextBox);
            this.groupBox1.Controls.Add(this.id_enderecoComboBox);
            this.groupBox1.Controls.Add(id_enderecoLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(this.complementoTextBox);
            this.groupBox1.Controls.Add(complementoLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.nome_fantasiaTextBox);
            this.groupBox1.Controls.Add(nome_fantasiaLabel);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.numero_casaTextBox);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(numero_casaLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(cnpjLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inscricao_estadualTextBox);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(inscricao_estadualLabel);
            this.groupBox1.Controls.Add(razao_socialLabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 219);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Fornecedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "cidade", true));
            this.cidadeTextBox.Enabled = false;
            this.cidadeTextBox.Location = new System.Drawing.Point(483, 63);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(173, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 93);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // powerLookDataSet
            // 
            this.powerLookDataSet.DataSetName = "PowerLookDataSet";
            this.powerLookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecosTableAdapter
            // 
            this.enderecosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContasReceberTableAdapter = null;
            this.tableAdapterManager.EnderecosTableAdapter = this.enderecosTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.LocacoesTableAdapter = null;
            this.tableAdapterManager.PessoaFisicaTableAdapter = null;
            this.tableAdapterManager.PessoaJurificaTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.StatusPagamentoTableAdapter = null;
            this.tableAdapterManager.TipoUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PowerLook_Aluguel.PowerLookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // Form_cad_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(817, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fornecedoresDataGridView);
            this.Name = "Form_cad_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cad_Fornecedor_FormClosed);
            this.Load += new System.EventHandler(this.Form_cad_Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaJurificaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.powerLookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.DataGridView fornecedoresDataGridView;
        private System.Windows.Forms.ComboBox id_enderecoComboBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nome_fantasiaTextBox;
        private System.Windows.Forms.TextBox numero_casaTextBox;
        private System.Windows.Forms.TextBox inscricao_estadualTextBox;
        private System.Windows.Forms.TextBox razao_socialTextBox;
        private System.Windows.Forms.BindingSource enderecosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pessoaJurificaBindingSource;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private PowerLookDataSet powerLookDataSet;
        private PowerLookDataSetTableAdapters.EnderecosTableAdapter enderecosTableAdapter;
        private PowerLookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cidadeTextBox;
    }
}