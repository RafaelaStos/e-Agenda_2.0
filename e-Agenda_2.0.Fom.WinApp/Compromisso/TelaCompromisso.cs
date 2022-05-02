using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda_2._0.Fom.WinApp
{
    public partial class TelaCompromisso : Form
    {
        public TelaCompromisso()
        {
            InitializeComponent();
        }

        private void btnAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            TelaCadatroCompromisso telaCadatroCompromisso = new TelaCadatroCompromisso();
            telaCadatroCompromisso.ShowDialog();
        }
    }
}
