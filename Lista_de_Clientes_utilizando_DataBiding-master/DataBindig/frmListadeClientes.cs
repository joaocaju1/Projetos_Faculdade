using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace DataBindig
{
    public partial class frmListadeClientes : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public frmListadeClientes()
        {
            InitializeComponent();
        }

        private void frmListadeClientes_Load(object sender, EventArgs e)
        {
            bsClientes.DataSource = Repositorio;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Nome = "Cliente exemplo";

            cliente.Telefone = "696969";
            cliente.Endereco = "rua tal";

            Repositorio.Incluir(cliente);
            bsClientes.ResetBindings(false);
        }
    }
}