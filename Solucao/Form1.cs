using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Solucao.views;
using Solucao.models;
using Solucao.dao;

namespace Solucao
{
    public partial class Form1 : Form
    {
        //Atributos
        private Form formularioAtual;
        private string id;

        //Construtor
        public Form1(Login obj)
        {
            this.id = obj.id.ToString();
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Parâmetros para verificações
            //Recebendo os dados dos parâmetros para dar permissões aos usuários
            UsuarioDAO daoperm = new UsuarioDAO();
            Usuario perm = new Usuario();
            perm = daoperm.ConsultarPermissoesDoUsuario(id);

            //Dar permissões para acessar os menus
            if (perm.parametro1 != "S")
                btnChamados.Enabled = false;
            if (perm.parametro2 != "S")
                btnEstoque.Enabled = false;
            if (perm.parametro3 != "S")
                btnUsuarios.Enabled = false;
            if (perm.parametro4 != "S")
                btnMaquinas.Enabled = false;
            if (perm.parametro5 != "S")
                btnSetores.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iniciar com o Formulário Principal aberto
            ColocarFormNoPainel(new Frmprincipal(id));

            //Recebendo os dados dos parâmetros para dar permissões aos usuários
            UsuarioDAO dao = new UsuarioDAO();
            Usuario obj = new Usuario();
            obj = dao.ConsultarPermissoesDoUsuario(id);

            //Dar permissões para acessar os menus
            if (obj.parametro1 != "S")
                btnChamados.Enabled = false;
            if (obj.parametro2 != "S")
                btnEstoque.Enabled = false;
            if (obj.parametro3 != "S")
                btnUsuarios.Enabled = false;
            if (obj.parametro4 != "S")
                btnMaquinas.Enabled = false;
            if (obj.parametro5 != "S")
                btnSetores.Enabled = false;
        }

        #region Ajustes da Parte Superior dos Formulários
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 75;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                iconRestaurar.Visible = false;
                iconMaximizar.Visible = true;
            }
        }

        private void BarraTitulo_DoubleClick(object sender, EventArgs e)
        {
            //Tentar corrigir isso, se possível
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                iconRestaurar.Visible = false;
                iconMaximizar.Visible = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                iconRestaurar.Visible = true;
                iconMaximizar.Visible = false;
            }
        }

        #endregion

        #region Método para colocar os Formulários no Painel
        public void ColocarFormNoPainel(object Formulario)
        {
            //Limpar o antigo Formulário
            if(formularioAtual != null)
            {
                formularioAtual.Close();
            }
            Form fh = Formulario as Form;
            formularioAtual = fh;

            if(this.panelConteudo.Controls.Count > 0)
            {
                this.panelConteudo.Controls.RemoveAt(0);
            }
            
            //Preencher o novo formulário
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(fh);
            this.panelConteudo.Tag = fh;
            fh.Show();
        }
        #endregion

        #region Botões de acessos dos Formulários
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            //Altera a cor da Logo do Principal
            ColocarFormNoPainel(new Frmprincipal(id));
            btnPrincipalColorido.Visible = true;
            btnChamadosColorido.Visible  = false;
            btnEstoqueColorido.Visible   = false;
            btnUsuariosColorido.Visible  = false;
            btnMaquinasColorido.Visible  = false;
            btnSetoresColorido.Visible   = false;
        }

        public void btnChamados_Click(object sender, EventArgs e)
        {
            //Recebendo os dados dos parâmetros para dar permissões aos usuários
            UsuarioDAO dao = new UsuarioDAO();
            Usuario obj = new Usuario();
            obj = dao.ConsultarPermissoesDoUsuario(id);
            //Se for um Usuário - Parâmetro
            if (obj.parametro11 != "S")
                ColocarFormNoPainel(new Frmchamadoscliente(id));

             //Se for um técnico - Parâmetro
            if (obj.parametro11 == "S")
                ColocarFormNoPainel(new Frmchamados(id));

            //Altera a cor da Logo dos Chamados
            btnPrincipalColorido.Visible = false;
            btnChamadosColorido.Visible = true;
            btnEstoqueColorido.Visible = false;
            btnUsuariosColorido.Visible = false;
            btnMaquinasColorido.Visible = false;
            btnSetoresColorido.Visible = false;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //Altera a cor da Logo do Estoque
            ColocarFormNoPainel(new Frmestoque(id));
            btnPrincipalColorido.Visible = false;
            btnChamadosColorido.Visible = false;
            btnEstoqueColorido.Visible = true;
            btnUsuariosColorido.Visible = false;
            btnMaquinasColorido.Visible = false;
            btnSetoresColorido.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Altera a cor da Logo dos Usuários
            ColocarFormNoPainel(new Frmusuarios(id));
            btnPrincipalColorido.Visible = false;
            btnChamadosColorido.Visible = false;
            btnEstoqueColorido.Visible = false;
            btnUsuariosColorido.Visible = true;
            btnMaquinasColorido.Visible = false;
            btnSetoresColorido.Visible = false;
        }

        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            //Altera a cor da Logo das Máquinas
            ColocarFormNoPainel(new Frmmaquinas(id));
            btnPrincipalColorido.Visible = false;
            btnChamadosColorido.Visible = false;
            btnEstoqueColorido.Visible = false;
            btnUsuariosColorido.Visible = false;
            btnMaquinasColorido.Visible = true;
            btnSetoresColorido.Visible = false;
        }

        private void btnSetores_Click(object sender, EventArgs e)
        {
            //Altera a cor da Logo dos Setores
            ColocarFormNoPainel(new Frmsetores(id));
            btnPrincipalColorido.Visible = false;
            btnChamadosColorido.Visible = false;
            btnEstoqueColorido.Visible = false;
            btnUsuariosColorido.Visible = false;
            btnMaquinasColorido.Visible = false;
            btnSetoresColorido.Visible = true;
        }
        #endregion

    }
}
