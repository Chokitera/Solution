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
    public partial class Frmmaquinas : Form
    {
        private string id;
        Usuario perm = new Usuario();
        public Frmmaquinas(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Frmmaquinas_Load(object sender, EventArgs e)
        {
            //Permissões da tela
            UsuarioDAO daoperm = new UsuarioDAO();
            perm = daoperm.ConsultarPermissoesDoUsuario(id);

            //Preencher os ComboBox
            ListarLocal();
            ListarSetor();
        }

        #region Método Salvar, Editar e Nova Máquina
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (perm.parametro10 == "S")
                {
                    MaquinaDAO dao = new MaquinaDAO();
                    if (txtcodigo.Text == "0")
                    {
                        //Salvar / Editar Usuários
                        Maquina obj = new Maquina();

                        //Atributos
                        obj.equipamento = txtequipamento.Text;
                        if (cmbsituacao.SelectedIndex != -1)
                            obj.situacao = cmbsituacao.SelectedItem.ToString();
                        if (cmblocal.SelectedIndex != -1)
                            obj.localizacao = cmblocal.Texts;
                        if (cmbsetor.SelectedIndex != -1)
                            obj.setor = cmbsetor.Texts;
                        if (txtncm.Text != null && txtncm.Text.Length > 0)
                            obj.ncm = int.Parse(txtncm.Text);
                        if (txtCusto.Text != null && txtCusto.Text.Length > 0)
                            obj.garantia = txtCusto.Text;
                        obj.plano = cmbPlano.Texts;

                        //Inserindo o usuário no banco
                        if (dao.VerificarCampos(obj))
                        {
                            //Corrigindo valor dos ComboBox
                            //obj.setor = dao.VerificaSetor(obj).setor;
                            //obj.localizacao = dao.VerificaLocal(obj).localizacao;

                            //Inserindo ao banco
                            dao.CadastrarMaquina(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBox();
                        }
                    }
                    else if (txtcodigo.Text != "" && txtequipamento.Text != "")
                    {
                        //Salvar / Editar Usuários
                        Maquina obj = new Maquina();

                        //Atributos
                        obj.id = int.Parse(txtcodigo.Text);
                        obj.equipamento = txtequipamento.Text;
                        if (cmbsituacao.SelectedIndex != -1 || cmbsituacao.Texts.Length > 0)
                            obj.situacao = cmbsituacao.SelectedItem.ToString();
                        if (cmblocal.SelectedIndex != -1 || cmblocal.Texts.Length > 0)
                            obj.localizacao = cmblocal.Texts;
                        if (cmbsetor.SelectedIndex != -1 || cmbsetor.Texts.Length > 0)
                            obj.setor = cmbsetor.Texts;
                        if (txtncm.Text != null)
                            obj.ncm = int.Parse(txtncm.Text);
                        if (txtCusto.Text != null)
                            obj.garantia = txtCusto.Text;
                        obj.plano = cmbPlano.Texts;


                        //Editando os dados do usuário
                        if (dao.RevisarCampos(obj))
                        {
                            //Corrigindo valor dos ComboBox
                            //obj.setor = dao.VerificaSetor(obj).setor;
                            //obj.localizacao = dao.VerificaLocal(obj).localizacao;

                            //Inserindo ao banco
                            dao.EditarMaquina(obj);

                            //Limpar Formulário
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBox();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Clique em Novo para assim cadastrar uma nova Máquina!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (perm.parametro10 == "S")
            {
                //Novo Usuário
                new Helpers().LimparTelaNovoTextBox(this);
                LimparComboBox();
                txtcodigo.Text = "0";
                txtequipamento.Focus();
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Excluír setor
            if (perm.parametro10 == "S")
            {
                try
                {
                    if (txtcodigo.Text == "0" || txtcodigo.Text == string.Empty)
                    {
                        MessageBox.Show("Digite o código da Máquina a ser excluída!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluír a Máquina " + txtcodigo.Text + " - " + txtequipamento.Text + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Excluir Usuário
                            Maquina obj = new Maquina();
                            obj.id = int.Parse(txtcodigo.Text);
                            obj.equipamento = txtequipamento.Text;

                            //Leva Usuário para excluir
                            MaquinaDAO dao = new MaquinaDAO();
                            dao.ExcluirMaquina(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBox();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite o código da Máquina a ser excluída!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodigo.Focus();
                }
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Eventos
        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                //Consultar o código do usuário ao sair do campo código
                Maquina obj = new Maquina();
                Maquina model = new Maquina();
                obj.id = int.Parse(txtcodigo.Text);

                //Atributos e validações
                if (obj.equipamento == string.Empty && obj.id.ToString() != "0")
                {
                    MessageBox.Show("Não foi encontrado o código do Setor", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Chama o método
                    MaquinaDAO dao = new MaquinaDAO();
                    model = dao.ConsultarCodigoDaMaquina(obj);

                    //Atributos
                    txtequipamento.Text = model.equipamento;
                    if (model.setor != null)
                        cmbsetor.Texts = model.setor;
                    if (model.localizacao != null)
                        cmblocal.Texts = model.localizacao;
                    if (model.situacao == "Ativo")
                        cmbsituacao.SelectedIndex = 0;
                    else if (model.situacao == "Inativo")
                        cmbsituacao.SelectedIndex = 1;
                    txtncm.Text = model.ncm.ToString();
                    txtCusto.Text = model.garantia.ToString();
                    if (model.plano != null)
                        cmbPlano.Texts = model.plano;

                    if (model.equipamento == string.Empty)
                    {
                        MessageBox.Show("Não foi encontrado o código do Setor", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo.Focus();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Método para Limpar as CheckBox
        private void LimparComboBox()
        {
            //Método para Limpar a ComboBox Setor
            cmbsituacao.SelectedIndex = -1;
            cmblocal.SelectedIndex = -1;
            cmbsetor.SelectedIndex = -1;
            cmbPlano.SelectedIndex = -1;
            cmbsituacao.Texts = null;
            cmblocal.Texts = null;
            cmbsetor.Texts = null;
            txtcodigo.Text = null;
            txtequipamento.Text = null;
            txtncm.Text = null;
            txtCusto.Text = null;
        }
        #endregion

        #region Listar Localização
        private void ListarLocal()
        {
            //Preencher os ComboBox
            MaquinaDAO dao = new MaquinaDAO();

            //Localização
            cmblocal.Items.Clear();
            cmblocal.DataSource = dao.ListarLocal();
            cmblocal.DisplayMember = "nome";
            cmblocal.ValueMember = "id";

            //Selecionar os campos limpos ao iniciar
            cmbsituacao.SelectedIndex = -1;
            cmblocal.SelectedIndex = -1;
        }

        #endregion

        #region Listar Setor
        private void ListarSetor()
        {
            //Preencher os ComboBox
            MaquinaDAO dao = new MaquinaDAO();

            //Setor
            cmbsetor.Items.Clear();
            cmbsetor.DataSource = dao.ListarSetor();
            cmbsetor.DisplayMember = "nome";
            cmbsetor.ValueMember = "id";

            //Selecionar os campos limpos ao iniciar
            cmbsituacao.SelectedIndex = -1;
            cmbsetor.SelectedIndex = -1;
        }

        #endregion
    }
}
