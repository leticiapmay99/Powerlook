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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(tbNome.Text, tbEmail.Text, TbCpf.Text);
            MessageBox.Show(cad.mensagem);
        }
    }
}
