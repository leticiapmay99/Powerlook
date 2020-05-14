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
    public partial class Form_cad_cliente : Form
    {
        public Form_cad_cliente()
        {
            InitializeComponent();
        }

        public Usuarios PessoaCorrente
        {
            get
            {
                return (Usuarios)this.usuariosBindingSource.Current;
            }
        }

        private void Form_cad_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCliente = null;
        }

        private void Form_cad_cliente_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios;
            this.tipoUsuarioBindingSource.DataSource = DataContextFactory.DataContext.TipoUsuario;
            this.enderecosBindingSource.DataSource = DataContextFactory.DataContext.Enderecos;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.AddNew();
            this.PessoaCorrente.PessoaFisica = new PessoaFisica();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            usuariosDataGridView.Refresh();
            MessageBox.Show("Fornecedor Cadastrado com sucesso");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.usuariosBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Produto Excluido com sucesso");
            }
        }

        private void usuariosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((PessoaFisica)e.Value).cpf;
            }
         
            if (e.Value != null && e.ColumnIndex == 2)
            {
                e.Value = ((PessoaFisica)e.Value).rg;
            }

            if (e.Value != null && e.ColumnIndex == 7)
            {
                e.Value = ((Enderecos)e.Value).cidade;
            }

            if (e.Value != null && e.ColumnIndex == 10)
            {
                e.Value = ((TipoUsuario)e.Value).name;
            }
        }
    }
}
