namespace TP_Funcionario
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // instancie  classe
            Funcionario funcionario = new Funcionario();


            // atribui as propriedades

            funcionario.Nome = txtNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.ValorHora = int.Parse(txtValorHora.Text);
            funcionario.HorasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);
            funcionario.CalcularSalario();



            txtSalario.Text = funcionario.Salario.ToString("n2");


        }

  
    }
    
}