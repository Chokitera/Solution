using Solucao.controls;
using Solucao.dao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.views
{
    public partial class Frmvisualizarchamadostecnico : Form
    {
        private string _idChamado;
        private string _nome;
        private string id;
        Usuario perm = new Usuario();

        public Frmvisualizarchamadostecnico(string idChamado, string nome, string id)
        {
            InitializeComponent();
            this._idChamado = idChamado;
            this._nome = nome;
            this.id = id;
        }

        private void Frmvisualizarchamadostecnico_Load(object sender, EventArgs e)
        {
            //Preencher os dados do chamado
            models.Chamado obj = new models.Chamado();
            ChamadoDAO dao = new ChamadoDAO();

            obj = dao.ConsultarChamadosPorId(_idChamado);

            //Atributos
            txtsolicitante.Text = obj.solicitante;
            cmbEquipamento.Texts = obj.equipamento;
            txtResponsavel.Text = obj.responsavel;
            cmbLocal.Texts = obj.localizacao;
            cmbStatus.Texts = obj.status;
            cmbSetor.Texts = obj.setor;
            cmbUrgencia.Texts = obj.urgencia;
            txtTitulo.Text = obj.titulo;
            rtbdescricao.Text = obj.descricao;
            txtData.Text = obj.data + " - " + obj.horario;

            //Permissões da tela
            UsuarioDAO daoperm = new UsuarioDAO();
            perm = daoperm.ConsultarPermissoesDoUsuario(id);

            if(perm.parametro12 == "S")
            {
                iconCancelar.Visible = true;
            }

            VerificaStatus();
            ColocarAcoesNaTela();
        }

        #region Alteração do Chamado
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Alterando o responsável
            models.Chamado obj = new models.Chamado();
            ChamadoDAO dao = new ChamadoDAO();
            txtResponsavel.Text = _nome;

            //Atributos e alteração no banco
            obj.responsavel = _nome;
            obj.id = int.Parse(_idChamado);
            dao.AlterarResponsavel(obj);
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            //Alterando o status
            models.Chamado obj = new models.Chamado();
            ChamadoDAO dao = new ChamadoDAO();

            //Atributos e alteração no banco
            if (cmbStatus.SelectedIndex != -1)
            {
                obj.status = cmbStatus.SelectedItem.ToString();
                obj.id = int.Parse(_idChamado);
                dao.AlterarStatus(obj);
            }
        }

        private void cmbUrgencia_Leave(object sender, EventArgs e)
        {
            //Alterando a urgência
            models.Chamado obj = new models.Chamado();
            ChamadoDAO dao = new ChamadoDAO();

            //Atributos e alteração no banco
            if (cmbUrgencia.SelectedIndex != -1)
            {
                obj.urgencia = cmbUrgencia.SelectedItem.ToString();
                obj.id = int.Parse(_idChamado);
                dao.AlterarUrgencia(obj);
            }
        }


        private void iconCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Cancelar o Chamado #" + _idChamado + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Alterando o status
                models.Chamado obj = new models.Chamado();
                ChamadoDAO dao = new ChamadoDAO();
                cmbStatus.Texts = "Cancelado";

                //Atributos e alteração no banco
                obj.status = "Cancelado";
                obj.id = int.Parse(_idChamado);
                dao.AlterarStatus(obj);

                MessageBox.Show("Chamado #" + _idChamado + " Cancelado com sucesso!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbStatus.Enabled = false;
                cmbUrgencia.Enabled = false;
                btnFinalizar.Enabled = false;
                pictureBox1.Enabled = false;
                iconCancelar.Enabled = false;
                iconNovaAcao.Enabled = false;
                flowLayoutPanel1.Enabled = false;
                btnReabrir.Visible = true;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Finalizar o Chamado #" + _idChamado + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Alterando o status
                models.Chamado obj = new models.Chamado();
                ChamadoDAO dao = new ChamadoDAO();
                cmbStatus.Texts = "Concluído";

                //Atributos e alteração no banco
                obj.status = "Concluído";
                obj.id = int.Parse(_idChamado);
                dao.AlterarStatus(obj);

                MessageBox.Show("Chamado #" + _idChamado + " Concluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbStatus.Enabled = false;
                cmbUrgencia.Enabled = false;
                btnFinalizar.Enabled = false;
                pictureBox1.Enabled = false;
                iconCancelar.Enabled = false;
                flowLayoutPanel1.Enabled = false;
                iconNovaAcao.Enabled = false;
                btnReabrir.Visible = true;
            }

            if(flowLayoutPanel1.Controls.Count > 0)
            {

            }
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Reabrir o Chamado #" + _idChamado + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Alterando o status
                models.Chamado obj = new models.Chamado();
                ChamadoDAO dao = new ChamadoDAO();
                cmbStatus.Texts = "Em Atendimento";

                //Atributos e alteração no banco
                obj.status = "Em Atendimento";
                obj.id = int.Parse(_idChamado);
                dao.AlterarStatus(obj);

                cmbStatus.Enabled = true;
                cmbUrgencia.Enabled = true;
                btnFinalizar.Enabled = true;
                pictureBox1.Enabled = true;
                iconCancelar.Enabled = true;
                iconNovaAcao.Enabled = true;
                flowLayoutPanel1.Enabled = true;
                btnReabrir.Visible = false;
            }
        }
        #endregion

        #region Método para Verificar o Status do Chamado
        public void VerificaStatus()
        {
            //Preencher os dados do chamado
            models.Chamado obj = new models.Chamado();
            ChamadoDAO dao = new ChamadoDAO();

            obj = dao.ConsultarChamadosPorId(_idChamado);
            if (obj.status == "Cancelado" || obj.status == "Concluído")
            {
                cmbStatus.Enabled = false;
                cmbUrgencia.Enabled = false;
                btnFinalizar.Enabled = false;
                pictureBox1.Enabled = false;
                iconCancelar.Enabled = false;
                iconNovaAcao.Enabled = false;
                flowLayoutPanel1.Enabled = false;
                btnReabrir.Visible = true;
            }
        }

        #endregion

        #region Sair do Formulário
        private void btnSair_Click(object sender, EventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is Form1
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((Form1)qrForm.First()).ColocarFormNoPainel(new Frmchamados(id));
            }
        }
        #endregion

        #region Adicionar novas Ações
        private void iconNovaAcao_Click(object sender, EventArgs e)
        {
            //Criando a ação
            controls.AcoesChamados acoeschamados = new controls.AcoesChamados();
            acoeschamados = new controls.AcoesChamados();

            //Criando o espaço entre as ações
            controls.EspacoAcoesChamados espacochamados = new controls.EspacoAcoesChamados();
            espacochamados = new controls.EspacoAcoesChamados();

            //Inserindo a ação no Banco de dados
            models.ChamadoAcoes obj = new models.ChamadoAcoes();
            obj.idChamado = int.Parse(_idChamado);
            obj.idResponsavel = perm.id;
            ChamadoDAO dao = new ChamadoDAO();

            //Adicionando a ação e o espaço
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                acoeschamados.IdAcao = dao.InserirAcao(obj).id;
                acoeschamados.IdAcao = dao.InserirAcao(obj).id;
                acoeschamados.IdResponsavel = perm.id;
                acoeschamados.UsuarioLogado = perm.id;
                flowLayoutPanel1.Controls.Add(acoeschamados);
            }
            else
            {
                acoeschamados.IdAcao = dao.InserirAcao(obj).id;
                acoeschamados.IdResponsavel = perm.id;
                acoeschamados.UsuarioLogado = perm.id;
                //flowLayoutPanel1.Controls.Add(espacochamados);
                flowLayoutPanel1.Controls.Add(acoeschamados);
                acoeschamados.Focus();
            }


        }
        #endregion

        #region Trazer/Colocar as Ações já Existentes
        public void ColocarAcoesNaTela()
        {

            //Criando o espaço entre as ações
            controls.EspacoAcoesChamados espacochamados = new controls.EspacoAcoesChamados();
            espacochamados = new controls.EspacoAcoesChamados();

            //Atribui o nome de quem está logado
            models.ChamadoAcoes obj = new models.ChamadoAcoes();
            obj.idChamado = int.Parse(_idChamado);

            //Limpar os Controles
            flowLayoutPanel1.Controls.Clear();

            ChamadoDAO dao = new ChamadoDAO();
            DataTable dt = dao.ConsultarAcoesChamados(obj);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    controls.AcoesChamados[] acoeschamados = new controls.AcoesChamados[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            acoeschamados[i] = new controls.AcoesChamados();

                            acoeschamados[i].Descricao = row["observacao"].ToString();
                            acoeschamados[i].Data = row["data_acao"].ToString();
                            acoeschamados[i].TempoInicial = row["tempo_inicial"].ToString();
                            acoeschamados[i].TempoFinal = row["tempo_final"].ToString();
                            acoeschamados[i].TempoTotal = row["tempo_total"].ToString();
                            acoeschamados[i].Atividade = row["atividade"].ToString();
                            acoeschamados[i].Custo = row["custo"].ToString().Replace(".", ",");
                            acoeschamados[i].Visibilidade = row["visibilidade"].ToString();
                            acoeschamados[i].IdAcao = int.Parse(row["id"].ToString());
                            acoeschamados[i].IdResponsavel = int.Parse(row["responsavel"].ToString());
                            acoeschamados[i].UsuarioLogado = perm.id;

                            //Preencher os Controls
                            flowLayoutPanel1.Controls.Add(acoeschamados[i]);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
