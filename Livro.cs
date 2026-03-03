namespace SistemaBiblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Isbn { get; set; } = string.Empty;
        public bool Disponivel { get; set; }

        public override string ToString()
        {
            return $"{this.Id} {this.Name}";
        }
    }
}
