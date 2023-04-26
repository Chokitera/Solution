using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Esf;
using Solucao.conexao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.dao
{
    public class UsuarioDAO
    {
        private MySqlConnection conexao;
        //Construtor
        public UsuarioDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Usuários e Suas Permissões
        public void CadastrarUsuarios(Usuario obj)
        {
            try
            {
                //Sql para cadastrar o Usuário
                string sql = @"INSERT INTO tb_usuarios (nome, senha, email, setor, localizacao,perm1,perm2,perm3,perm4,perm5,perm6,perm7,perm8,perm9,perm10,perm11,perm12) 
                               VALUES (@nome, @senha, @email, @setor, @localizacao,@perm1,@perm2,@perm3,@perm4,@perm5,@perm6,@perm7,@perm8,@perm9,@perm10,@perm11,@perm12);";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@setor", obj.setor);
                executacmd.Parameters.AddWithValue("@localizacao", obj.localizacao);
                executacmd.Parameters.AddWithValue("@perm1", obj.parametro1);
                executacmd.Parameters.AddWithValue("@perm2", obj.parametro2);
                executacmd.Parameters.AddWithValue("@perm3", obj.parametro3);
                executacmd.Parameters.AddWithValue("@perm4", obj.parametro4);
                executacmd.Parameters.AddWithValue("@perm5", obj.parametro5);
                executacmd.Parameters.AddWithValue("@perm6", obj.parametro6);
                executacmd.Parameters.AddWithValue("@perm7", obj.parametro7);
                executacmd.Parameters.AddWithValue("@perm8", obj.parametro8);
                executacmd.Parameters.AddWithValue("@perm9", obj.parametro9);
                executacmd.Parameters.AddWithValue("@perm10", obj.parametro10);
                executacmd.Parameters.AddWithValue("@perm11", obj.parametro11);
                executacmd.Parameters.AddWithValue("@perm12", obj.parametro12);

                //Sql para consultar o último usuário cadastrado
                string sql2 = @"select id from tb_usuarios order by id desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Realizar os sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                string codigo = reader.GetString(0);
                MessageBox.Show("Usuário cadastrado com sucesso!\n\nCódigo do Usuário: " + codigo + " - " + obj.nome, "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Editar Usuários
        public void EditarUsuarios(Usuario obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_usuarios set nome = @nome,senha = @senha,email = @email,setor = @setor,localizacao = @localizacao,perm1 = @perm1,
                               perm2 = @perm2,perm3 = @perm3,perm4 = @perm4,perm5 = @perm5,perm6 = @perm6,perm7 = @perm7,perm8 = @perm8,perm9 = @perm9,
                               perm10 = @perm10,perm11 = @perm11,perm12 = @perm12 where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@setor", obj.setor);
                executacmd.Parameters.AddWithValue("@localizacao", obj.localizacao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@perm1", obj.parametro1);
                executacmd.Parameters.AddWithValue("@perm2", obj.parametro2);
                executacmd.Parameters.AddWithValue("@perm3", obj.parametro3);
                executacmd.Parameters.AddWithValue("@perm4", obj.parametro4);
                executacmd.Parameters.AddWithValue("@perm5", obj.parametro5);
                executacmd.Parameters.AddWithValue("@perm6", obj.parametro6);
                executacmd.Parameters.AddWithValue("@perm7", obj.parametro7);
                executacmd.Parameters.AddWithValue("@perm8", obj.parametro8);
                executacmd.Parameters.AddWithValue("@perm9", obj.parametro9);
                executacmd.Parameters.AddWithValue("@perm10", obj.parametro10);
                executacmd.Parameters.AddWithValue("@perm11", obj.parametro11);
                executacmd.Parameters.AddWithValue("@perm12", obj.parametro12);

                //Abrir conexao e executar Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário " + obj.id + " - " + obj.nome + " atualizado com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Método para Excluir Usuários
        public void ExcluirUsuario(Usuario obj)
        {
            try
            {
                //Sql
                string sql = @"DELETE FROM tb_usuarios WHERE id = @id;";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário " + obj.id + " - " + obj.nome +  " excluído com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Consultar o Usuário por Código
        public Usuario ConsultarCodigoDoUsuario(Usuario obj)
        {
            try
            {
                //Sql
                string sql = @"select * from tb_usuarios where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Atributos
                obj.nome = reader.GetString(1);
                obj.senha = reader.GetString(2);
                obj.email = reader.GetString(3);
                obj.setor = reader.GetString(4);
                obj.localizacao = reader.GetString(5);
                obj.parametro1 = reader.GetString(6);
                obj.parametro2 = reader.GetString(7);
                obj.parametro3 = reader.GetString(8);
                obj.parametro4 = reader.GetString(9);
                obj.parametro5 = reader.GetString(10);
                obj.parametro6 = reader.GetString(11);
                obj.parametro7 = reader.GetString(12);
                obj.parametro8 = reader.GetString(13);
                obj.parametro9 = reader.GetString(14);
                obj.parametro10 = reader.GetString(15);
                obj.parametro11 = reader.GetString(16);
                obj.parametro12 = reader.GetString(17);

                conexao.Close();

                return obj;
            }
            catch (Exception)
            {
                //MessageBox.Show("Ocorreu um erro:" + erro);
                //MessageBox.Show("Não foi encontrado o código do Usuário", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return obj;
        }

        #endregion

        #region Método para Verificar Campos em Branco
        public bool VerificarCampos(Usuario obj)
        {
            //Verificar todos os campos
            if (obj.nome == string.Empty)
            {
                MessageBox.Show("Campo Nome não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.email == string.Empty)
            {
                MessageBox.Show("Campo E-mail não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.senha == string.Empty)
            {
                MessageBox.Show("Campo Senha não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.setor == string.Empty)
            {
                MessageBox.Show("Campo Setor não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.localizacao == string.Empty)
            {
                MessageBox.Show("Campo Localização não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        #endregion

        #region Método para Consultar as Permissões do Usuário Logado
        public Usuario ConsultarPermissoesDoUsuario(string id)
        {
            Usuario obj = new Usuario();
            try
            {
                //Sql
                string sql = @"select * from tb_usuarios where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Atributos
                obj.id = reader.GetInt32(0);
                obj.nome = reader.GetString(1);
                obj.parametro1 = reader.GetString(6);
                obj.parametro2 = reader.GetString(7);
                obj.parametro3 = reader.GetString(8);
                obj.parametro4 = reader.GetString(9);
                obj.parametro5 = reader.GetString(10);
                obj.parametro6 = reader.GetString(11);
                obj.parametro7 = reader.GetString(12);
                obj.parametro8 = reader.GetString(13);
                obj.parametro9 = reader.GetString(14);
                obj.parametro10 = reader.GetString(15);
                obj.parametro11 = reader.GetString(16);
                obj.parametro12 = reader.GetString(17);

                conexao.Close();

                return obj;
            }
            catch (Exception)
            {
                //MessageBox.Show("Ocorreu um erro:" + erro);
                //MessageBox.Show("Não foi encontrado o código do Usuário", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return obj;
        }

        #endregion
    }
}
