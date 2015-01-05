using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace GerenciadorRestaurante
{
    class DAOProduto
    {


        public void adicionaProduto(String nome, String descricao, String preco, String quantidade, String foto)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "insert into tbproduto (nome, descricao, preco, quantidade, foto) values (@nom, @desc, @prec, @qtd, @fot)";
            cmd.Parameters.AddWithValue("@nom", nome);
            cmd.Parameters.AddWithValue("@desc", descricao);
            cmd.Parameters.AddWithValue("@prec", preco);
            cmd.Parameters.AddWithValue("@qtd", quantidade);
            cmd.Parameters.AddWithValue("@fot", foto);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Cadastro realizado com sucesso");


        }

        public void buscaProduto(CheckedListBox cbl)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {
                MySqlDataAdapter Adapter;
                
                DataSet DSet;
                DSet = new DataSet();
                DataRow row = null;
                int i= 0;
               

                Adapter = new MySqlDataAdapter("SELECT nome FROM tbproduto ", con);
         
                Adapter.Fill(DSet, "tbproduto");
                cbl.Items.Clear();
               
                foreach (DataRow col in DSet.Tables["tbproduto"].Rows)
                {
                    row = col;
                    cbl.Items.Add(DSet.Tables["tbproduto"].Rows[i][0]);

                    i++;

                   


                }


            }
        }

        public void vendaProduto(CheckedListBox cbl, String pag, String val, String data)
        {

            DAONotas nota = new DAONotas();
            String pedido = null;

            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            conexao.Open();


            if (cbl.Items.Count > 0)
            {
                for (int i = 0; i <= cbl.CheckedItems.Count - 1; i++)
                {
                     pedido +=  cbl.CheckedItems[i].ToString() + "\n";

                     MySqlCommand cmd = new MySqlCommand();
                     cmd.Connection = conexao;
                     
            


                   
                }
            }

            nota.adicionaNota(pag, val, data, pedido);
            
        }




    }
}
