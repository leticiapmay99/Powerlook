using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLook_Aluguel
{
    public partial class Form_relatorio_fornecedor : Form
    {
        public Form_relatorio_fornecedor()
        {
            InitializeComponent();
        }

        private void Form_relatorio_fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutosTableAdapter.Fill(this.PowerLookDataSet.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.FornecedorRelatorio'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedorRelatorioTableAdapter.Fill(this.PowerLookDataSet.FornecedorRelatorio);

            this.reportViewer1.RefreshReport();
        }

        private void Form_relatorio_fornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatoriosFornecedor = null;
        }
    }
}
