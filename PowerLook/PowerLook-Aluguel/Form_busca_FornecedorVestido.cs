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
    public partial class Form_busca_FornecedorVestido : Form
    {
        public Form_busca_FornecedorVestido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buscar((int)comboBox1.SelectedValue);
        }

        private void Form_busca_FornecedorVestido_Load(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.DataSource = DataContextFactory.DataContext.Fornecedores;
        }

        public void buscar(int idFornecedor)
        {
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.id_fornecedor == idFornecedor);
        }

        private void Form_busca_FornecedorVestido_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormFornecedorVestidos = null;
        }
    }
}
