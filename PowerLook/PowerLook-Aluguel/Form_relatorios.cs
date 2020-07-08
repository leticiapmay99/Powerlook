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
    public partial class Form_relatorios : Form
    {
        public Form_relatorios()
        {
            InitializeComponent();
        }

        private void Form_relatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorios = null;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosProduto == null)
                MeusFormularios.FormRelatoriosProduto = new Form_relatorio_produto();

            MeusFormularios.FormRelatoriosProduto.Show();
            MeusFormularios.FormRelatoriosProduto.Focus();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosCliente == null)
                MeusFormularios.FormRelatoriosCliente = new Form_relatorio_cliente();

            MeusFormularios.FormRelatoriosCliente.Show();
            MeusFormularios.FormRelatoriosCliente.Focus();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosFornecedor == null)
                MeusFormularios.FormRelatoriosFornecedor = new Form_relatorio_fornecedor();

            MeusFormularios.FormRelatoriosFornecedor.Show();
            MeusFormularios.FormRelatoriosFornecedor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosVenda == null)
                MeusFormularios.FormRelatoriosVenda = new Form_relatorio_venda();

            MeusFormularios.FormRelatoriosVenda.Show();
            MeusFormularios.FormRelatoriosVenda.Focus();
        }
    }
}
