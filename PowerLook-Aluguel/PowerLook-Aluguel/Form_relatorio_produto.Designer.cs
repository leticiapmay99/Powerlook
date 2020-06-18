namespace PowerLook_Aluguel
{
    partial class Form_relatorio_produto
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
            this.FornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdutosTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.ProdutosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FornecedoresTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.FornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).BeginInit();
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
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "produto";
            reportDataSource1.Value = this.ProdutosBindingSource;
            reportDataSource2.Name = "Fornecedor";
            reportDataSource2.Value = this.FornecedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PowerLook_Aluguel.Produto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FornecedoresTableAdapter
            // 
            this.FornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Form_relatorio_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_relatorio_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_relatorio_produto_FormClosed);
            this.Load += new System.EventHandler(this.Form_relatorio_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private PowerLookDataSet PowerLookDataSet;
        private PowerLookDataSetTableAdapters.ProdutosTableAdapter ProdutosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FornecedoresBindingSource;
        private PowerLookDataSetTableAdapters.FornecedoresTableAdapter FornecedoresTableAdapter;
    }
}