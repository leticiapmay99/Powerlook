﻿using System;
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
    public partial class Form_principal : Form
    {
       
        public Form_principal()
        {
            InitializeComponent();

            if(Program.permissaoUsuario == true)
            {

                btnFuncionario.Enabled = true;
                funcionárioToolStripMenuItem.Enabled = true;
                btnFornecedor.Enabled = true;
                fornecedorToolStripMenuItem.Enabled = true;
                btnUsuario.Enabled = true;
                usuáriosToolStripMenuItem.Enabled = true;
            }
        }

        private void btnVestido_Click(object sender, EventArgs e)
        {


                if (MeusFormularios.FormProduto == null)
                    MeusFormularios.FormProduto = new Form_cad_produto();

                MeusFormularios.FormProduto.Show();
                MeusFormularios.FormProduto.Focus();

        }

        private void vestidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new Form_cad_produto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }



        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFornecedor == null)
                MeusFormularios.FormFornecedor = new Form_cad_Fornecedor();

            MeusFormularios.FormFornecedor.Show();
            MeusFormularios.FormFornecedor.Focus();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFornecedor == null)
                MeusFormularios.FormFornecedor = new Form_cad_Fornecedor();

            MeusFormularios.FormFornecedor.Show();
            MeusFormularios.FormFornecedor.Focus();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCliente == null)
                MeusFormularios.FormCliente = new Form_cad_cliente();

            MeusFormularios.FormCliente.Show();
            MeusFormularios.FormCliente.Focus();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            
            if (MeusFormularios.FormCliente == null)
                MeusFormularios.FormCliente = new Form_cad_cliente();

            MeusFormularios.FormCliente.Show();
            MeusFormularios.FormCliente.Focus();

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorios == null)
                MeusFormularios.FormRelatorios = new Form_relatorios();

            MeusFormularios.FormRelatorios.Show();
            MeusFormularios.FormRelatorios.Focus();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosCliente == null)
                MeusFormularios.FormRelatoriosCliente = new Form_relatorio_cliente();

            MeusFormularios.FormRelatoriosCliente.Show();
            MeusFormularios.FormRelatoriosCliente.Focus();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosFornecedor == null)
                MeusFormularios.FormRelatoriosFornecedor = new Form_relatorio_fornecedor();

            MeusFormularios.FormRelatoriosFornecedor.Show();
            MeusFormularios.FormRelatoriosFornecedor.Focus();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFuncionario == null)
                MeusFormularios.FormFuncionario = new Form_cad_funcionario();

            MeusFormularios.FormFuncionario.Show();
            MeusFormularios.FormFuncionario.Focus();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFuncionario == null)
                MeusFormularios.FormFuncionario = new Form_cad_funcionario();

            MeusFormularios.FormFuncionario.Show();
            MeusFormularios.FormFuncionario.Focus();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new Form_cad_categoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new Form_cad_categoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
                MeusFormularios.FormVenda = new Form_Venda();

            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
                MeusFormularios.FormVenda = new Form_Venda();

            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormBuscas == null)
                MeusFormularios.FormBuscas = new Form_buscas();

            MeusFormularios.FormBuscas.Show();
            MeusFormularios.FormBuscas.Focus();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatoriosVenda == null)
                MeusFormularios.FormRelatoriosVenda = new Form_relatorio_venda();

            MeusFormularios.FormRelatoriosVenda.Show();
            MeusFormularios.FormRelatoriosVenda.Focus();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormUsuario == null)
                MeusFormularios.FormUsuario = new Form_cad_usuario();

            MeusFormularios.FormUsuario.Show();
            MeusFormularios.FormUsuario.Focus();
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormUsuario == null)
                MeusFormularios.FormUsuario = new Form_cad_usuario();

            MeusFormularios.FormUsuario.Show();
            MeusFormularios.FormUsuario.Focus();
        }
    }
}
