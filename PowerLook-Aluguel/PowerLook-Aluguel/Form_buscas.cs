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
    public partial class Form_buscas : Form
    {
        public Form_buscas()
        {
            InitializeComponent();
        }

        private void Form_buscas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormBuscas = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoriaVestidos == null)
                MeusFormularios.FormCategoriaVestidos = new Form_busca_CategoriaVestido();

            MeusFormularios.FormCategoriaVestidos.Show();
            MeusFormularios.FormCategoriaVestidos.Focus();
        }
    }
}
