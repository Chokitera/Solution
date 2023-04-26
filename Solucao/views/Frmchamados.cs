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
    public partial class Frmchamados : Form
    {
        Usuario perm = new Usuario();
        private Form formularioAtual;
        private string id;
        public Frmchamados(string id)
        {
            UsuarioDAO dao = new UsuarioDAO();
            InitializeComponent();
            this.id = id;
            perm = dao.ConsultarPermissoesDoUsuario(id);
        }
        private void Frmchamados_Load(object sender, EventArgs e)
        {
            PreencherChamados();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (perm.parametro7 == "S")
                ColocarChamadoNoPainel(new Frmabrirchamados(id));
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Método para colocar os Formulários no Painel
        public void ColocarChamadoNoPainel(object Formulario)
        {
            formularioAtual = this;

            Form fh = Formulario as Form;
            formularioAtual = fh;

            Size f = new Size(0, 0);
            Size p = new Size(1100, 630);
            flowLayoutPanel1.Size = f;
            panel1.Size = f;
            pictureBox1.Size = f;
            lbnPrincipal.Size = f;
            panel2.Size = p;
            panel2.Dock = DockStyle.Fill;
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }

            //Preencher o novo formulário
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        #endregion

        #region Método para Preencher os Chamados
        public void PreencherChamados()
        {
            //Atribui o nome de quem está logado
            models.Chamado obj = new models.Chamado();
            obj.solicitante = perm.nome;

            //Teste
            flowLayoutPanel1.Controls.Clear();

            ChamadoDAO dao = new ChamadoDAO();
            DataTable dt = dao.ConsultarChamados(obj);
            DataTable dt1 = dao.ConsultarPrimeiroChamado(obj);

            //Preencher o primeiro chamado
            if (dt1 != null)
            {
                if (dt1.Rows.Count > 0)
                {
                    controls.Chamado[] chamados = new controls.Chamado[dt1.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt1.Rows)
                        {
                            chamados[i] = new controls.Chamado();

                            chamados[i].SolicitanteChamado = row["solicitante"].ToString();
                            chamados[i].ResponsavelChamado = row["responsavel"].ToString();
                            chamados[i].StatusChamado = row["status_chamado"].ToString();
                            chamados[i].TituloChamado = row["titulo"].ToString();
                            chamados[i].DescricaoChamado = row["descricao"].ToString();
                            chamados[i].SetorChamado = row["setor"].ToString();
                            chamados[i].NumeroChamado = "CHAMADO #" + row["id"].ToString();
                            chamados[i].Horario = row["hora"].ToString();
                            chamados[i].Data = row["data_chamado"].ToString();

                            //Definindo a cor pela urgência
                            if (row["urgencia"].ToString() == "Sem")
                                chamados[i].UrgenciaChamado = Color.MistyRose;
                            if (row["urgencia"].ToString() == "Baixa")
                                chamados[i].UrgenciaChamado = Color.Lime;
                            if (row["urgencia"].ToString() == "Média")
                                chamados[i].UrgenciaChamado = Color.Yellow;
                            if (row["urgencia"].ToString() == "Alta")
                                chamados[i].UrgenciaChamado = Color.Orange;
                            if (row["urgencia"].ToString() == "Urgênte")
                                chamados[i].UrgenciaChamado = Color.Red;

                            //Clicando em visualizar
                            chamados[i].IdChamado = row["id"].ToString();
                            chamados[i].IdUsuario = perm.nome;
                            chamados[i].IdUsuarioLogado = id;

                            //if (chamados[i].)

                            flowLayoutPanel1.Controls.Add(chamados[i]);
                        }
                    }
                }
            }

            //Preencher chamados
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    controls.Chamado[] chamados = new controls.Chamado[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            chamados[i] = new controls.Chamado();

                            chamados[i].SolicitanteChamado = row["solicitante"].ToString();
                            chamados[i].ResponsavelChamado = row["responsavel"].ToString();
                            chamados[i].StatusChamado = row["status_chamado"].ToString();
                            chamados[i].TituloChamado = row["titulo"].ToString();
                            chamados[i].DescricaoChamado = row["descricao"].ToString();
                            chamados[i].SetorChamado = row["setor"].ToString();
                            chamados[i].NumeroChamado = "CHAMADO #" + row["id"].ToString();
                            chamados[i].Horario = row["hora"].ToString();
                            chamados[i].Data = row["data_chamado"].ToString();

                            //Definindo a cor pela urgência
                            if (row["urgencia"].ToString() == "Sem")
                                chamados[i].UrgenciaChamado = Color.MistyRose;
                            if (row["urgencia"].ToString() == "Baixa")
                                chamados[i].UrgenciaChamado = Color.Lime;
                            if (row["urgencia"].ToString() == "Média")
                                chamados[i].UrgenciaChamado = Color.Yellow;
                            if (row["urgencia"].ToString() == "Alta")
                                chamados[i].UrgenciaChamado = Color.Orange;
                            if (row["urgencia"].ToString() == "Urgênte")
                                chamados[i].UrgenciaChamado = Color.Red;

                            //Clicando em visualizar
                            chamados[i].IdChamado = row["id"].ToString();
                            chamados[i].IdUsuario = perm.nome;
                            chamados[i].IdUsuarioLogado = id;

                            //if (chamados[i].)

                            flowLayoutPanel1.Controls.Add(chamados[i]);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
