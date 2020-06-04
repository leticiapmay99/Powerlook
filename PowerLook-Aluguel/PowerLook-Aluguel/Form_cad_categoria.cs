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
    public partial class Form_cad_categoria : Form
    {
        public Form_cad_categoria()
        {
            InitializeComponent();
        }

        private void Form_cad_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria= null;
        }

        private void Form_cad_categoria_Load(object sender, EventArgs e)
        {
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;

        }


        private bool Valida()
        {
            if ( nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório");
                nomeTextBox.Focus();
                return false;
            }
            return true;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriasBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriasBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                categoriasDataGridView.Refresh();
                MessageBox.Show("Categoria Cadastrada com sucesso");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.CategoriaCorrente))
                    MessageBox.Show("VocÊ não pode excluir uma categoria que possui produto");
                else
                {
                    this.categoriasBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluida com sucesso");
                }
            }
        }

        public Categorias CategoriaCorrente
        {
            get
            {
                return (Categorias)this.categoriasBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categorias categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.id_categoria == categoria.id);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }

        private void descriçãoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
