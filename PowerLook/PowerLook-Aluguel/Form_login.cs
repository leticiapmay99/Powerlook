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
    public partial class Login : Form
    {

        public bool logado = false;

        public int teste;
        public Login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            this.tipoUsuarioBindingSource.DataSource = DataContextFactory.DataContext.TipoUsuario.Where
            (
                x => x.id != 2
            );
        }
        private void EfetuarLogin()
        {
            var tipoUsuario = (int)ComboBoxTipoUsuario.SelectedValue;
 
            var user = DataContextFactory.DataContext.Login.Count(
                x => x.login1 == login1TextBox.Text && x.senha == senhaTextBox.Text  && x.id_tipoLogin == tipoUsuario);

            if(user > 0 )
            {
                this.teste = tipoUsuario;
                this.logado = true;
                this.Dispose();
            } else
            {
                MessageBox.Show("Usuário, Senha ou Tipo de Usuário inválidos", "Erro");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}

