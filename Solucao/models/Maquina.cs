using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.models
{
    public class Maquina
    {
        public int id { get; set; }

        public string equipamento { get; set; }

        public string situacao { get; set; }

        public string localizacao { get; set; }

        public string setor { get; set; }

        public int ncm { get; set; }

        public double custo { get; set; }

        public string garantia { get; set; }

        public string plano { get; set; }
    }
}
