using System;
using System.Collections;
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
    public partial class GerenciamentoProdutos : Form
    {
        // Global:
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            lblUsuarioLogado.Text = $"Olá, {usuario.NomeCompleto}!";

            Classes.Categoria categoria = new Classes.Categoria();


            // Montar o cmb:
            var r = categoria.ListarTudo(); // r é a tabela do bd

            // Percorrer o R, montar a string e adicionar no cmb:
            foreach (DataRow linha in r.Rows) 
            {
                cmbEditar.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                cmbCategorias.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
            }
        }

        
    }
}
