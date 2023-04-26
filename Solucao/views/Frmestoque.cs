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
    public partial class Frmestoque : Form
    {
        private string id;
        public Frmestoque(string id)
        {
            InitializeComponent();
            this.id = id;
        }
    }
}
