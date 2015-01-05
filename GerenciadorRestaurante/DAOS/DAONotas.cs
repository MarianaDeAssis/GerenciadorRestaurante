using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GerenciadorRestaurante
{
    class DAONotas
    {
        

        public void adicionaNota(String formaPg, String valor, String data, String descricao)
        {
            String codFunc = DAOFuncionario.Codigo;
            MySqlConnection conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "insert into tbnota (codFunc_fk, formaPg, valorTotal, dataVenda, descricao) values (@cod, @form, @val, @dat, @desc)";
            cmd.Parameters.AddWithValue("@cod", codFunc);
            cmd.Parameters.AddWithValue("@form", formaPg);
            cmd.Parameters.AddWithValue("@val", valor);
            cmd.Parameters.AddWithValue("@dat", data);
            cmd.Parameters.AddWithValue("@desc", descricao);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Cadastro realizado com sucesso");


        }

        public void buscaNotas(DataGridView dgv)
        {
            MySqlConnection con;

            con = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");

            con.Open();


            if (con.State == ConnectionState.Open)
            {   
                String codAtual = DAOFuncionario.Codigo;
                MySqlDataAdapter Adapter;
                DataSet DSet;

                DSet = new DataSet();

               

                Adapter = new MySqlDataAdapter("Select * from tbnota", con); 
    
                Adapter.Fill(DSet, "tbnota");
                dgv.DataSource = DSet;

                dgv.DataMember = "tbnota";



            }
        }

    }
}
