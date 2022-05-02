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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            TelaTarefas telaTarefas = new TelaTarefas();
            telaTarefas.ShowDialog();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            TelaContatos telaContatos = new TelaContatos();
            telaContatos.ShowDialog();      
        }
    }
}
