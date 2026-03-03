using SistemaBiblioteca;

public class Biblioteca
{
    public List<User>? Users = new List<User>();
    public List<Livro>? Livros = new List<Livro>();
    public List<Emprestimo>? Emprestimos = new List<Emprestimo>();

    public void GetEmpretimos()
    {
        if (Emprestimos != null)
        {
            foreach (var x in Emprestimos)
            {
                Console.WriteLine($"{x.Livro?.Name} Emprestado para: {x.User?.Name}");
            }
        }
    }
    public void GetUsers()
    {
        Users?.ForEach(x => Console.WriteLine($"Id: {x.Id} User:{x.Name}"));
    }
    public void GetLivros()
    {
        if (Livros != null)
        {
            var livrosDisponiveis = Livros.Where(livro => livro.Disponivel == true);
            if (livrosDisponiveis != null)
            {
                foreach (var livro in livrosDisponiveis)
                {
                    Console.WriteLine(livro.ToString());
                }
            }
        }

    }
}
