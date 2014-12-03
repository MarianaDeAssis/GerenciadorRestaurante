using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorRestaurante
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome, descricao,preco, quantidade, foto;

            nome = txtNome.Text;
            descricao = txtDescricao.Text;
            preco = txtPreco.Text;
            quantidade = txtQntEstoque.Text;
            foto = txtFoto.Text;


            DAOProduto produto = new DAOProduto();
            produto.adicionaProduto(nome, descricao, preco, quantidade, foto);

        }

      
    }
}
