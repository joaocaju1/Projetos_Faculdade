namespace ProjetoPorcentagemSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // instancie  classe
            SalarioPorcentagem salarioporcentagem = new SalarioPorcentagem();
                

            // atribui as propriedades

            salarioporcentagem.Nome = txtNome.Text;
            salarioporcentagem.CPF = txtCPF.Text;
            salarioporcentagem.ValorDaDiaria = int.Parse(txtValorDaDiaria.Text);
            salarioporcentagem.DiasTrabalhados = int.Parse(txtDiasTrabalhados.Text);
            
            salarioporcentagem.CalcularSalario();




            lblResultadoValorIR.Text = salarioporcentagem.valorIR.ToString("n2");
            lblResultadoValorLiquido.Text = salarioporcentagem.SalarioLiquido.ToString("n2");
            lblResultadoBase.Text = salarioporcentagem.SalarioBase.ToString("n2");
            

        }
    }
}