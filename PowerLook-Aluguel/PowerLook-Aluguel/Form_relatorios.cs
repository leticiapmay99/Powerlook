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
    public partial class Form_relatorios : Form
    {
        public Form_relatorios()
        {
            InitializeComponent();
        }

        private void Form_relatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorios = null;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosProduto == null)
                MeusFormularios.FormRelatoriosProduto = new Form_relatorio_produto();

            MeusFormularios.FormRelatoriosProduto.Show();
            MeusFormularios.FormRelatoriosProduto.Focus();
        }
    }
}
