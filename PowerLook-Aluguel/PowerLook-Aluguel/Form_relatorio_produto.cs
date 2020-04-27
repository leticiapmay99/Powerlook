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
    public partial class Form_relatorio_produto : Form
    {
        public Form_relatorio_produto()
        {
            InitializeComponent();
        }

        private void Form_relatorio_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatoriosProduto = null;
        }

        private void Form_relatorio_produto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedoresTableAdapter.Fill(this.PowerLookDataSet.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutosTableAdapter.Fill(this.PowerLookDataSet.Produtos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
