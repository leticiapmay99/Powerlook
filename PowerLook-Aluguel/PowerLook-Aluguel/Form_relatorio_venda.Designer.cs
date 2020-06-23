namespace PowerLook_Aluguel
{
    partial class Form_relatorio_venda
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
            this.VendasSimplesRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PowerLookDataSet = new PowerLook_Aluguel.PowerLookDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VendasSimplesRelatorioTableAdapter = new PowerLook_Aluguel.PowerLookDataSetTableAdapters.VendasSimplesRelatorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VendasSimplesRelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VendasSimplesRelatorioBindingSource
            // 
            this.VendasSimplesRelatorioBindingSource.DataMember = "VendasSimplesRelatorio";
            this.VendasSimplesRelatorioBindingSource.DataSource = this.PowerLookDataSet;
            // 
            // PowerLookDataSet
            // 
            this.PowerLookDataSet.DataSetName = "PowerLookDataSet";
            this.PowerLookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VendasSimples";
            reportDataSource1.Value = this.VendasSimplesRelatorioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PowerLook_Aluguel.Vendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendasSimplesRelatorioTableAdapter
            // 
            this.VendasSimplesRelatorioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_relatorio_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_relatorio_venda";
            this.Text = "Relatório Vendas Simples";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_relatorio_venda_FormClosed);
            this.Load += new System.EventHandler(this.Form_relatorio_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendasSimplesRelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerLookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendasSimplesRelatorioBindingSource;
        private PowerLookDataSet PowerLookDataSet;
        private PowerLookDataSetTableAdapters.VendasSimplesRelatorioTableAdapter VendasSimplesRelatorioTableAdapter;
    }
}