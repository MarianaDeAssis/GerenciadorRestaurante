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
    public partial class ListaNotas : Form
    {
        public ListaNotas()
        {
            InitializeComponent();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            DAONotas notas = new DAONotas();
            notas.buscaNotas(dgvNotas); // daoNotas
            
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListaNotas_Load(object sender, EventArgs e)
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
    }
}
