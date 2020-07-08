namespace PowerLook_Aluguel
{
    partial class Form_relatorio_fornecedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PowerLookDataSet = new PowerLook_Aluguel.PowerLookDataSet();
            this.FornecedorRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutosTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.ProdutosTableAdapter();
            this.FornecedorRelatorioTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.FornecedorRelatorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedorRelatorioBindingSource)).BeginInit();
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
            // FornecedorRelatorioBindingSource
            // 
            this.FornecedorRelatorioBindingSource.DataMember = "FornecedorRelatorio";
            this.FornecedorRelatorioBindingSource.DataSource = this.PowerLookDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "produto";
            reportDataSource1.Value = this.ProdutosBindingSource;
            reportDataSource2.Name = "Fornecedor";
            reportDataSource2.Value = this.FornecedorRelatorioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PowerLook_Aluguel.Fornecedor.rdlc";
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
            // FornecedorRelatorioTableAdapter
            // 
            this.FornecedorRelatorioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_relatorio_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_relatorio_fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_relatorio_fornecedor_FormClosed);
            this.Load += new System.EventHandler(this.Form_relatorio_fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedorRelatorioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private PowerLookDataSet PowerLookDataSet;
        private System.Windows.Forms.BindingSource FornecedorRelatorioBindingSource;
        private PowerLookDataSetTableAdapters.ProdutosTableAdapter ProdutosTableAdapter;
        private PowerLookDataSetTableAdapters.FornecedorRelatorioTableAdapter FornecedorRelatorioTableAdapter;
    }
}