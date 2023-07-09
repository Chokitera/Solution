using Solucao.dao;
using Solucao.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.views
{
    public partial class Frmlogin : Form
    {
        //Construtor
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            //Preencher o horário e Data
            tmrHorario.Enabled = true;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {
            //Preencher o horário e Data
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #region Ajustes da Parte Superior dos Formulários
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Visual dos TextBox Usuário e Senha
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "CÓD.")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(28,28,28);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            LoginDAO loginDAO = new LoginDAO();
            if(txtUsuario.Text == "")
            {
                txtNomeUsuario.Text = "USUÁRIO";
                txtUsuario.Text = "CÓD.";
                txtUsuario.ForeColor = Color.DimGray;
            }

            //Adiciona o nome do Usuário em "Usuário"
            if(txtUsuario.Text != "CÓD." && txtUsuario.Text != "")
            {
                string nomeUsuario = "";
                if(int.Parse(txtUsuario.Text) > 0)
                    nomeUsuario = loginDAO.ConsultaNomeUsuario(int.Parse(txtUsuario.Text));

                if (nomeUsuario == "")
                {
                    txtNomeUsuario.Text = "USUÁRIO";
                    MessageBox.Show("Nome de Usuário inexistente!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
                else
                    txtNomeUsuario.Text = nomeUsuario;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.FromArgb(28,28,28);
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Ajustes para Logar no sistema
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Atributos para o Login
                Login obj = new Login();
                obj.id = int.Parse(txtUsuario.Text);
                obj.senha = txtSenha.Text;

                //Realizar a tentativa de Login
                LoginDAO dao = new LoginDAO();
                if (dao.EfetuarLogin(obj))
                {
                    //Levar os dados do usuário ao método UsuarioLogado
                    Form1 frm1 = new Form1(obj);
                    frm1.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O campo Usuário não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    //Atributos para o Login
                    Login obj = new Login();
                    obj.id = int.Parse(txtUsuario.Text);
                    obj.senha = txtSenha.Text;

                    //Realizar a tentativa de Login
                    LoginDAO dao = new LoginDAO();
                    if (dao.EfetuarLogin(obj))
                    {
                        //Levar o email ao método UsuarioLogado
                        Form1 frm1 = new Form1(obj);
                        frm1.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("O campo Usuário não está preenchido!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
            // Permite somente a entrada numérica
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
            }
        }
        #endregion
    }
}
