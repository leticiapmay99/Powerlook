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
    public partial class Form_relatorio_venda : Form
    {
        public Form_relatorio_venda()
        {
            InitializeComponent();
        }

        private void Form_relatorio_venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatoriosVenda = null;
        }

        private void Form_relatorio_venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PowerLookDataSet.VendasSimplesRelatorio'. Você pode movê-la ou removê-la conforme necessário.
            this.VendasSimplesRelatorioTableAdapter.Fill(this.PowerLookDataSet.VendasSimplesRelatorio);

            this.reportViewer1.RefreshReport();
        }
    }
}
