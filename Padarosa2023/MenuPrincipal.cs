using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023
{
    public partial class MenuPrincipal : Form
    {
        // Objetos globais:
        Classes.Usuario usuario = new Classes.Usuario();

        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();


            // Atribuir o usuário local no global:
            this.usuario = usuario;


            // Mudar a label de apresentação:
            lblSaudacao.Text = "Olá, " + usuario.NomeCompleto;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoProdutos janela = new Views.GerenciamentoProdutos(usuario);
            janela.Show();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoComandas janela = new Views.GerenciamentoComandas(usuario);
            janela.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Views.Caixa janela = new Views.Caixa(usuario);
            janela.Show();
        }
    }
}
