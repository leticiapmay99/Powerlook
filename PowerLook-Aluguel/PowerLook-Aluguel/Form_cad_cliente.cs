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
           
            this.enderecosTableAdapter.Fill(this.powerLookDataSet.Enderecos);
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios.Where(x=> x.id_tipo_pessoa==2); 
            this.tipoUsuarioBindingSource.DataSource = DataContextFactory.DataContext.TipoUsuario.Where(x => x.id == 2);
            this.enderecosBindingSource.DataSource = DataContextFactory.DataContext.Enderecos;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.AddNew();
            this.PessoaCorrente.PessoaFisica = new PessoaFisica();
            nomeTextBox.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (this.Valida())
            {

                this.usuariosBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                usuariosDataGridView.Refresh();
                MessageBox.Show("Cliente Cadastrado com sucesso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.CancelEdit();
            this.Dispose();
            MeusFormularios.FormCliente = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.UsuarioPossuiVenda(this.PessoaCorrente))
                    MessageBox.Show("VocÊ não pode excluir um Cliente que possui uma venda");
                else
                {
                    this.usuariosBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Cliente Excluido com sucesso");
                }
            }
        }


        private bool UsuarioPossuiVenda(Usuarios usuario)
        {
            var produtos = DataContextFactory.DataContext.Venda.Where(x => x.id_usuario == usuario.id);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
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
        }


        private bool Valida()
        {
            if (tipoUsuarioComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Tipo do Usuário é obrigatório");
                nomeTextBox.Focus();
                return false;
            }
            if (nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatório");
                nomeTextBox.Focus();
                return false;
            }
            if (emailTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Email é obrigatório");
                emailTextBox.Focus();
                return false;
            }
            if (telefoneMaskedTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Telefone é obrigatório");
                telefoneMaskedTextBox.Focus();
                return false;
            }

            if (data_nascimentoDateTimePicker.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Data de Nascimento é obrigatório");
                nomeTextBox.Focus();
                return false;
            }

            if ( cpfMaskedTextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo CPF é obrigatório");
                cpfMaskedTextBox1.Focus();
                return false;
            }
            if (rgTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo RG é obrigatório");
                rgTextBox.Focus();
                return false;
            }

            if (enderecosComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Endereço é obrigatório");
                enderecosComboBox.Focus();
                return false;
            }
            if (numero_casaTextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Número é obrigatório");
                numero_casaTextBox1.Focus();
                return false;
            }
            if (complementoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Completo é obrigatório");
                complementoTextBox.Focus();
                return false;
            }

            return true;
        }

        private void enderecosLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
