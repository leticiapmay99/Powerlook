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

        private void Form_cad_categoria_Load(object sender, EventArgs e)
        {
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;

        }

        private void Form_cad_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCliente = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriasBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.categoriasBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            categoriasDataGridView.Refresh();
            MessageBox.Show("Categoria Cadastrada com sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.categoriasBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Excluida com sucesso");
            }
        }
    }
}
