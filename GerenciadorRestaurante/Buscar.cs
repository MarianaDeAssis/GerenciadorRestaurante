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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }



       


        private void BuscaVinil_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {   
            

            DAOProduto busca = new DAOProduto();
            busca.buscaProduto(cblProdutos); // daoProdutos


           
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DAOProduto busca = new DAOProduto();

            String pag, valor, data;
            pag = txtForma.Text;
            valor = txtValor.Text;
            data = txtData.Text;

            busca.vendaProduto(cblProdutos, pag, valor, data);
        }

       

        
        



    }
}

