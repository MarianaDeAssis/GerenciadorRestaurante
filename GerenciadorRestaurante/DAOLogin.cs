using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Brazilian_Sound_Vinil
{
    class DAOLogin
    {
        public bool validaUsuario(string usuario, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;
            ////instância da conexão
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;userid=root;password=;database=dbloja;");
            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM tbfuncionario WHERE codFunc= @cod AND senhaFunc = @sen";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, conexao);
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@cod", usuario);
            cmd.Parameters.AddWithValue("@sen", senha);
            //abro conexão
            conexao.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            conexao.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;
        }

    }
}
