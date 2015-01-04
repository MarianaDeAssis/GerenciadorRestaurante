using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;





namespace GerenciadorRestaurante
{   
    

    public partial class Login : Form
    {
        public String cod;

        public Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //cria variavel da classe de ligacao com a tabela tdfuncionario no banco de dados ( DAOLogin )
            DAOFuncionario login = new DAOFuncionario();

           

            //chamo o método já testando seu retorno
            //preenchendo os parâmetros necessários
            //se retorna true
            if (login.validaUsuario(txtCod.Text, txtSenha.Text))
            {
                //retorno o diálogo ok
                this.DialogResult = DialogResult.OK;
                DAOFuncionario.Codigo = txtCod.Text;
               
     
               
                
            

            }
            else
            {
                //Senão retorno o dialogo cancel por exemplo
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        //Método para validar usuário que recebe duas string
        //como parâmetros que será o usuario e senha

    }
}
