using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCRUD
{
    public partial class Mcrud : Form
    {
        AgendaForm? frmAgenda;
        CEPForm? frmCEP;
        public Mcrud()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgenda == null)
            {
                frmAgenda = new AgendaForm();
                frmAgenda.MdiParent = this;
                frmAgenda.WindowState = FormWindowState.Maximized;
                frmAgenda.Show();
            }
            else
            {
                frmAgenda.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCEP == null)
            {
                frmCEP = new CEPForm();
                frmCEP.MdiParent = this;
                frmCEP.WindowState = FormWindowState.Maximized;
                frmCEP.Show();
            }
            else
            {
                frmCEP.Activate();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreForm frmSobre = new SobreForm();

            frmSobre.ShowDialog();
        }
    }
}
