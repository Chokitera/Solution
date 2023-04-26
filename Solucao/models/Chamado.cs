using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.models
{
    public class Chamado
    {
        public int id { get; set; }

        public string solicitante { get; set; }

        public string data { get; set; }

        public string horario { get; set; }

        public string responsavel { get; set; }

        public string status { get; set; }

        public string urgencia { get; set; }

        public string titulo { get; set; }

        public string descricao { get; set; }

        public string equipamento { get; set; }

        public string setor { get; set; }

        public string localizacao { get; set; }
    }
}
