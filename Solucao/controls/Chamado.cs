using Solucao.models;
using Solucao.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.controls
{
    public partial class Chamado : UserControl
    {
        public Chamado()
        {
            InitializeComponent();
        }

        private string _horario;

        public string Horario
        {
            get { return _horario; }
            set { _horario = value; lblHora.Text = value; }
        }

        private string _data;

        public string Data
        {
            get { return _data; }
            set { _data = value; lblData.Text = value; }
        }

        private string _numeroChamado;

        public string NumeroChamado
        {
            get { return _numeroChamado; }
            set { _numeroChamado = value; lblnumerochamado.Text = value; }
        }

        private string _tituloChamado;

        public string TituloChamado
        {
            get { return _tituloChamado; }
            set { _tituloChamado = value; lbltitulo.Text = value; }
        }

        private string _solicitanteChamado;

        public string SolicitanteChamado
        {
            get { return _solicitanteChamado; }
            set { _solicitanteChamado = value; txtsolicitante.Text = value; }
        }


        private string _responsavelChamado;

        public string ResponsavelChamado
        {
            get { return _responsavelChamado; }
            set { _responsavelChamado = value; txtresponsavel.Text = value; }
        }

        private string _setorChamado;

        public string SetorChamado
        {
            get { return _setorChamado; }
            set { _setorChamado = value; txtsetor.Text = value; }
        }

        private string _statusChamado;

        public string StatusChamado
        {
            get { return _statusChamado; }
            set { _statusChamado = value; txtstatus.Text = value; }
        }

        private string _descricaoChamado;

        public string DescricaoChamado
        {
            get { return _descricaoChamado; }
            set { _descricaoChamado = value; rtbdescricao.Text = value; }
        }

        private Color _urgenciaChamado;

        public Color UrgenciaChamado
        {
            get { return _urgenciaChamado; }
            set { _urgenciaChamado = value; pnlurgencia.BackColor = value; }
        }

        private string _idChamado;

        public string IdChamado
        {
            get { return _idChamado; }
            set { _idChamado = value; }
        }

        private string _idUsuario;

        public string IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _idUsuarioLogado;

        public string IdUsuarioLogado
        {
            get { return _idUsuarioLogado; }
            set { _idUsuarioLogado = value; }
        }

        public void btnVisualizar_Click(object sender, EventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is Form1
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((Form1)qrForm.First()).ColocarFormNoPainel(new Frmvisualizarchamadostecnico(_idChamado, _idUsuario, _idUsuarioLogado));
            }
        }

    }
}
