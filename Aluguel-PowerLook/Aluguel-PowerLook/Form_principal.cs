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

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            Form_cad_cliente form = new Form_cad_cliente();
            form.Show();
        }

        private void btn_cadFornecedor_Click(object sender, EventArgs e)
        {
            Form_cad_fornecedor form = new Form_cad_fornecedor();
            form.Show();
        }

        private void btn_cadFuncionario_Click(object sender, EventArgs e)
        {
            Form_cad_funcionario form = new Form_cad_funcionario();
            form.Show();
        }

        private void btn_cadVestido_Click(object sender, EventArgs e)
        {
            Form_cad_vestido form = new Form_cad_vestido();
            form.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cad_cliente form = new Form_cad_cliente();
            form.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cad_fornecedor form = new Form_cad_fornecedor();
            form.Show();
        }

        private void vestidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cad_vestido form = new Form_cad_vestido();
            form.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cad_funcionario form = new Form_cad_funcionario();
            form.Show();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
