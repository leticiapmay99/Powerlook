using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aluguel_PowerLook
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MeusFormularios.FormCadCliente == null)
                MeusFormularios.FormCadCliente = new Form_cad_cliente();

            MeusFormularios.FormCadCliente.Show();
            MeusFormularios.FormCadCliente.Focus();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadFornecedor == null)
                MeusFormularios.FormCadFornecedor = new Form_cad_fornecedor();

            MeusFormularios.FormCadFornecedor.Show();
            MeusFormularios.FormCadFornecedor.Focus();
        }

        private void vestidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadVestido == null)
                MeusFormularios.FormCadVestido = new Form_cad_vestido();

            MeusFormularios.FormCadVestido.Show();
            MeusFormularios.FormCadVestido.Focus();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadFuncionario == null)
                MeusFormularios.FormCadFuncionario = new Form_cad_funcionario();

            MeusFormularios.FormCadFuncionario.Show();
            MeusFormularios.FormCadFuncionario.Focus();
        }

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadCliente == null)
                MeusFormularios.FormCadCliente = new Form_cad_cliente();

            MeusFormularios.FormCadCliente.Show();
            MeusFormularios.FormCadCliente.Focus();
        }

        private void btn_cadFornecedor_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadFornecedor == null)
                MeusFormularios.FormCadFornecedor = new Form_cad_fornecedor();

            MeusFormularios.FormCadFornecedor.Show();
            MeusFormularios.FormCadFornecedor.Focus();
        }

        private void btn_cadVestido_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadVestido == null)
                MeusFormularios.FormCadVestido = new Form_cad_vestido();

            MeusFormularios.FormCadVestido.Show();
            MeusFormularios.FormCadVestido.Focus();
        }

        private void btn_cadFuncionario_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadFuncionario == null)
                MeusFormularios.FormCadFuncionario = new Form_cad_funcionario();

            MeusFormularios.FormCadFuncionario.Show();
            MeusFormularios.FormCadFuncionario.Focus();
        }
    }
}
