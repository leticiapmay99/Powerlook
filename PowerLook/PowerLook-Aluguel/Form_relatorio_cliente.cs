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
    public partial class Form_relatorio_cliente : Form
    {
        public Form_relatorio_cliente()
        {
            InitializeComponent();
        }

        private void Form_relatorio_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Cliente2'. Você pode movê-la ou removê-la conforme necessário.
            this.Cliente2TableAdapter.Fill(this.PowerLookDataSet.Cliente2);
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutosTableAdapter.Fill(this.PowerLookDataSet.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedoresTableAdapter.Fill(this.PowerLookDataSet.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.ClienteRelatorio'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteRelatorioTableAdapter.Fill(this.PowerLookDataSet.ClienteRelatorio);

            this.reportViewer1.RefreshReport();
        }

        private void Form_relatorio_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatoriosCliente = null;
        }
    }
}
