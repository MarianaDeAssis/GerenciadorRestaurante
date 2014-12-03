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

        public void deletaProduto(String nome)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "delete from tbproduto WHERE nome = @nome ";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Deletado com sucesso");


        }

        public void buscaProduto(DataGridView dgv)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {
                MySqlDataAdapter Adapter;
                DataSet DSet;

                DSet = new DataSet();

                Adapter = new MySqlDataAdapter("SELECT * FROM tbproduto ", con);
                

                Adapter.Fill(DSet, "tbproduto");
                dgv.DataSource = DSet;

                dgv.DataMember = "tbproduto";



            }
        }

        public void vendaVinil(String id, DataTable tupla)
        {

            String conectar;

            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            conectar = "select * from tbProduto where idProduto = " + id;

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter(conectar, conexao);
            DataSet DSet = new DataSet();
            mySqlDataAdapter.Fill(DSet);

            tupla.Merge(DSet.Tables[0]);

            conexao.Close();

        }




    }
}
