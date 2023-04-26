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
    public class PrincipalDAO
    {
        private MySqlConnection conexao;
        //Construtor
        public PrincipalDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Trazer o usuário logado
        public string UsuarioLogado(Login obj)
        {
            try
            {
                //Sql
                string sql = @"select nome from tb_usuarios
                               where id = @id;";

                //Organizando e executando o Sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Retornar o nome do usuário logado
                string saida = reader.GetString(0);
                conexao.Close();
                return saida;
            }
            catch (Exception)
            {
                //MessageBox.Show("Aconteceu um erro: " + erro); Colocar uma messagem box para relogar, só ocorre erro quando o usuário exclui seu próprio código
            }
            return "";
        }

        #endregion
    }
}
