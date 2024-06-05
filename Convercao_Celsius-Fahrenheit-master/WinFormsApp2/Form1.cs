namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotemperatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (this.cbotemperatura.SelectedIndex == 0)
            {
                float Celsius = 0;
                if (float.TryParse(txtValor.Text, out Celsius))
                {

                    float Fahrenheit = (float)(Celsius * 1.8 + 32);
                    lblResultado.Text = $"{Fahrenheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    lblResultado.Text = "";
                }
            }
            else if (this.cbotemperatura.SelectedIndex == 1)
            {

                {
                    float Fahrenheit = 0;
                    if (float.TryParse(txtValor.Text, out Fahrenheit))
                    {
                        float Celsius = (float)((Fahrenheit - 32) / 1.8);
                        lblResultado.Text = $"{Celsius:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido");
                        lblResultado.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione o tipo de conversão!");
            }
        }
    }
}