using Solucao.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao.models
{
    public class Helpers
    {
        public void LimparTelaNovoTextBox(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is novoTextBox)
                            {
                                // Limpar os campos de texto na tela
                                (ctr2 as novoTextBox).Text = string.Empty;
                            }

                        if (ctr2 is TextBox)
                        {
                            // Limpar os campos de texto na tela
                            (ctr2 as TextBox).Text = string.Empty;
                        }
                    }
                }
            }
        }

        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                // Limpar os campos de texto na tela
                                (ctr2 as TextBox).Text = string.Empty;
                            }

                            if (ctr2 is MaskedTextBox)
                            {
                                // Limpar os campos de texto na tela
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }

                            if (ctr2 is ComboBox)
                            {
                                // Limpar os campos de texto na tela
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        public void LimparTelaCheckBox(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    foreach (Control ctr2 in ctr1.Controls)
                    {
                        if (ctr2 is CheckBox)
                        {
                            // Limpar os campos de CheckBox na tela
                            (ctr2 as CheckBox).Checked = false;
                        }
                    }
                }
            }
        }

        public static void LimitarCampo(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
