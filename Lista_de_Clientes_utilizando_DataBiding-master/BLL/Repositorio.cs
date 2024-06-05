using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        public List<Clientes> Cliente { get; set; } = new List<Clientes>();

        public void Incluir(Clientes cliente)
        {
            Cliente.Add(cliente);
        }

        public void Remover(Clientes cliente)
        {
           Cliente.Remove(cliente);
        }
    }
}
