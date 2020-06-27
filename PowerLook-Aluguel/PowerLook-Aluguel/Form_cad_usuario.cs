using System
    ;
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
    public partial class Form_cad_usuario : Form
    {
        public Form_cad_usuario()
        {
            InitializeComponent();
        }

        private void Form_cad_usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormUsuario = null;
        }

        private void Form_cad_usuario_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios.Where(x => x.id_tipo_pessoa == 1 || x.id_tipo_pessoa == 3);
            this.tipoUsuarioBindingSource.DataSource = DataContextFactory.DataContext.TipoUsuario.Where(x => x.id != 2);
            this.loginBindingSource.DataSource = DataContextFactory.DataContext.Login;
        }

        private void loginDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((TipoUsuario)e.Value).name;
            }
            if (e.Value != null && e.ColumnIndex == 4)
            {
                e.Value = ((Usuarios)e.Value).nome;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.AddNew();
            id_funcionarioComboBox.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            loginDataGridView.Refresh();
            MessageBox.Show("Usuário Cadastrada com sucesso");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.CancelEdit();
            this.Dispose();
            MeusFormularios.FormUsuario = null;
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.loginBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Usuario Excluido com sucesso");
            }
        }

    }
}
