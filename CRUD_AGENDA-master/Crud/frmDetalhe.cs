using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Crud
{
    public partial class frmDetalhe : Form
    {
        public Agenda agenda;

        public frmDetalhe()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void frmDetalhe_Load(object sender, EventArgs e)
        {
            bsDetalhe.DataSource = agenda;
        }
    }
}
