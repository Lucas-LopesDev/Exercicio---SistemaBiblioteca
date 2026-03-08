using SistemaBiblioteca;

public class Biblioteca
{
    public List<User>? Users = new List<User>();
    public List<Livro>? Livros = new List<Livro>();
    public List<Emprestimo>? Emprestimos = new List<Emprestimo>();

    public List<Emprestimo>? GetEmpretimos()
    {
        if (Emprestimos != null)
        {
            return Emprestimos;
        }
        return null;
    }
    public List<User>? GetUsers()
    {
        if (Users != null)
        {
            return Users;
        }
        return null;
    }
    public List<Livro>? GetLivros()
    {
        if (Livros != null)
        {
            return Livros;
        }
        return null;
    }
}
