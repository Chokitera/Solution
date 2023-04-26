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

namespace Solucao.controls
{
    public partial class AcoesChamados : UserControl
    {
        public AcoesChamados()
        {
            InitializeComponent();
        }

        private int _UsuarioLogado;

        public int UsuarioLogado
        {
            get { return _UsuarioLogado; }
            set { _UsuarioLogado = value; }
        }


        private int _idAcao;

        public int IdAcao
        {
            get { return _idAcao; }
            set { _idAcao = value; }
        }

        private int _idResponsavel;

        public int IdResponsavel
        {
            get { return _idResponsavel; }
            set { _idResponsavel = value; }
        }


        private string _data;

        public string Data
        {
            get { return _data; }
            set { _data = value; mtbData.Text = value; }
        }

        private string _tempoInicial;

        public string TempoInicial
        {
            get { return _tempoInicial; }
            set { _tempoInicial = value; mtbInicio.Text = value; }
        }

        private string _tempoFinal;

        public string TempoFinal
        {
            get { return _tempoFinal; }
            set { _tempoFinal = value; mtbFim.Text = value; }
        }

        private string _tempoTotal;

        public string TempoTotal
        {
            get { return _tempoTotal; }
            set { _tempoTotal = value; mtbTempo.Text = value; }
        }

        private string _atividade;

        public string Atividade
        {
            get { return _atividade; }
            set { _atividade = value; cmbAtividade.Texts = value; }
        }

        private string _Custo;

        public string Custo
        {
            get { return _Custo; }
            set { _Custo = value; txtCusto.Text = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; rtbDescricao.Text = value; }
        }

        private string _visibilidade;

        public string Visibilidade
        {
            get { return _visibilidade; }
            set { _visibilidade = value; }
        }

        #region Eventos
        private void AcoesChamados_Load(object sender, EventArgs e)
        {
            if (_visibilidade == "P")
                ckbVisibilidade.Checked = true;
            else
                ckbVisibilidade.Checked = false;

            mtbTempo.Text = SomarHoras();

            //Verificar se pode ou não modificar as ações
            if (_UsuarioLogado != _idResponsavel)
                DesativarTudo();
        }

        private void rtbDescricao_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.descricao = rtbDescricao.Text;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarDescricao(obj);
        }

        private void mtbData_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.dataAcao = mtbData.Text;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarData(obj);
        }

        private void mtbInicio_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.tempoInicial = mtbInicio.Text;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarInicio(obj);

            //Atualizar o Tempo Total no Banco
            if (mtbTempo.Text != "00:00")
                mtbTempo_Leave(sender, e);
        }

        private void mtbFim_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.tempoFinal = mtbFim.Text;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarFim(obj);

            //Atualizar o Tempo Total no Banco
            if (mtbTempo.Text != "00:00")
                mtbTempo_Leave(sender, e);
        }

        private void mtbTempo_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.tempoTotal = mtbTempo.Text;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarTempo(obj);
        }

        private void cmbAtividade_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.atividade = cmbAtividade.Texts;

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarAtividade(obj);
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            obj.custo = txtCusto.Text.Replace(",", ".");

            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarCusto(obj);
        }

        private void ckbVisibilidade_CheckedChanged(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            if(ckbVisibilidade.Checked)
                obj.visibilidade = "P";
            if (!ckbVisibilidade.Checked)
                obj.visibilidade = "I";
            //Executando a Alteração
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.AlterarVisibilidade(obj);
        }

        private void iconExcluir_Click(object sender, EventArgs e)
        {
            //Passando os Atributos
            ChamadoAcoes obj = new ChamadoAcoes();
            obj.id = _idAcao;
            
            //Executando o Delete
            AcoesChamadosDAO dao = new AcoesChamadosDAO();
            dao.DeletarAcao(obj);

            //Limpando o Controle
            this.Dispose();
        }

        private void iconFim_Click(object sender, EventArgs e)
        {
            mtbFim.Text = $"{ DateTime.Now.ToString("HH:mm")}";
            //Colocar no Banco o horário novo
            mtbFim_Leave(sender, e);
        }

        private void iconInicio_Click(object sender, EventArgs e)
        {
            mtbInicio.Text = $"{DateTime.Now.ToString("HH:mm")}";
            //Colocar no Banco o horário novo
            mtbInicio_Leave(sender, e);
        }

        private void mtbData_Enter(object sender, EventArgs e)
        {
            if (mtbData.Text == "  /  /")
            {
                mtbData.Text = $"{DateTime.Now.ToString("dd/MM/yyyy")}";
                mtbData_Leave(sender, e);
            }
        }

        private void mtbFim_TextChanged(object sender, EventArgs e)
        {
            mtbTempo.Text = SomarHoras();
        }
        #endregion

        #region Método para Somar os Horários
        private string SomarHoras()
        {
            try
            {
                if (mtbInicio.Text != "  :" && mtbFim.Text != "  :")
                {
                    string h1 = mtbInicio.Text;
                    string h2 = mtbFim.Text;

                    int v1 = Convert.ToInt32(h1.Substring(0, 2)); // Horas do Inicio
                    int v2 = Convert.ToInt32(h1.Substring(3, 2)); // Minutos do Inicio

                    int v4 = Convert.ToInt32(h2.Substring(0, 2)); // Horas do Fim
                    int v5 = Convert.ToInt32(h2.Substring(3, 2)); // Minutos do Fim

                    int segundosInicio = ((v1 * 60) + v2) * 60;
                    int segundosFim = ((v4 * 60) + +v5) * 60;

                    int segundosTotal = segundosFim - segundosInicio;
                    int minutosTotal = segundosTotal / 60;
                    int horasTotal = minutosTotal / 60;

                    string horas = horasTotal.ToString();
                    string minutos = minutosTotal.ToString();

                    //Formatando os valores
                    if (horas == "0")
                        horas = "00";
                    if (minutos.Length == 1)
                        minutos = "0" + minutos;
                    if (horas.Length == 1)
                        horas = "0" + horas;

                    //Limitando para mostrar somente números > 0
                    if (minutosTotal < 0)
                        return "00:00";

                    return horas + ":" + minutos;
                }
            }
            catch (Exception)
            {
                
            }
            return "00:00";
        }
        #endregion

        #region Método para Desativar tudo
        public void DesativarTudo()
        {
            rtbDescricao.Enabled = false;
            mtbData.Enabled = false;
            mtbInicio.Enabled = false;
            mtbFim.Enabled = false;
            mtbTempo.Enabled = false;
            ckbVisibilidade.Enabled = false;
            cmbAtividade.Enabled = false;
            txtCusto.Enabled = false;
            iconExcluir.Enabled = false;
            iconInicio.Enabled = false;
            iconFim.Enabled = false;
        }

        #endregion
    }
}
