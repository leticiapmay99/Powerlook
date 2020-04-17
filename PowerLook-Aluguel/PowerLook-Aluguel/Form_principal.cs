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
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void btnVestido_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new Form_cad_produto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void vestidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new Form_cad_produto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFornecedor == null)
                MeusFormularios.FormFornecedor = new Form_cad_Fornecedor();

            MeusFormularios.FormFornecedor.Show();
            MeusFormularios.FormFornecedor.Focus();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFornecedor == null)
                MeusFormularios.FormFornecedor = new Form_cad_Fornecedor();

            MeusFormularios.FormFornecedor.Show();
            MeusFormularios.FormFornecedor.Focus();
        }
    }
}
