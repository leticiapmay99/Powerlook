namespace PowerLook_Aluguel
{
    partial class Form_cad_funcionario
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
            System.Windows.Forms.Label tipoUsuarioLabel;
            System.Windows.Forms.Label enderecosLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label numero_casaLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecosComboBox = new System.Windows.Forms.ComboBox();
            this.enderecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.numero_casaTextBox1 = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            enderecosLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            numero_casaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Location = new System.Drawing.Point(41, 147);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(70, 13);
            tipoUsuarioLabel.TabIndex = 32;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // enderecosLabel
            // 
            enderecosLabel.AutoSize = true;
            enderecosLabel.Location = new System.Drawing.Point(415, 152);
            enderecosLabel.Name = "enderecosLabel";
            enderecosLabel.Size = new System.Drawing.Size(61, 13);
            enderecosLabel.TabIndex = 33;
            enderecosLabel.Text = "Enderecos:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(89, 309);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(26, 13);
            rgLabel.TabIndex = 50;
            rgLabel.Text = "RG:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(86, 283);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(30, 13);
            cpfLabel.TabIndex = 49;
            cpfLabel.Text = "CPF:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(77, 257);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "Email:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(8, 232);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(107, 13);
            data_nascimentoLabel.TabIndex = 47;
            data_nascimentoLabel.Text = "Data de Nascimento:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(75, 179);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 46;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(63, 205);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 45;
            telefoneLabel.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(568, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(24, 13);
            label5.TabIndex = 70;
            label5.Text = "UF:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(403, 284);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(74, 13);
            complementoLabel.TabIndex = 63;
            complementoLabel.Text = "Complemento:";
            // 
            // numero_casaLabel1
            // 
            numero_casaLabel1.AutoSize = true;
            numero_casaLabel1.Location = new System.Drawing.Point(426, 257);
            numero_casaLabel1.Name = "numero_casaLabel1";
            numero_casaLabel1.Size = new System.Drawing.Size(50, 13);
            numero_casaLabel1.TabIndex = 62;
            numero_casaLabel1.Text = "Número :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(DBPowerLook.DAL.Usuarios);
            // 
            // tipoUsuarioComboBox
            // 
            this.tipoUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "id_tipo_pessoa", true));
            this.tipoUsuarioComboBox.DataSource = this.tipoUsuarioBindingSource;
            this.tipoUsuarioComboBox.DisplayMember = "name";
            this.tipoUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(117, 144);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoUsuarioComboBox.TabIndex = 33;
            this.tipoUsuarioComboBox.ValueMember = "id";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataSource = typeof(DBPowerLook.DAL.TipoUsuario);
            // 
            // enderecosComboBox
            // 
            this.enderecosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "id_endereco", true));
            this.enderecosComboBox.DataSource = this.enderecosBindingSource;
            this.enderecosComboBox.DisplayMember = "cidade";
            this.enderecosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enderecosComboBox.FormattingEnabled = true;
            this.enderecosComboBox.Location = new System.Drawing.Point(482, 149);
            this.enderecosComboBox.Name = "enderecosComboBox";
            this.enderecosComboBox.Size = new System.Drawing.Size(212, 21);
            this.enderecosComboBox.TabIndex = 34;
            this.enderecosComboBox.ValueMember = "id";
            // 
            // enderecosBindingSource
            // 
            this.enderecosBindingSource.DataSource = typeof(DBPowerLook.DAL.Enderecos);
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.Column3});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(11, 350);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.Size = new System.Drawing.Size(782, 220);
            this.usuariosDataGridView.TabIndex = 34;
            this.usuariosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.usuariosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PessoaFisica";
            this.Column1.HeaderText = "CPF";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PessoaFisica";
            this.Column2.HeaderText = "RG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Nascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Enderecos";
            this.dataGridViewTextBoxColumn11.HeaderText = "Enderecos";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numero_casa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numero Casa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Complemento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TipoUsuario";
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(473, 70);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(286, 70);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 33);
            this.btnGravar.TabIndex = 36;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(192, 70);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 33);
            this.btnNovo.TabIndex = 35;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "PessoaFisica.rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(117, 306);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(78, 20);
            this.rgTextBox.TabIndex = 44;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(117, 254);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(210, 20);
            this.emailTextBox.TabIndex = 42;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariosBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(117, 228);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.data_nascimentoDateTimePicker.TabIndex = 41;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(117, 176);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(210, 20);
            this.nomeTextBox.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "uf", true));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enderecosBindingSource, "uf", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(598, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 20);
            this.textBox4.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Bairro:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "bairro", true));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enderecosBindingSource, "bairro", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(482, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Endereço:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enderecosBindingSource, "endereco", true));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecosBindingSource, "endereco", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(482, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "CEP:";
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(482, 281);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(212, 20);
            this.complementoTextBox.TabIndex = 61;
            // 
            // numero_casaTextBox1
            // 
            this.numero_casaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "numero_casa", true));
            this.numero_casaTextBox1.Location = new System.Drawing.Point(482, 254);
            this.numero_casaTextBox1.Name = "numero_casaTextBox1";
            this.numero_casaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numero_casaTextBox1.TabIndex = 60;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(121, 202);
            this.telefoneMaskedTextBox.Mask = "(99) 99999-9999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(84, 20);
            this.telefoneMaskedTextBox.TabIndex = 72;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "PessoaFisica.cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(117, 277);
            this.cpfMaskedTextBox.Mask = "999.999.999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(88, 20);
            this.cpfMaskedTextBox.TabIndex = 73;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Enderecos.cep", true));
            this.cepMaskedTextBox.Enabled = false;
            this.cepMaskedTextBox.Location = new System.Drawing.Point(482, 179);
            this.cepMaskedTextBox.Mask = "999-999-99";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(66, 20);
            this.cepMaskedTextBox.TabIndex = 74;
            // 
            // Form_cad_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(813, 590);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(complementoLabel);
            this.Controls.Add(this.complementoTextBox);
            this.Controls.Add(numero_casaLabel1);
            this.Controls.Add(this.numero_casaTextBox1);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(enderecosLabel);
            this.Controls.Add(this.enderecosComboBox);
            this.Controls.Add(tipoUsuarioLabel);
            this.Controls.Add(this.tipoUsuarioComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form_cad_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_cad_funcionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cad_funcionario_FormClosed);
            this.Load += new System.EventHandler(this.Form_cad_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
        private System.Windows.Forms.ComboBox enderecosComboBox;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private System.Windows.Forms.BindingSource enderecosBindingSource;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox numero_casaTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
    }
}