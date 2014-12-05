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
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

            cmb.HeaderText = "Status";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 2;
            cmb.Items.Add("Utilizada");
            cmb.Items.Add("Não utilizada");
            dgvNotas.Columns.Add(cmb);
            

    

            
            

            

        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
