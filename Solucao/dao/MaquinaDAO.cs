using MySql.Data.MySqlClient;
using Solucao.conexao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.dao
{
    public class MaquinaDAO
    {
        private MySqlConnection conexao;
        public MaquinaDAO() { 
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Máquinas
        public void CadastrarMaquina(Maquina obj)
        {
            try
            {
                //Sql
                string sql = @"INSERT INTO tb_maquinas (equipamento, situacao, localizacao, setor, ncm, plano, garantia) 
                           VALUES (@equipamento, @situacao, @localizacao, @setor, @ncm, @plano, @garantia);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@equipamento", obj.equipamento);
                executacmd.Parameters.AddWithValue("@situacao", obj.situacao);
                executacmd.Parameters.AddWithValue("@localizacao", obj.localizacao);
                executacmd.Parameters.AddWithValue("@setor", obj.setor);
                executacmd.Parameters.AddWithValue("@ncm", obj.ncm);
                executacmd.Parameters.AddWithValue("@plano", obj.plano);
                executacmd.Parameters.AddWithValue("@garantia", obj.garantia);

                //Sql para consultar o último usuário cadastrado
                string sql2 = @"select id from tb_maquinas order by id desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                string codigo = reader.GetString(0);
                MessageBox.Show("Máquina cadastrada com sucesso!\n\nCódigo da Máquina: " + codigo + " - " + obj.equipamento, "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }

        }

        #endregion

        #region Método para Editar Máquinas
        public void EditarMaquina(Maquina obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_maquinas set equipamento = @equipamento, situacao = @situacao, localizacao = @localizacao, setor = @setor, ncm = @ncm, plano = @plano, garantia = @garantia where id = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@equipamento", obj.equipamento);
                executacmd.Parameters.AddWithValue("@situacao", obj.situacao);
                executacmd.Parameters.AddWithValue("@localizacao", obj.localizacao);
                executacmd.Parameters.AddWithValue("@setor", obj.setor);
                executacmd.Parameters.AddWithValue("@ncm", obj.ncm);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@plano", obj.plano);
                executacmd.Parameters.AddWithValue("@garantia", obj.garantia);

                //Executando o Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Máquina " + obj.id + " - " + obj.equipamento + " atualizada com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Excluir Máquinas
        public void ExcluirMaquina(Maquina obj)
        {
            try
            {
                //Sql
                string sql = @"DELETE FROM tb_maquinas WHERE id = @id;";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Máquina " + obj.id + " - " + obj.equipamento + " excluída com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Consultar a Máquina por Código
        public Maquina ConsultarCodigoDaMaquina(Maquina obj)
        {
            try
            {
                //Sql
                string sql = @"select * from tb_maquinas where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Atributos
                obj.equipamento = reader.GetString(1);
                obj.situacao = reader.GetString(2);
                obj.localizacao = reader.GetString(3);
                obj.setor = reader.GetString(4);
                obj.ncm = int.Parse(reader.GetString(5));
                obj.plano = reader.GetString(6);
                obj.garantia = reader.GetString(7);

                conexao.Close();

                return obj;
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion

        #region Preencher ComboBox Setor
        public DataTable ListarSetor()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"select id, nome from tb_cadastros_setor order by nome asc;";
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
            return dt;
        }


        #endregion

        #region Preencher ComboBox Localização
        public DataTable ListarLocal()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"select id, nome from tb_cadastros_local order by nome asc;";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
            return dt;
        }


        #endregion

        #region Método para Verificar Campos em Branco
        public bool VerificarCampos(Maquina obj)
        {
            //Verificar todos os campos
            if (obj.equipamento == string.Empty)
            {
                MessageBox.Show("Campo Equipamento não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.situacao == null)
            {
                MessageBox.Show("Campo Situação não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.localizacao == null)
            {
                MessageBox.Show("Campo Localização não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.setor == null)
            {
                MessageBox.Show("Campo Setor não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        #endregion

        #region Método para Revisar Campos em Branco - Apenas para Edição
        public bool RevisarCampos(Maquina obj)
        {
            //Verificar todos os campos
            if (obj.equipamento == string.Empty)
            {
                MessageBox.Show("Campo Equipamento necessita de revisão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.situacao == null)
            {
                MessageBox.Show("Campo Situação necessita de revisão", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.localizacao == null)
            {
                MessageBox.Show("Campo Localização necessita de revisão", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.setor == null)
            {
                MessageBox.Show("Campo Setor necessita de revisão", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        #endregion

        #region Método Verifica Localização
        public Maquina VerificaLocal(Maquina obj)
        {
            try
            {
                //sql
                string sql = @"select nome from tb_cadastros_local where id = @id;";

                //Parametros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("id", obj.localizacao);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
                obj.localizacao = reader.GetString(0);
                conexao.Close();
            }
            catch (Exception)
            {

            }
            return obj;
        }
        #endregion

        #region Método Verifica Setor
        public Maquina VerificaSetor(Maquina obj)
        {
            try
            {
                //sql
                string sql = @"select nome from tb_cadastros_setor where id = @id;";

                //Parametros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("id", obj.localizacao);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
                obj.setor = reader.GetString(0);
                conexao.Close();
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion
    }
}
