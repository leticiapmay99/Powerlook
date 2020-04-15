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
    public partial class Form_cad_cliente : Form
    {
        public Form_cad_cliente()
        {
            InitializeComponent();
        }


        private void Form_cad_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCadCliente = null;
        }
    }
}
