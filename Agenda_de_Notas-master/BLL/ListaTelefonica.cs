namespace BLL
{
    public class ListaTelefonica
    {
        public string Telefone { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Nome} - Lista de Telefones = {Telefone} ";
        }
    }
}