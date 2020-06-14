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
         
        public Login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }
        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Login.Count(
                x => x.login1 == login1TextBox.Text && x.senha == senhaTextBox.Text);

            if(user > 0 )
            {
                this.logado = true;
                this.Dispose();
            } else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Erro");
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
