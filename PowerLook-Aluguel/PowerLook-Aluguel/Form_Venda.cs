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
    public partial class Form_Venda : Form
    {
        public Form_Venda()
        {
            InitializeComponent();
        }

        private void Form_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormVenda = null;
        }

        public Venda VendaCorrente {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public itensVenda ItemCorrente
        {
            get
            {
                return (itensVenda)this.itensVendaBindingSource.Current;
            }
        }
        private void Form_Venda_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios.Where(x => x.id_tipo_pessoa == 2);
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos;


            this.vendaBindingSource.AddNew();

        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBoxNovaVenda.Visible = true;
            btnNovaVenda.Enabled = false;
            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.itensVenda.Where(x => x.id_produto == this.VendaCorrente.id_venda);
            NovoItem();
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.id_venda = this.VendaCorrente.id_venda;
            this.ItemCorrente.quantidade = 1;

        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            DataGridItem.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DataGridItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((Produtos)e.Value).nome;
            }
        }


        private void id_produtoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBoxProduto.SelectedItem != null)
            {
                var prod = (Produtos)ComboBoxProduto.SelectedItem;
                this.ItemCorrente.id_produto = (int)prod.id;
                this.ItemCorrente.valor = (decimal)prod.preco;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach(DataGridViewRow dg in DataGridItem.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal soma = v1 * v2;
                dg.Cells[4].Value = soma;
                total = total + soma;


            }
            this.VendaCorrente.valor = total;
        }

        private void BtnFinalizarPedido_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("Tem certeza que dejesa finalizar?\n Não será possivel adicionar um novo item;", "Comfirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.itensVendaBindingSource.CancelEdit();
                    DataContextFactory.DataContext.SubmitChanges();
                    this.VendaCorrente.desconto = 0;
                    btnNovoItem.Enabled = false;
                    ComboBoxProduto.Enabled = false;
                    quantidadeTextBox.Enabled = false;
                    id_vendaTextBox.Enabled = false;

                    TextBoxDesconto.ReadOnly = false;
                    TextBoxDesconto.Focus();
                    BtnFinalizarPedido.Enabled = false;
                    btnNovaVenda.Enabled = true;

                }
         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {


            this.VendaCorrente.desconto = Convert.ToDecimal(TextBoxDesconto.Text);
            this.VendaCorrente.valor_pago = (decimal)(this.VendaCorrente.valor - this.VendaCorrente.desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            TextBoxDesconto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnImprimir.Enabled = true;

            
        }
    }
}
