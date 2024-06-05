using DAL;
namespace Crud
{
    public partial class frmAgenda : Form
    {
        private Repositorio repositorio;
        public frmAgenda()
        {
            InitializeComponent();
        }



        private void frmAgenda_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmDetalhe frm = new frmDetalhe();
            frm.agenda = bsAgenda.Current as Agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Udpate(frm.agenda);
                bsAgenda.ResetBindings(false);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorio.Delete(bsAgenda.Current as Agenda);
            bsAgenda.Remove(bsAgenda.Current as Agenda);
            bsAgenda.ResetBindings(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            frmDetalhe frm = new frmDetalhe();
            frm.agenda = agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Create(agenda);
                bsAgenda.Add(agenda);
            }
        }
    }
}