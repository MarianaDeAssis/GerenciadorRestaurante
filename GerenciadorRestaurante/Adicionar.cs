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
            Login login = new Login();
            Boolean resultado = false;

            do
            {


                //Se o resultado do dialogo for ok
                //ou seja se o usuario e login constarem no bd
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    resultado = true;
                }

                else
                {
                    //Se não mostro a mensagem
                    MessageBox.Show("Usuário ou Login inválidos! A aplicação está bloqueada, chame um funcionário para a execução dos devidos procedimentos.");
                }

            } while (resultado == false);
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
