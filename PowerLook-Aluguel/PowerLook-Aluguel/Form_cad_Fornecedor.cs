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
    public partial class Form_cad_Fornecedor : Form
    {
        public Form_cad_Fornecedor()
        {
            InitializeComponent();
        }
        
        public Fornecedores PessoaCorrente
        {
            get
            {
                return (Fornecedores)this.fornecedoresBindingSource.Current;
            }
        }

        private void Form_cad_Fornecedor_Load(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.DataSource = DataContextFactory.DataContext.Fornecedores;
            this.enderecosBindingSource.DataSource = DataContextFactory.DataContext.Enderecos;

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.FornecedorPossuiProduto(this.FornecedoresCorrente))
                    MessageBox.Show("Você não pode excluir este fornecedor");
                else
                {
                    this.fornecedoresBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Fornecedor Excluido com sucesso");
                }
            } 
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            fornecedoresDataGridView.Refresh();
            MessageBox.Show("Fornecedor Cadastrado com sucesso");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.AddNew();
            this.PessoaCorrente.PessoaJurifica = new PessoaJurifica();
        }

        private void fornecedoresDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
            if (e.Value != null && e.ColumnIndex == 2)
            {
                e.Value = ((PessoaJurifica)e.Value).cnpj;
            }
            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((PessoaJurifica)e.Value).inscricao_estadual;
            }
            if (e.Value != null && e.ColumnIndex == 4)
            {
                e.Value = ((PessoaJurifica)e.Value).razao_social;
            }

            if (e.Value != null && e.ColumnIndex == 7)
            {
                e.Value = ((Enderecos)e.Value).cidade;
            }

        }

        private void Form_cad_Fornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormFornecedor = null;
        }
           
        public Fornecedores FornecedoresCorrente { 
        get
            {
                return (Fornecedores) this.fornecedoresBindingSource.Current;
            }
        }

        private bool FornecedorPossuiProduto(Fornecedores fornecedores)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.id_fornecedor == fornecedores.id);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        } 
    }
}

          