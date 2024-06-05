using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        public List<ListaTelefonica> telefones { get; set; } = new List<ListaTelefonica>() { };

        public void Incluir(ListaTelefonica telefone)
        {
            telefones.Add(telefone);
        }

        public void Remover(ListaTelefonica telefone)
        {
            telefones.Remove(telefone);
        }
    }
}
