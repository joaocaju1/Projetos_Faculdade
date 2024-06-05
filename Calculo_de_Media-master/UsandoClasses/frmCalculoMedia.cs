namespace UsandoClasses
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // instancie  classe
            Aluno aluno = new Aluno();


            // atribui as propriedades
            aluno.Nome = txtNome.Text;
            aluno.Ra = txtRA.Text;
            aluno.P1 = double.Parse(txtP1.Text);
            aluno.P2 = double.Parse(txtP2.Text);

            aluno.CalcularMedia();

            lblMedia.Visible = true;
            txtMedia.Visible = true;
            txtMedia.Text = aluno.Media.ToString("n2");

        }

        private void frmCalculoMedia_Load(object sender, EventArgs e)
        {
            txtMedia.Visible = false;
            lblMedia.Visible = false;
        }
    }
}