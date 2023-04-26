using MySql.Data.MySqlClient;
using Mysqlx;
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
    public class CadastroDAO
    {
        private MySqlConnection conexao;
        public CadastroDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Cadastro Setor
        public void CadastrarCadastroSetor(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"INSERT INTO tb_cadastros_setor (nome, definicao, etiqueta, tag) 
                           VALUES (@nome, @definicao, @etiqueta, @tag);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@definicao", obj.definicao);
                executacmd.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                executacmd.Parameters.AddWithValue("@tag", obj.tag);

                //Sql para consultar o último usuário cadastrado
                string sql2 = @"select id from tb_cadastros_setor order by id desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                string codigo = reader.GetString(0);
                MessageBox.Show("Setor cadastrado com sucesso!\n\nCódigo do Setor: " + codigo + " - " + obj.nome, "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }

        }

        #endregion

        #region Método para Editar Cadastro Setor
        public void EditarCadastroSetor(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_cadastros_setor set nome = @nome, definicao = @definicao, 
                               etiqueta = @etiqueta, tag = @tag where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@definicao", obj.definicao);
                executacmd.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                executacmd.Parameters.AddWithValue("@tag", obj.tag);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Setor " + obj.id + " - " + obj.nome + " atualizado com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Cadastrar Cadastro Localização
        public void CadastrarCadastroLocal(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"INSERT INTO tb_cadastros_local (nome, definicao, etiqueta, tag) 
                           VALUES (@nome, @definicao, @etiqueta, @tag);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@definicao", obj.definicao);
                executacmd.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                executacmd.Parameters.AddWithValue("@tag", obj.tag);

                //Sql para consultar o último usuário cadastrado
                string sql2 = @"select id from tb_cadastros_local order by id desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                string codigo = reader.GetString(0);
                MessageBox.Show("Localização cadastrada com sucesso!\n\nCódigo da Localização: " + codigo + " - " + obj.nome, "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }

        }

        #endregion

        #region Método para Editar Cadastro Localização
        public void EditarCadastroLocal(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_cadastros_local set nome = @nome, definicao = @definicao, 
                               etiqueta = @etiqueta, tag = @tag where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@definicao", obj.definicao);
                executacmd.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                executacmd.Parameters.AddWithValue("@tag", obj.tag);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Localização " + obj.id + " - " + obj.nome + " atualizada com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Excluir Cadastro Setor
        public void ExcluirCadastroSetor(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"DELETE FROM tb_cadastros_setor WHERE id = @id;";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Setor " + obj.id + " - " + obj.nome + " excluído com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Excluir Cadastro Localização
        public void ExcluirCadastroLocal(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"DELETE FROM tb_cadastros_local WHERE id = @id;";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Localização " + obj.id + " - " + obj.nome + " excluído com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Consultar a Localização por Código
        public Cadastro ConsultarCodigoDoCadastroLocal(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"select * from tb_cadastros_local where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Atributos
                obj.nome = reader.GetString(2);
                obj.etiqueta = reader.GetString(3);
                obj.tag = reader.GetString(4);

                conexao.Close();

                return obj;
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion

        #region Método para Consultar o Setor por Código
        public Cadastro ConsultarCodigoDoCadastroSetor(Cadastro obj)
        {
            try
            {
                //Sql
                string sql = @"select * from tb_cadastros_setor where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Atributos
                obj.definicao = reader.GetString(1);
                obj.nome = reader.GetString(2);
                obj.etiqueta = reader.GetString(3);
                obj.tag = reader.GetString(4);

                conexao.Close();

                return obj;
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion

        #region Método para Verificar Campos em Branco
        public bool VerificarCamposSetor(Cadastro obj)
        {
            //Verificar todos os campos
            if (obj.nome == string.Empty)
            {
                MessageBox.Show("Campo Setor não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.etiqueta == string.Empty)
            {
                MessageBox.Show("Campo Etiqueta não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.tag == string.Empty)
            {
                MessageBox.Show("Campo TAG não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public bool VerificarCamposLocal(Cadastro obj)
        {
            //Verificar todos os campos
            if (obj.nome == string.Empty)
            {
                MessageBox.Show("Campo Localização não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.etiqueta == string.Empty)
            {
                MessageBox.Show("Campo Etiqueta não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.tag == string.Empty)
            {
                MessageBox.Show("Campo TAG não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        #endregion
    }
}
