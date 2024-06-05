using BLL;

namespace AULA07
{
    public partial class Form1 : Form
    {

        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ListaTelefonica telefone = new ListaTelefonica();

            telefone.Telefone = txtTelefone.Text;
            telefone.Nome = txtNome.Text;
            

            Repositorio.Incluir(telefone);
            MessageBox.Show("Telefone incluido com sucesso");

            txtTelefone.Text = "";
            txtNome.Text = "";
            

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listtelefones.Items.Clear();
            foreach (var al in Repositorio.telefones)
            {
                listtelefones.Items.Add(al.ToString());

            }
        }
    }
    
}