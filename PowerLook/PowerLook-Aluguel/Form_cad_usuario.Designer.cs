namespace PowerLook_Aluguel
{
    partial class Form_cad_usuario
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
            System.Windows.Forms.Label id_tipoLoginLabel;
            System.Windows.Forms.Label login1Label;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataGridView = new System.Windows.Forms.DataGridView();
            this.id_tipoLoginComboBox = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login1TextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.id_funcionarioComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_tipoLoginLabel = new System.Windows.Forms.Label();
            login1Label = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_tipoLoginLabel
            // 
            id_tipoLoginLabel.AutoSize = true;
            id_tipoLoginLabel.Location = new System.Drawing.Point(36, 71);
            id_tipoLoginLabel.Name = "id_tipoLoginLabel";
            id_tipoLoginLabel.Size = new System.Drawing.Size(68, 13);
            id_tipoLoginLabel.TabIndex = 29;
            id_tipoLoginLabel.Text = "Tipo usuário:";
            // 
            // login1Label
            // 
            login1Label.AutoSize = true;
            login1Label.Location = new System.Drawing.Point(296, 44);
            login1Label.Name = "login1Label";
            login1Label.Size = new System.Drawing.Size(36, 13);
            login1Label.TabIndex = 30;
            login1Label.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(293, 74);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 31;
            senhaLabel.Text = "Senha:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(38, 44);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(65, 13);
            id_funcionarioLabel.TabIndex = 32;
            id_funcionarioLabel.Text = "Funcionário:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(152, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 104);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(362, 39);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(43, 39);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 33);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(150, 39);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 33);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(DBPowerLook.DAL.Login);
            // 
            // loginDataGridView
            // 
            this.loginDataGridView.AllowUserToAddRows = false;
            this.loginDataGridView.AllowUserToDeleteRows = false;
            this.loginDataGridView.AutoGenerateColumns = false;
            this.loginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Column2});
            this.loginDataGridView.DataSource = this.loginBindingSource;
            this.loginDataGridView.Location = new System.Drawing.Point(118, 357);
            this.loginDataGridView.Name = "loginDataGridView";
            this.loginDataGridView.ReadOnly = true;
            this.loginDataGridView.Size = new System.Drawing.Size(537, 220);
            this.loginDataGridView.TabIndex = 29;
            this.loginDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.loginDataGridView_CellFormatting);
            // 
            // id_tipoLoginComboBox
            // 
            this.id_tipoLoginComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginBindingSource, "id_tipoLogin", true));
            this.id_tipoLoginComboBox.DataSource = this.tipoUsuarioBindingSource;
            this.id_tipoLoginComboBox.DisplayMember = "name";
            this.id_tipoLoginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_tipoLoginComboBox.FormattingEnabled = true;
            this.id_tipoLoginComboBox.Location = new System.Drawing.Point(109, 68);
            this.id_tipoLoginComboBox.Name = "id_tipoLoginComboBox";
            this.id_tipoLoginComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_tipoLoginComboBox.TabIndex = 30;
            this.id_tipoLoginComboBox.ValueMember = "id";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataSource = typeof(DBPowerLook.DAL.TipoUsuario);
            // 
            // login1TextBox
            // 
            this.login1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "login1", true));
            this.login1TextBox.Location = new System.Drawing.Point(338, 41);
            this.login1TextBox.Name = "login1TextBox";
            this.login1TextBox.Size = new System.Drawing.Size(100, 20);
            this.login1TextBox.TabIndex = 31;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(338, 71);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 32;
            // 
            // id_funcionarioComboBox
            // 
            this.id_funcionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginBindingSource, "id_funcionario", true));
            this.id_funcionarioComboBox.DataSource = this.usuariosBindingSource;
            this.id_funcionarioComboBox.DisplayMember = "nome";
            this.id_funcionarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_funcionarioComboBox.FormattingEnabled = true;
            this.id_funcionarioComboBox.Location = new System.Drawing.Point(109, 40);
            this.id_funcionarioComboBox.Name = "id_funcionarioComboBox";
            this.id_funcionarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_funcionarioComboBox.TabIndex = 33;
            this.id_funcionarioComboBox.ValueMember = "id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(DBPowerLook.DAL.Usuarios);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_tipoLoginComboBox);
            this.groupBox1.Controls.Add(id_funcionarioLabel);
            this.groupBox1.Controls.Add(id_tipoLoginLabel);
            this.groupBox1.Controls.Add(this.id_funcionarioComboBox);
            this.groupBox1.Controls.Add(this.login1TextBox);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(login1Label);
            this.groupBox1.Controls.Add(this.senhaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(152, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 121);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuário";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "senha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TipoUsuario";
            this.Column1.HeaderText = "Tipo Usuário";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Usuarios";
            this.Column2.HeaderText = "Funcionário";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form_cad_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form_cad_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cad_usuario_FormClosed);
            this.Load += new System.EventHandler(this.Form_cad_usuario_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.DataGridView loginDataGridView;
        private System.Windows.Forms.ComboBox id_tipoLoginComboBox;
        private System.Windows.Forms.TextBox login1TextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox id_funcionarioComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}