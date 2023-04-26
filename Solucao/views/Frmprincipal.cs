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
    public partial class Frmprincipal : Form
    {
        //Atributos
        Login obj = new Login();

        public Frmprincipal(string id)
        {
            obj.id = int.Parse(id);
            InitializeComponent();

        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {
            //Informa e da boas vindas ao usuário logado
            PrincipalDAO dao = new PrincipalDAO();
            lblSaudacao.Text = "OLÁ, " + dao.UsuarioLogado(obj).ToUpper() + ". SEJA BEM VINDO!";

            //Preencher o horário e Data
            tmrHorario.Enabled = true;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #region Eventos
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
