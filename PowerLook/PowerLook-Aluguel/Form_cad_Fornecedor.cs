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


        private void Form_cad_Fornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormFornecedor = null;
        }


        public Fornecedores PessoaCorrente
        {
            get
            {
                return (Fornecedores)this.fornecedoresBindingSource.Current;
            }
        }

        public Fornecedores FornecedoresCorrente
        {
            get
            {
                return (Fornecedores)this.fornecedoresBindingSource.Current;
            }
        }

        private void Form_cad_Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'powerLookDataSet.Enderecos'. Você pode movê-la ou removê-la conforme necessário.
            this.enderecosTableAdapter.Fill(this.powerLookDataSet.Enderecos);
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
            if (this.Valida())
            {
                this.fornecedoresBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                fornecedoresDataGridView.Refresh();
                MessageBox.Show("Fornecedor Cadastrado com sucesso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.CancelEdit();
            this.Dispose();
            MeusFormularios.FormFornecedor = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.AddNew();
            this.PessoaCorrente.PessoaJurifica = new PessoaJurifica();
            nome_fantasiaTextBox.Focus();
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

    
 
        private bool FornecedorPossuiProduto(Fornecedores fornecedores)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.id_fornecedor == fornecedores.id);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }



        private bool Valida()
        {
            if (nome_fantasiaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatório");
                nome_fantasiaTextBox.Focus();
                return false;
            }
            if (cnpjMaskedTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo CNPJ é obrigatório");
                cnpjMaskedTextBox.Focus();
                return false;
            }
            if (inscricao_estadualTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Incrição Estadual é obrigatório");
                inscricao_estadualTextBox.Focus();
                return false;
            }
            if (razao_socialTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Razão Social é obrigatório");
                razao_socialTextBox.Focus();
                return false;
            }
            if (emailTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Email é obrigatório");
                emailTextBox.Focus();
                return false;
            }
            if (telefoneMaskedTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Telefone é obrigatório");
                telefoneMaskedTextBox.Focus();
                return false;
            }
            if (id_enderecoComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Endereço é obrigatório");
                id_enderecoComboBox.Focus();
                return false;
            }
            if (numero_casaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Número é obrigatório");
                numero_casaTextBox.Focus();
                return false;
            }
            if (complementoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Complemento é obrigatório");
                complementoTextBox.Focus();
                return false;
            }

            return true;
        }

        private void id_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

          