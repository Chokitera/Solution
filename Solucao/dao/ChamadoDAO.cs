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
    public class ChamadoDAO
    {
        private MySqlConnection conexao;
        public ChamadoDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Novo Chamado
        public void CadastrarChamado(Chamado obj)
        {
            try
            {
                string sql = @"insert into tb_chamados (solicitante, responsavel, data_chamado, hora, status_chamado, urgencia, titulo, descricao, equipamento, setor, localizacao) 
                           values (@solicitante, @responsavel, @data, @hora, @status, @urgencia, @titulo, @descricao, @equipamento, @setor, @localizacao);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@solicitante", obj.solicitante);
                executacmd.Parameters.AddWithValue("@responsavel", obj.responsavel);
                executacmd.Parameters.AddWithValue("@status", obj.status);
                executacmd.Parameters.AddWithValue("@urgencia", obj.urgencia);
                executacmd.Parameters.AddWithValue("@titulo", obj.titulo);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@equipamento", obj.equipamento);
                executacmd.Parameters.AddWithValue("@setor", obj.setor);
                executacmd.Parameters.AddWithValue("@localizacao", obj.localizacao);
				executacmd.Parameters.AddWithValue("@data", obj.data);
                executacmd.Parameters.AddWithValue("@hora", obj.horario);

                //Sql para consultar o último usuário cadastrado
                string sql2 = @"select id from tb_chamados order by id desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Abrir e Executar Sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
                conexao.Open();
                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                string codigo = reader.GetString(0);
                MessageBox.Show("Chamado cadastrado com sucesso!\n\nNúmero do Chamado: " + codigo + ".", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader.Close();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Preencher ComboBox Setor
        public DataTable ListarSetor()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"select id, nome from tb_cadastros_setor order by nome asc;";
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

        #region Preencher ComboBox Equipamento
        public DataTable ListarEquipamento()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"select id, equipamento from tb_maquinas where situacao = 'Ativo' order by equipamento asc;";
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

        #region Método para Verificar Campos em Branco - Ajustar ainda
        public bool VerificarCampos(Chamado obj)
        {
            //Verificar todos os campos
            if (obj.equipamento == null)
            {
                MessageBox.Show("Campo Equipamento não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (obj.titulo == string.Empty)
            {
                MessageBox.Show("Campo Título não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (obj.descricao == string.Empty)
            {
                MessageBox.Show("A Descrição não está preenchida!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        #endregion

        #region Método Verifica Localização
        public Chamado VerificaLocal(Chamado obj)
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
                reader.Close();
                conexao.Close();
            }
            catch (Exception)
            {

            }
            return obj;
        }
        #endregion

        #region Método Verifica Setor
        public Chamado VerificaSetor(Chamado obj)
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
                reader.Close();
                conexao.Close();
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion

        #region Método Verifica Equipamento
        public Chamado VerificaEquipamento(Chamado obj)
        {
            try
            {
                //sql
                string sql = @"select equipamento from tb_maquinas where id = @id;";

                //Parametros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("id", obj.equipamento);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
                obj.equipamento = reader.GetString(0);
                reader.Close();
                conexao.Close();
            }
            catch (Exception)
            {

            }
            return obj;
        }

        #endregion

        #region Consultar Chamados
        public DataTable ConsultarChamados(Chamado obj)
        {
            DataTable dt = new DataTable();
            try
            {
                //Sql
                string sql = @"select * from tb_chamados";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@solicitante", obj.solicitante);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
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

        #region Consultar Primeiro Chamado
        public DataTable ConsultarPrimeiroChamado(Chamado obj)
        {
            DataTable dt = new DataTable();
            try
            {
                //Sql
                string sql = @"select * from tb_chamados where id <= 2 order by id desc limit 2";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@solicitante", obj.solicitante);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
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

        #region Consultar Chamados por Id
        public Chamado ConsultarChamadosPorId(string id)
        {
            Chamado obj = new Chamado();
            try
            {
                //Sql
                string sql = @"select * from tb_chamados where id = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
                obj.id = int.Parse(reader.GetString(0));
                obj.solicitante = reader.GetString(1);
                obj.responsavel = reader.GetString(2);
                obj.status = reader.GetString(3);
                obj.data = reader.GetString(4);
                obj.urgencia = reader.GetString(5);
                obj.horario = reader.GetString(6);
                obj.titulo = reader.GetString(7);
                obj.descricao = reader.GetString(8);
                obj.equipamento = reader.GetString(9);
                obj.setor = reader.GetString(10);
                obj.localizacao = reader.GetString(11);
                
                reader.Close();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
            return obj;
        }

        #endregion

        #region Método para Alterar o Responsável
        public void AlterarResponsavel(Chamado obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados set responsavel = @responsavel where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@responsavel",obj.responsavel);
                executacmd.Parameters.AddWithValue("@id",obj.id);

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

        #region Método para Alterar o Status
        public void AlterarStatus(Chamado obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados set status_chamado = @status where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@status", obj.status);
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

        #region Método para Alterar a Urgência
        public void AlterarUrgencia(Chamado obj)
        {
            try
            {
                //Sql
                string sql = @"update tb_chamados set urgencia = @urgencia where id = @id";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@urgencia", obj.urgencia);
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

        #region Consultar Acões dos Chamados por Id - Especifico
        public ChamadoAcoes ConsultarAcoesChamadosPorIdEspecifico(string id)
        {
            ChamadoAcoes obj = new ChamadoAcoes();
            try
            {
                //Sql
                string sql = @"select * from tb_chamados_acoes where chamado = @id order by id asc;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
                obj.idChamado = int.Parse(reader.GetString(1));
                obj.visibilidade = reader.GetString(2);
                obj.observacao = reader.GetString(3);
                obj.custo = reader.GetString(4);
                obj.atividade = reader.GetString(5);
                obj.dataAcao = reader.GetString(6);
                obj.tempoInicial = reader.GetString(7);
                obj.tempoFinal = reader.GetString(8);
                obj.tempoTotal = reader.GetString(9);

                reader.Close();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
            return obj;
        }

        #endregion

        #region Consultar Ações dos Chamados
        public DataTable ConsultarAcoesChamados(ChamadoAcoes obj)
        {
            DataTable dt = new DataTable();
            try
            {
                //Sql
                string sql = @"select * from tb_chamados_acoes where chamado = @id order by id asc;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.idChamado);

                //Executando o Sql
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();
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

        #region Inserindo a Ação no Banco
        public ChamadoAcoes InserirAcao(ChamadoAcoes obj)
        {
            try
            {
                //Sql
                string sql = @"insert into tb_chamados_acoes (chamado, responsavel) values (@chamado, @responsavel);";
                string sql2 = @"select * from tb_chamados_acoes order by id desc";

                //Atributos
                MySqlCommand executaInsercao = new MySqlCommand(sql, conexao);
                executaInsercao.Parameters.AddWithValue("@chamado", obj.idChamado);
                executaInsercao.Parameters.AddWithValue("@responsavel", obj.idResponsavel);
                MySqlCommand executaConsulta = new MySqlCommand(sql2, conexao);

                //Conexao e execução do Sql
                conexao.Open();
                executaInsercao.ExecuteNonQuery();
                conexao.Close();

                conexao.Open();
                MySqlDataReader reader = executaConsulta.ExecuteReader();
                reader.Read();
                obj.id = int.Parse(reader.GetString(0));
                reader.Close();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
            return obj;
        }

        #endregion
    }
}
