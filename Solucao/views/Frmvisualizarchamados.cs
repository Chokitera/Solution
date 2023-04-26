using Solucao.dao;
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
    public partial class Frmvisualizarchamados : Form
    {
        private string _idChamado;
        private string id;
        public Frmvisualizarchamados(string idChamado, string id)
        {
            InitializeComponent();
            this._idChamado = idChamado;
            this.id = id;
        }

        private void Frmvisualizarchamados_Load(object sender, EventArgs e)
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
            txtTitulo.Text = obj.titulo;
            rtbdescricao.Text = obj.descricao;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is Form1
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((Form1)qrForm.First()).ColocarFormNoPainel(new Frmchamadoscliente(id));
            }
        }
    }
}
