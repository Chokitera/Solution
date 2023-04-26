using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.models
{
    public class ChamadoAcoes : Chamado
    {
        public int idChamado { get; set; }

        public int idResponsavel { get; set; }

        public string visibilidade { get; set; }

        public string observacao { get; set; }

        public string custo { get; set; }

        public string atividade { get; set; }

        public string dataAcao { get; set; }

        public string tempoInicial { get; set; }

        public string tempoFinal { get; set; }

        public string tempoTotal { get; set; }
    }
}
