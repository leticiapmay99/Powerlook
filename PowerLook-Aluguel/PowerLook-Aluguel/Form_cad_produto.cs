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
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {   
                this.produtosBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                produtosDataGridView.Refresh();
                MessageBox.Show("Produto Cadastrado com sucesso");
            }
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
            if (e.Value != null && e.ColumnIndex == 9)
            {
                e.Value = ((Fornecedores)e.Value).nome_fantasia;
            }

            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((Categorias)e.Value).nome;
            }
        }
        private bool Valida()
        {
            if (nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatório");
                nomeTextBox.Focus();
                return false;
            }
            if (tamanhoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Tamanho é obrigatório");
                tamanhoTextBox.Focus();
                return false;
            }
            if (precoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Preço é obrigatório");
                precoTextBox.Focus();
                return false;
            }
            if (id_categoriaComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Categoria é obrigatório");
                id_categoriaComboBox.Focus();
                return false;
            }
            if (id_fornecedorComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Fornecedor é obrigatório");
                id_fornecedorComboBox.Focus();
                return false;
            }

            if (quantidadeTextBox.Text.Trim() == string.Empty || quantidadeTextBox.Text == "0")
            {
                MessageBox.Show("O campo Quantidade é obrigatório \nOu deve ser maior que '0'");
                quantidadeTextBox.Focus();
                return false;
            }

            return true;
        }
    }
}
