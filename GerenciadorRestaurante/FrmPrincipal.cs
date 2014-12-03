using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GerenciadorRestaurante;

namespace Brazilian_Sound_Vinil
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarCardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }

            Adicionar add = new Adicionar();
            add.MdiParent = this;
            add.Show();
        }
    }
}
