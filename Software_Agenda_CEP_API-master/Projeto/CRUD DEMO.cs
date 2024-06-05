using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class CRUD_DEMO : Form
    {
        Agenda? AgendaForm;
        CEP? CEPForm;
        public CRUD_DEMO()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AgendaForm == null)
            {
               AgendaForm = new Agenda();
                AgendaForm.MdiParent = this;
                AgendaForm.WindowState = FormWindowState.Maximized;
                AgendaForm.Show();
            }
            else
            {
                AgendaForm.Activate();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CEPForm == null)
            {
                CEPForm = new CEP();
                CEPForm.MdiParent = this;
                CEPForm.WindowState = FormWindowState.Maximized;
                CEPForm.Show();
            }
            else
            {
                CEPForm.Activate();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

          Sobre SobreForm = new Sobre();
           SobreForm.ShowDialog();
        }
    }
}
