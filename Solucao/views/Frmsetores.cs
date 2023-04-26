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
    public partial class Frmsetores : Form
    {
        private string id;
        Usuario perm = new Usuario();
        public Frmsetores(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Frmsetores_Load(object sender, EventArgs e)
        {
            //Permissões da tela
            UsuarioDAO daoperm = new UsuarioDAO();
            perm = daoperm.ConsultarPermissoesDoUsuario(id);
        }

        #region Setor
        private void btnSalvarSetor_Click(object sender, EventArgs e)
        {
                if (perm.parametro8 == "S")
                {
                    CadastroDAO dao = new CadastroDAO();
                    if (txtcodigosetor.Text == "0")
                    {
                        //Salvar / Editar Usuários
                        Cadastro obj = new Cadastro();

                        //Atributos
                        obj.definicao = "S";
                        obj.nome = txtsetor.Text;
                        if(cmbetiquetasetor.SelectedIndex != -1)
                            obj.etiqueta = cmbetiquetasetor.SelectedItem.ToString();
                        obj.tag = txttagsetor.Text;

                        //Inserindo o usuário no banco
                        if (dao.VerificarCamposSetor(obj))
                        {
                            dao.CadastrarCadastroSetor(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBoxSetor();
                        }
                    }
                    else if (txtcodigosetor.Text != "" && txtsetor.Text != "")
                    {
                        //Salvar / Editar Usuários
                        Cadastro obj = new Cadastro();

                        //Atributos
                        obj.id = int.Parse(txtcodigosetor.Text);
                        obj.definicao = "S";
                        obj.nome = txtsetor.Text;
                        if (cmbetiquetasetor.SelectedIndex != -1)
                            obj.etiqueta = cmbetiquetasetor.SelectedItem.ToString();
                        obj.tag = txttagsetor.Text;


                        //Editando os dados do usuário
                        if (dao.VerificarCamposSetor(obj))
                        {
                            dao.EditarCadastroSetor(obj);

                            //Limpar Formulário
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBoxSetor();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clique em Novo para assim cadastrar um novo Setor!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovoSetor_Click(object sender, EventArgs e)
        {
            if (perm.parametro8 == "S")
            {
                //Novo Usuário
                new Helpers().LimparTelaNovoTextBox(this);
                LimparComboBoxSetor();
                txtcodigosetor.Text = "0";
                txtsetor.Focus();
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluirSetor_Click(object sender, EventArgs e)
        {
            //Excluír setor
            if (perm.parametro8 == "S")
            {
                try
                {
                    if (txtcodigosetor.Text == "0" || txtcodigosetor.Text == string.Empty)
                    {
                        MessageBox.Show("Digite o código do setor a ser excluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigosetor.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluír o setor " + txtcodigosetor.Text + " - " + txtsetor.Text + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Excluir Usuário
                            Cadastro obj = new Cadastro();
                            obj.id = int.Parse(txtcodigosetor.Text);
                            obj.nome = txtsetor.Text;

                            //Leva Usuário para excluir
                            CadastroDAO dao = new CadastroDAO();
                            dao.ExcluirCadastroSetor(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBoxSetor();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite o código do Setor a ser excluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodigosetor.Focus();
                }
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Eventos
        private void txtcodigosetor_Leave(object sender, EventArgs e)
        {
            try
            {
                //Consultar o código do usuário ao sair do campo código
                Cadastro obj = new Cadastro();
                Cadastro model = new Cadastro();
                obj.id = int.Parse(txtcodigosetor.Text);

                //Atributos e validações
                if (obj.nome == string.Empty && obj.id.ToString() != "0")
                {
                    MessageBox.Show("Não foi encontrado o código do Setor", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtcodigo.Focus();
                }
                else
                {
                    //Chama o método
                    CadastroDAO dao = new CadastroDAO();
                    model = dao.ConsultarCodigoDoCadastroSetor(obj);

                    //Atributos
                    txtsetor.Text = model.nome;
                    if(model.etiqueta == "Sim")
                        cmbetiquetasetor.SelectedIndex = 0;
                    if (model.etiqueta == "Não")
                        cmbetiquetasetor.SelectedIndex = 1;
                    txttagsetor.Text = model.tag;

                    if (model.nome == string.Empty)
                    {
                        MessageBox.Show("Não foi encontrado o código do Setor", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigosetor.Focus();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbetiquetasetor_Leave(object sender, EventArgs e)
        {
            //Corrigir campo em "branco" na Etiqueta
            if (cmbetiquetasetor.SelectedIndex != -1)
            {
                if (cmbetiquetasetor.SelectedIndex == 1)
                {
                    txttagsetor.Enabled = false;
                    txttagsetor.Text = "Sem etiqueta";
                }
                else if (cmbetiquetasetor.SelectedItem.ToString() == "Sim")
                {
                    txttagsetor.Enabled = true;
                    txttagsetor.Text = null;
                }
                else
                {
                    cmbetiquetasetor.SelectedIndex = -1;
                    txttagsetor.Enabled = false;
                    txttagsetor.Text = null;
                }
            }
            else
            {
                cmbetiquetasetor.SelectedIndex = -1;
                txttagsetor.Enabled = false;
                txttagsetor.Text = null;
            }
        }
        #endregion

        #endregion

        #region Localização
        private void btnSalvarLocal_Click(object sender, EventArgs e)
        {
            if (perm.parametro8 == "S")
            {
                CadastroDAO dao = new CadastroDAO();
                if (txtcodigolocal.Text == "0")
                {
                    //Salvar / Editar Usuários
                    Cadastro obj = new Cadastro();

                    //Atributos
                    obj.definicao = "L";
                    obj.nome = txtlocal.Text;
                    if (cmbetiquetalocal.SelectedIndex != -1)
                        obj.etiqueta = cmbetiquetalocal.SelectedItem.ToString();
                    obj.tag = txttaglocal.Text;

                    //Inserindo o usuário no banco
                    if (dao.VerificarCamposLocal(obj))
                    {
                        dao.CadastrarCadastroLocal(obj);
                        new Helpers().LimparTelaNovoTextBox(this);
                        LimparComboBoxLocal();
                    }
                }
                else if (txtcodigolocal.Text != "" && txtlocal.Text != "")
                {
                    //Salvar / Editar Usuários
                    Cadastro obj = new Cadastro();

                    //Atributos
                    obj.id = int.Parse(txtcodigolocal.Text);
                    obj.definicao = "L";
                    obj.nome = txtlocal.Text;
                    if (cmbetiquetalocal.SelectedIndex != -1)
                        obj.etiqueta = cmbetiquetalocal.SelectedItem.ToString();
                    obj.tag = txttaglocal.Text;


                    //Editando os dados do usuário
                    if (dao.VerificarCamposLocal(obj))
                    {
                        dao.EditarCadastroLocal(obj);

                        //Limpar Formulário
                        new Helpers().LimparTelaNovoTextBox(this);
                        LimparComboBoxLocal();
                    }
                }
                else
                {
                    MessageBox.Show("Clique em Novo para assim cadastrar uma nova Localização!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovoLocal_Click(object sender, EventArgs e)
        {
            if (perm.parametro8 == "S")
            {
                //Novo Usuário
                new Helpers().LimparTelaNovoTextBox(this);
                LimparComboBoxLocal();
                txtcodigolocal.Text = "0";
                txtlocal.Focus();
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluirLocal_Click(object sender, EventArgs e)
        {
            //Excluír usuário
            if (perm.parametro8 == "S")
            {
                try
                {
                    if (txtcodigolocal.Text == "0" || txtcodigolocal.Text == string.Empty)
                    {
                        MessageBox.Show("Digite o código da Localização a ser excluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigolocal.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluír a Localização " + txtcodigolocal.Text + " - " + txtlocal.Text + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Excluir Usuário
                            Cadastro obj = new Cadastro();
                            obj.id = int.Parse(txtcodigolocal.Text);
                            obj.nome = txtlocal.Text;

                            //Leva Usuário para excluir
                            CadastroDAO dao = new CadastroDAO();
                            dao.ExcluirCadastroLocal(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparComboBoxLocal();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite o código da Localização a ser excluída!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodigolocal.Focus();
                }
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Eventos
        private void txtcodigolocal_Leave(object sender, EventArgs e)
        {
            try
            {
                //Consultar o código do usuário ao sair do campo código
                Cadastro obj = new Cadastro();
                Cadastro model = new Cadastro();
                obj.id = int.Parse(txtcodigolocal.Text);

                //Atributos e validações
                if (obj.nome == string.Empty && obj.id.ToString() != "0")
                {
                    MessageBox.Show("Não foi encontrado o código da Localização", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtcodigo.Focus();
                }
                else
                {
                    //Chama o método
                    CadastroDAO dao = new CadastroDAO();
                    model = dao.ConsultarCodigoDoCadastroLocal(obj);

                    //Atributos
                    txtlocal.Text = model.nome;
                    if (model.etiqueta == "Sim")
                        cmbetiquetalocal.SelectedIndex = 0;
                    if (model.etiqueta == "Não")
                        cmbetiquetalocal.SelectedIndex = 1;
                    txttaglocal.Text = model.tag;

                    if (model.nome == string.Empty)
                    {
                        MessageBox.Show("Não foi encontrado o código da Localização", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigolocal.Focus();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbetiquetalocal_Leave(object sender, EventArgs e)
        {
            //Corrigir campo em "branco" na Etiqueta
            if(cmbetiquetalocal.SelectedIndex != -1)
            {
                if (cmbetiquetalocal.SelectedIndex == 1)
                {
                    txttaglocal.Enabled = false;
                    txttaglocal.Text = "Sem etiqueta";
                }
                else if (cmbetiquetalocal.SelectedItem.ToString() == "Sim")
                {
                    cmbetiquetalocal.SelectedIndex = 0;
                    txttaglocal.Enabled = true;
                    txttaglocal.Text = null;
                }
                else
                {
                    cmbetiquetalocal.SelectedIndex = -1;
                    txttaglocal.Enabled = false;
                    txttaglocal.Text = null;
                }
            }
            else
            {
                cmbetiquetalocal.SelectedIndex = -1;
                txttaglocal.Enabled = false;
                txttaglocal.Text = null;
            }
        }
        #endregion

        #endregion

        #region Método para Limpar as CheckBox
        private void LimparComboBoxSetor()
        {
            //Método para Limpar a ComboBox Setor
            cmbetiquetasetor.SelectedIndex = -1;
            txtsetor.Text = null;
            txttagsetor.Text = null;
            txtcodigosetor.Text = null;
            txttagsetor.Enabled = false;
        }

        private void LimparComboBoxLocal()
        {
            //Método para Limpar a ComboBox Localização
            cmbetiquetalocal.SelectedIndex = -1;
            txtlocal.Text = null;
            txttaglocal.Text = null;
            txtcodigolocal.Text = null;
            txttaglocal.Enabled = false;
        }
        #endregion
    }
}
