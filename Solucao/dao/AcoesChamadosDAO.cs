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
    public class AcoesChamadosDAO
    {
        private MySqlConnection conexao;

        public AcoesChamadosDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Alterar a Data
        public void AlterarData(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set data_acao = @data where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@data", obj.dataAcao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Alterar o Inicio
        public void AlterarInicio(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set tempo_inicial = @inicio where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@inicio", obj.tempoInicial);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Alterar o Fim
        public void AlterarFim(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set tempo_final = @fim where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@fim", obj.tempoFinal);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Alterar o Tempo
        public void AlterarTempo(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set tempo_total = @total where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@total", obj.tempoTotal);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Alterar a Atividade
        public void AlterarAtividade(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set atividade = @atividade where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@atividade", obj.atividade);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Alterar o Custo
        public void AlterarCusto(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set custo = @custo where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@custo", obj.custo);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Alterar a Descricao
        public void AlterarDescricao(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set observacao = @observacao where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@observacao", obj.descricao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Método para Alterar a Visibilidade
        public void AlterarVisibilidade(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados_acoes set visibilidade = @visibilidade where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@visibilidade", obj.visibilidade);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Método para Deletar a Ação
        public void DeletarAcao(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"delete from tb_chamados_acoes where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //Abrindo e executando Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion
    }
}
