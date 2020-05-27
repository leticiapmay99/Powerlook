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
    public partial class Form_cad_funcionario : Form
    {
        public Form_cad_funcionario()
        {
            InitializeComponent();
        }

        private void Form_cad_funcionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormFuncionario = null;
        }
    }
}
