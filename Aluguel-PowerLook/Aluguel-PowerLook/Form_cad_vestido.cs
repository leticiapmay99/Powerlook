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
    public partial class Form_cad_vestido : Form
    {
        public Form_cad_vestido()
        {
            InitializeComponent();
        }

        private void Form_cad_vestido_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCadVestido = null;
        }
    }
}
