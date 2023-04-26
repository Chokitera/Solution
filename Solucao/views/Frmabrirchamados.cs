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
    public partial class Frmabrirchamados : Form
    {
        private string id;
        private Form formularioAtual;
        public Frmabrirchamados(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Frmabrirchamados_Load(object sender, EventArgs e)
        {
            //Passar o solicitante
            PrincipalDAO dao = new PrincipalDAO();
            Login obj = new Login();
            obj.id = int.Parse(id);
            txtsolicitante.Text = dao.UsuarioLogado(obj);

            //Preencher os ComboBox
            ListarEquipamento();
            ListarLocal();
            ListarSetor();
            cmbData.Texts = DateTime.Now.ToString("dd/MM/yyyy");
        }

        #region Método Salvar, Limpar e Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close(); // Ajustar para retornar a tela anterior
            UsuarioDAO dao = new UsuarioDAO();
            Usuario obj = new Usuario();
            obj = dao.ConsultarPermissoesDoUsuario(id);
            if (obj.parametro11 != "S")
                ColocarChamadoNoPainel(new Frmchamadoscliente(id));

            //Se for um técnico - Parâmetro
            if (obj.parametro11 == "S")
                ColocarChamadoNoPainel(new Frmchamados(id));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComboBox();
            cmbEquipamento.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ChamadoDAO dao = new ChamadoDAO();
            Chamado obj = new Chamado();
            obj.solicitante = txtsolicitante.Text;
            obj.responsavel = "Suporte";
            obj.status = "Novo";
            obj.urgencia = "Sem";
            obj.titulo = txtTitulo.Text;
            obj.descricao = rtbdescricao.Text;
            obj.data = DateTime.Now.ToString("dd/MM/yyyy");
            obj.horario = DateTime.Now.ToString("HH:mm");
            if (cmbEquipamento.SelectedIndex != -1)
                obj.equipamento = cmbEquipamento.Texts;
            if (cmbLocal.SelectedIndex != -1)
                obj.localizacao = cmbLocal.Texts;
            if (cmbSetor.SelectedIndex != -1)
                obj.setor = cmbSetor.Texts;

            //Inserindo o usuário no banco
            if (dao.VerificarCampos(obj))
            {
                //Corrigindo valor dos ComboBox
                //obj.setor = dao.VerificaSetor(obj).setor;
                //obj.localizacao = dao.VerificaLocal(obj).localizacao;
                //obj.equipamento = dao.VerificaEquipamento(obj).equipamento;

                //Inserindo ao banco
                dao.CadastrarChamado(obj);
                new Helpers().LimparTelaNovoTextBox(this);
                LimparComboBox();

                if (MessageBox.Show("Deseja Continuar abrindo chamados?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ColocarChamadoNoPainel(new Frmabrirchamados(id));
                }
                else
                {
                    UsuarioDAO daos = new UsuarioDAO();
                    Usuario objs = new Usuario();
                    objs = daos.ConsultarPermissoesDoUsuario(id);
                    if (objs.parametro11 != "S")
                        ColocarChamadoNoPainel(new Frmchamadoscliente(id));

                    //Se for um técnico - Parâmetro
                    if (objs.parametro11 == "S")
                        ColocarChamadoNoPainel(new Frmchamados(id));
                }
            }
        }
        #endregion

        #region Método para Limpar as CheckBox
        private void LimparComboBox()
        {
            //Método para Limpar a ComboBox Setor
            cmbEquipamento.SelectedIndex = -1;
            cmbLocal.SelectedIndex = -1;
            cmbSetor.SelectedIndex = -1;
            cmbEquipamento.Texts = null;
            cmbLocal.Texts = null;
            cmbSetor.Texts = null;
            txtTitulo.Text = null;
            rtbdescricao.Text = null;
        }
        #endregion

        #region Listar Localização
        private void ListarLocal()
        {
            //Preencher os ComboBox
            ChamadoDAO dao = new ChamadoDAO();

            //Localização
            cmbLocal.Items.Clear();
            cmbLocal.DataSource = dao.ListarLocal();
            cmbLocal.DisplayMember = "nome";
            cmbLocal.ValueMember = "id";

            //Selecionar os campos limpos ao iniciar
            cmbLocal.SelectedIndex = -1;
        }

        #endregion

        #region Listar Setor
        private void ListarSetor()
        {
            //Preencher os ComboBox
            ChamadoDAO dao = new ChamadoDAO();

            //Setor
            cmbSetor.Items.Clear();
            cmbSetor.DataSource = dao.ListarSetor();
            cmbSetor.DisplayMember = "nome";
            cmbSetor.ValueMember = "id";

            //Selecionar os campos limpos ao iniciar
            cmbSetor.SelectedIndex = -1;
        }

        #endregion

        #region Listar Equipamento
        private void ListarEquipamento()
        {
            //Preencher os ComboBox
            ChamadoDAO dao = new ChamadoDAO();

            //Equipamento
            cmbEquipamento.Items.Clear();
            cmbEquipamento.DataSource = dao.ListarEquipamento();
            cmbEquipamento.DisplayMember = "equipamento";
            cmbEquipamento.ValueMember = "id";

            //Selecionar os campos limpos ao iniciar
            cmbEquipamento.SelectedIndex = -1;
        }
        #endregion

        #region Método para colocar os Formulários no Painel
        public void ColocarChamadoNoPainel(object Formulario)
        {
            formularioAtual = this;

            Form fh = Formulario as Form;
            formularioAtual = fh;

            Size f = new Size(0, 0);
            Size p = new Size(1100, 630);
            panel1.Size = f;
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
    }
}
