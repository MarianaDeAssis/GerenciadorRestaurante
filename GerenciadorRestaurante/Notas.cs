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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            
            String pag, valor, data;

            pag = txtForma.Text;
            valor = txtValor.Text;
            data = txtData.Text;
           

            DAONotas nota = new DAONotas();
            nota.adicionaNota(pag, valor, data);



        }
    }
}
