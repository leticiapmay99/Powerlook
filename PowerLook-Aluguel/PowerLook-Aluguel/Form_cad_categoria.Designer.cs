namespace PowerLook_Aluguel
{
    partial class Form_cad_categoria
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
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label nomeLabel;
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.AllowUserToDeleteRows = false;
            this.categoriasDataGridView.AutoGenerateColumns = false;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoriasDataGridView.DataSource = this.categoriasBindingSource;
            this.categoriasDataGridView.Location = new System.Drawing.Point(233, 231);
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.ReadOnly = true;
            this.categoriasDataGridView.Size = new System.Drawing.Size(290, 220);
            this.categoriasDataGridView.TabIndex = 0;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(DBPowerLook.DAL.Categorias);
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(171, 199);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel.TabIndex = 1;
            descriçãoLabel.Text = "Descrição:";
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(233, 196);
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriçãoTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(194, 168);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(236, 165);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(422, 98);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(330, 98);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 33);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(236, 98);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 33);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descrição";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Categoria";
            // 
            // Form_cad_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(this.categoriasDataGridView);
            this.Name = "Form_cad_categoria";
            this.Text = "Categoria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cad_categoria_FormClosed);
            this.Load += new System.EventHandler(this.Form_cad_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}