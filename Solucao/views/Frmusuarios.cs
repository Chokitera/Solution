using Solucao.dao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.views
{
    public partial class Frmusuarios : Form
    {
        private string id;
        Usuario perm = new Usuario();
        public Frmusuarios(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Frmusuarios_Load(object sender, EventArgs e)
        {
            txtcodigo.Focus();

            //Permissões da tela
            UsuarioDAO daoperm = new UsuarioDAO();
            perm = daoperm.ConsultarPermissoesDoUsuario(id);
        }

        #region Salvar, Excluir, Novo e Preencher Dados a Partir do Código
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (perm.parametro9 == "S" || perm.parametro12 == "S")
            {
                UsuarioDAO dao = new UsuarioDAO();
                if (txtcodigo.Text == "0")
                {
                    //Salvar / Editar Usuários
                    Usuario obj = new Usuario();

                    //Atributos
                    obj.nome = txtnome.Text;
                    obj.email = txtemail.Text;
                    obj.senha = txtsenha.Text;
                    obj.setor = txtsetor.Text;
                    obj.localizacao = txtlocal.Text;

                    //Adicionar os parametros aos usuários
                    if (ckbAcessoChamados1.Checked)
                        obj.parametro1 = "S";
                    if (ckbAcessoEstoque2.Checked)
                        obj.parametro2 = "S";
                    if (ckbAcessoUsuarios3.Checked)
                        obj.parametro3 = "S";
                    if (ckbAcessoMaquinas4.Checked)
                        obj.parametro4 = "S";
                    if (ckbAcessoSetores5.Checked)
                        obj.parametro5 = "S";
                    if (ckbPermiteConsultar6.Checked)
                        obj.parametro6 = "S";
                    if (ckbAbrirChamados7.Checked)
                        obj.parametro7 = "S";
                    if (ckbCadastrarProdutos8.Checked)
                        obj.parametro8 = "S";
                    if (ckbCadastrarUsuarios9.Checked)
                        obj.parametro9 = "S";
                    if (ckbCadastrarMaquinas10.Checked)
                        obj.parametro10 = "S";
                    if (ckbUsuarioTecnico11.Checked)
                        obj.parametro11 = "S";
                    if (ckbUsuarioAdministrador12.Checked)
                        obj.parametro12 = "S";

                    if (ckbAcessoChamados1.Checked == false)
                        obj.parametro1 = "N";
                    if (ckbAcessoEstoque2.Checked == false)
                        obj.parametro2 = "N";
                    if (ckbAcessoUsuarios3.Checked == false)
                        obj.parametro3 = "N";
                    if (ckbAcessoMaquinas4.Checked == false)
                        obj.parametro4 = "N";
                    if (ckbAcessoSetores5.Checked == false)
                        obj.parametro5 = "N";
                    if (ckbPermiteConsultar6.Checked == false)
                        obj.parametro6 = "N";
                    if (ckbAbrirChamados7.Checked == false)
                        obj.parametro7 = "N";
                    if (ckbCadastrarProdutos8.Checked == false)
                        obj.parametro8 = "N";
                    if (ckbCadastrarUsuarios9.Checked == false)
                        obj.parametro9 = "N";
                    if (ckbCadastrarMaquinas10.Checked == false)
                        obj.parametro10 = "N";
                    if (ckbUsuarioTecnico11.Checked == false)
                        obj.parametro11 = "N";
                    if (ckbUsuarioAdministrador12.Checked == false)
                        obj.parametro12 = "N";

                    //Inserindo o usuário no banco
                    if (dao.VerificarCampos(obj))
                    {
                        dao.CadastrarUsuarios(obj);
                        new Helpers().LimparTelaNovoTextBox(this);
                        LimparCheckBox();
                    }
                }
                else if (txtcodigo.Text != "" && txtnome.Text != "")
                {
                    //Salvar / Editar Usuários
                    Usuario obj = new Usuario();

                    //Atributos
                    obj.id = int.Parse(txtcodigo.Text);
                    obj.nome = txtnome.Text;
                    obj.email = txtemail.Text;
                    obj.senha = txtsenha.Text;
                    obj.setor = txtsetor.Text;
                    obj.localizacao = txtlocal.Text;

                    //Adicionar os parametros aos usuários
                    if (ckbAcessoChamados1.Checked)
                        obj.parametro1 = "S";
                    if (ckbAcessoEstoque2.Checked)
                        obj.parametro2 = "S";
                    if (ckbAcessoUsuarios3.Checked)
                        obj.parametro3 = "S";
                    if (ckbAcessoMaquinas4.Checked)
                        obj.parametro4 = "S";
                    if (ckbAcessoSetores5.Checked)
                        obj.parametro5 = "S";
                    if (ckbPermiteConsultar6.Checked)
                        obj.parametro6 = "S";
                    if (ckbAbrirChamados7.Checked)
                        obj.parametro7 = "S";
                    if (ckbCadastrarProdutos8.Checked)
                        obj.parametro8 = "S";
                    if (ckbCadastrarUsuarios9.Checked)
                        obj.parametro9 = "S";
                    if (ckbCadastrarMaquinas10.Checked)
                        obj.parametro10 = "S";
                    if (ckbUsuarioTecnico11.Checked)
                        obj.parametro11 = "S";
                    if (ckbUsuarioAdministrador12.Checked)
                        obj.parametro12 = "S";

                    if (ckbAcessoChamados1.Checked == false)
                        obj.parametro1 = "N";
                    if (ckbAcessoEstoque2.Checked == false)
                        obj.parametro2 = "N";
                    if (ckbAcessoUsuarios3.Checked == false)
                        obj.parametro3 = "N";
                    if (ckbAcessoMaquinas4.Checked == false)
                        obj.parametro4 = "N";
                    if (ckbAcessoSetores5.Checked == false)
                        obj.parametro5 = "N";
                    if (ckbPermiteConsultar6.Checked == false)
                        obj.parametro6 = "N";
                    if (ckbAbrirChamados7.Checked == false)
                        obj.parametro7 = "N";
                    if (ckbCadastrarProdutos8.Checked == false)
                        obj.parametro8 = "N";
                    if (ckbCadastrarUsuarios9.Checked == false)
                        obj.parametro9 = "N";
                    if (ckbCadastrarMaquinas10.Checked == false)
                        obj.parametro10 = "N";
                    if (ckbUsuarioTecnico11.Checked == false)
                        obj.parametro11 = "N";
                    if (ckbUsuarioAdministrador12.Checked == false)
                        obj.parametro12 = "N";

                    //Editando os dados do usuário
                    if (dao.VerificarCampos(obj))
                    {
                        dao.EditarUsuarios(obj);

                        //Dar permissões para acessar os menus - Já atualiza as permissões após a modificação
                        // CRIAR ALGO AINDA...

                        //Limpar Formulário
                        new Helpers().LimparTelaNovoTextBox(this);
                        LimparCheckBox();
                    }
                }
                else
                {
                    MessageBox.Show("Clique em Novo para assim cadastrar um novo usuário!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(perm.parametro12 == "S")
            {
                //Novo Usuário
                new Helpers().LimparTelaNovoTextBox(this);
                LimparCheckBox();
                txtcodigo.Text = "0";
                txtnome.Focus();
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(perm.parametro12 == "S")
            {
                try
                {
                    if (txtcodigo.Text == "0" || txtcodigo.Text == string.Empty)
                    {
                        MessageBox.Show("Digite o código do Usuário a ser excluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluír o Usuário " + txtcodigo.Text + " - " + txtnome.Text + "?", "Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Excluir Usuário
                            Usuario obj = new Usuario();
                            obj.id = int.Parse(txtcodigo.Text);
                            obj.nome = txtnome.Text;

                            //Leva Usuário para excluir
                            UsuarioDAO dao = new UsuarioDAO();
                            dao.ExcluirUsuario(obj);
                            new Helpers().LimparTelaNovoTextBox(this);
                            LimparCheckBox();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite o código do Usuário a ser excluído!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodigo.Focus();
                }
            }
            else
                MessageBox.Show("Usuário sem permissão!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                LimparCheckBox();
                //Consultar o código do usuário ao sair do campo código
                Usuario obj = new Usuario();
                Usuario model = new Usuario();
                obj.id = int.Parse(txtcodigo.Text);

                //Atributos e validações
                if (obj.nome == string.Empty && obj.id.ToString() != "0")
                {
                    MessageBox.Show("Não foi encontrado o código do Usuário", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtcodigo.Focus();
                }
                else
                {
                    //Chama o método
                    UsuarioDAO dao = new UsuarioDAO();
                    model = dao.ConsultarCodigoDoUsuario(obj);

                    txtnome.Text = model.nome;
                    txtsenha.Text = model.senha;
                    txtemail.Text = model.email;
                    txtsetor.Text = model.setor;
                    txtlocal.Text = model.localizacao;

                    //Passando os parametros
                    if (model.parametro1 == "S")
                        ckbAcessoChamados1.Checked = true;
                    if (model.parametro2 == "S")
                        ckbAcessoEstoque2.Checked = true;
                    if (model.parametro3 == "S")
                        ckbAcessoUsuarios3.Checked = true;
                    if (model.parametro4 == "S")
                        ckbAcessoMaquinas4.Checked = true;
                    if (model.parametro5 == "S")
                        ckbAcessoSetores5.Checked = true;
                    if (model.parametro6 == "S")
                        ckbPermiteConsultar6.Checked = true;
                    if (model.parametro7 == "S")
                        ckbAbrirChamados7.Checked = true;
                    if (model.parametro8 == "S")
                        ckbCadastrarProdutos8.Checked = true;
                    if (model.parametro9 == "S")
                        ckbCadastrarUsuarios9.Checked = true;
                    if (model.parametro10 == "S")
                        ckbCadastrarMaquinas10.Checked = true;
                    if (model.parametro11 == "S")
                        ckbUsuarioTecnico11.Checked = true;
                    if (model.parametro12 == "S")
                        ckbUsuarioAdministrador12.Checked = true;


                    if (model.nome == string.Empty)
                    {
                        MessageBox.Show("Não foi encontrado o código do Usuário", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo.Focus();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Digite o código do usuário ou clique em Novo.", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtcodigo.Focus();
            }
        }
        #endregion

        #region Eventos KeyPress > Apertar Enter
        private void btnSalvar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar_Click(sender, e);
            }
        }

        private void btnNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnNovo_Click(sender, e);
            }
        }

        private void btnExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnExcluir_Click(sender, e);
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnome.Focus();
            }
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtsenha.Focus();
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtsetor.Focus();
            }
        }

        private void txtsetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtlocal.Focus();
            }
        }

        private void txtlocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
            }
        }
        #endregion

        #region Método para Limpar as CheckBox
        private void LimparCheckBox()
        {
                //Método para Limpar as CheckBox
                ckbAcessoChamados1.Checked = false;
                ckbAcessoEstoque2.Checked = false;
                ckbAcessoUsuarios3.Checked = false;
                ckbAcessoMaquinas4.Checked = false;
                ckbAcessoSetores5.Checked = false;
                ckbPermiteConsultar6.Checked = false;
                ckbAbrirChamados7.Checked = false;
                ckbCadastrarProdutos8.Checked = false;
                ckbCadastrarUsuarios9.Checked = false;
                ckbCadastrarMaquinas10.Checked = false;
                ckbUsuarioTecnico11.Checked = false;
                ckbUsuarioAdministrador12.Checked = false;
        }
        #endregion
    }
}
