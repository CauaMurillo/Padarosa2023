﻿using Padarosa2023.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023.Views
{
    public partial class Caixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        Classes.Produto produto = new Classes.Produto();
        Classes.OrdemComanda ordem = new OrdemComanda();
        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Caixa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?","Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                if(ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encerrada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar:
                    txbComanda.Clear();
                    dgvCaixa.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxPagamento_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar/Desativar btn de acordo com o checked:
            btnEncerrar.Enabled = cbxPagamento.Checked;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbComanda.Text != "")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                var r = ordem.BuscarFicha();
                dgvCaixa.DataSource = r;
                // Atualizar o valor total:
                lblPreco.Text ="R$" + r.Compute("SUM(Total_item)","True").ToString();
            }
            else
            {
                MessageBox.Show("Digite o numero da ficha",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
