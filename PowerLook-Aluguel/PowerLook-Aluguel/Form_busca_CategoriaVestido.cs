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
    public partial class Form_busca_CategoriaVestido : Form
    {
        public Form_busca_CategoriaVestido()
        {
            InitializeComponent();
        }

        private void Form_busca_CategoriaVestido_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoriaVestidos = null;
        }

        private void Form_busca_CategoriaVestido_Load(object sender, EventArgs e)
        {
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buscar((int)comboBox1.SelectedValue);
        }

        public void buscar(int idCategoria)
        {
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.id_categoria == idCategoria);
        }
    }
}
