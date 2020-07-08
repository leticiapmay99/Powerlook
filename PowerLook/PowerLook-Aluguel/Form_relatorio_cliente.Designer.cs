namespace PowerLook_Aluguel
{
    partial class Form_relatorio_cliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PowerLookDataSet = new PowerLook_Aluguel.PowerLookDataSet();
            this.FornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutosTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.ProdutosTableAdapter();
            this.FornecedoresTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.FornecedoresTableAdapter();
            this.ClienteRelatorioTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.ClienteRelatorioTableAdapter();
            this.Cliente2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cliente2TableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.Cliente2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteRelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosBindingSource
            // 
            this.ProdutosBindingSource.DataMember = "Produtos";
            this.ProdutosBindingSource.DataSource = this.PowerLookDataSet;
            // 
            // PowerLookDataSet
            // 
            this.PowerLookDataSet.DataSetName = "PowerLookDataSet";
            this.PowerLookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FornecedoresBindingSource
            // 
            this.FornecedoresBindingSource.DataMember = "Fornecedores";
            this.FornecedoresBindingSource.DataSource = this.PowerLookDataSet;
            // 
            // ClienteRelatorioBindingSource
            // 
            this.ClienteRelatorioBindingSource.DataMember = "ClienteRelatorio";
            this.ClienteRelatorioBindingSource.DataSource = this.PowerLookDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cliente2";
            reportDataSource1.Value = this.Cliente2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PowerLook_Aluguel.Cliente2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // FornecedoresTableAdapter
            // 
            this.FornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteRelatorioTableAdapter
            // 
            this.ClienteRelatorioTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente2BindingSource
            // 
            this.Cliente2BindingSource.DataMember = "Cliente2";
            this.Cliente2BindingSource.DataSource = this.PowerLookDataSet;
            // 
            // Cliente2TableAdapter
            // 
            this.Cliente2TableAdapter.ClearBeforeFill = true;
            // 
            // Form_relatorio_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_relatorio_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_relatorio_cliente_FormClosed);
            this.Load += new System.EventHandler(this.Form_relatorio_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteRelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private PowerLookDataSet PowerLookDataSet;
        private System.Windows.Forms.BindingSource FornecedoresBindingSource;
        private System.Windows.Forms.BindingSource ClienteRelatorioBindingSource;
        private PowerLookDataSetTableAdapters.ProdutosTableAdapter ProdutosTableAdapter;
        private PowerLookDataSetTableAdapters.FornecedoresTableAdapter FornecedoresTableAdapter;
        private PowerLookDataSetTableAdapters.ClienteRelatorioTableAdapter ClienteRelatorioTableAdapter;
        private System.Windows.Forms.BindingSource Cliente2BindingSource;
        private PowerLookDataSetTableAdapters.Cliente2TableAdapter Cliente2TableAdapter;
    }
}