using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBPowerLook.DAL;

namespace PowerLook_Aluguel
{
    public partial class Form_cad_produto : Form
    {
        public Form_cad_produto()
        {
            InitializeComponent();
        }

        private void Form_cad_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void Form_cad_produto_Load(object sender, EventArgs e)
        {
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.fornecedoresBindingSource.DataSource = DataContextFactory.DataContext.Fornecedores;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            produtosDataGridView.Refresh();
            MessageBox.Show("Produto Cadastrado com sucesso");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.produtosBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Produto Excluido com sucesso");
            }
        }

        private void produtosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 8)
            {
                e.Value = ((Fornecedores)e.Value).nome_fantasia;
            }
        }

        private void produtosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
