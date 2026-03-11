namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Livro? Livro { get; set; }

        public Emprestimo(User? user, Livro? livro)
        {
            Livro = livro;
            User = user;
        }
        public Emprestimo()
        {

        }


    }
}
