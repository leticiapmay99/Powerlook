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

        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void Form_Venda_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios.Where(x => x.id_tipo_pessoa == 2);
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos;

            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;


            this.vendaBindingSource.AddNew();

        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            ComboBoxUsuario.Enabled = false;
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

        private void ComboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProduto.SelectedItem != null)
            {
                var prod = (Produtos)ComboBoxProduto.SelectedItem;
                this.ItemCorrente.id_produto = (int)prod.id;
                this.ItemCorrente.valor = (decimal)prod.preco;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in DataGridItem.Rows)
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
                btnFinalizarVenda.Enabled = true;
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.desconto = Convert.ToDecimal(TextBoxDesconto.Text);
            this.VendaCorrente.valor_pago = (decimal)(this.VendaCorrente.valor - this.VendaCorrente.desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            TextBoxDesconto.Enabled = false;
            btnFinalizarVenda.Enabled = false;


            this.contasReceberBindingSource.AddNew();
            ComboBoxStatus.Enabled = true;
            this.ContaCorrente.id_venda = this.VendaCorrente.id_venda;
            this.ContaCorrente.data_compra = DateTime.Now;
            this.ContaCorrente.data_vencimento = DateTime.Now;

        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBoxStatus.SelectedItem != null)
            {
                var status = (StatusPagamento)ComboBoxStatus.SelectedItem;

                if(status.id_status == 1)
                {
                    this.ContaCorrente.id_status = (int)status.id_status;
                    this.ContaCorrente.data_pagamento = DateTime.Now;
                    BtnFinalizar.Enabled = true;
                    DateTimeVencimento.Enabled = false;
                }
                else if (status.id_status == 2)
                {
                    this.ContaCorrente.id_status = (int)status.id_status;
                    this.ContaCorrente.data_vencimento = DateTime.Now;
                    DateTimeVencimento.Enabled = true;
                    BtnFinalizar.Enabled = true;
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            DateTimeVencimento.Enabled = false;
            ComboBoxStatus.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            btnImprimir.Enabled = true;
            BtnFinalizar.Enabled = false;
            MessageBox.Show("Venda finalizada com sucesso! \n Imprima o cupom da venda", "Venda finalizada");
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "Recibo de pagamento \n" +
                "\n                Cliente: " + ComboBoxUsuario.Text 
                + "\n\n" 
                + "                Total: " + TextBoxValorTotal.Text +
                " \n \n Método de pagameto: " + ComboBoxStatus.Text +
                "\n \n \n \n  Obrigada pela compra!!! Volte Sempre!!"
                ;

            Font letra = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point ponto = new Point(100, 100);

            e.Graphics.DrawString(texto, letra, cor, ponto);


        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
