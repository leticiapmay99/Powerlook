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
    public partial class Form_relatorio_produto : Form
    {
        public Form_relatorio_produto()
        {
            InitializeComponent();
        }

        private void Form_relatorio_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatoriosProduto = null;
        }

        private void Form_relatorio_produto_Load(object sender, EventArgs e)
        {

        }
    }
}
