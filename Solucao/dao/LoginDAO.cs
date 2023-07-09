using MySql.Data.MySqlClient;
using Solucao.conexao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.dao
{
    public class LoginDAO
    {
        private MySqlConnection conexao;
        //Construtor
        public LoginDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Efetuar o Login
        public bool EfetuarLogin(Login obj)
        {
            try
            {
                //Comando Sql
                string sql = @"select * from tb_usuarios
                               where id = @id and senha = @senha;";

                //Organizando e executando o comando Sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                if (reader.Read())
                {
                    //Login foi realizado com sucesso
                    MessageBox.Show("Login realizado com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    return true;
                }
                else
                {
                    //Senha ou E-mail incorretos
                    MessageBox.Show("E-mail ou senha incorreto!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }

            return false;
        }

        #endregion

        #region Método para Consultar o Nome de Usuario pelo Id
        public string ConsultaNomeUsuario(int id)
        {
            try
            {
                //Sql
                string sql = @"select * from tb_usuarios where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Retornar o nome do usuário logado
                string saida = reader.GetString("nome");
                conexao.Close();
                return saida;
            }
            catch (Exception)
            {
                conexao.Close();
                return "";
            }
        }

        #endregion
    }
}
