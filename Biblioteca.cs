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
    public List<Livro>? GetLivrosDisponiveis()
    {
        if (Livros != null)
        {
            var livrosDiposniveis = Livros.Where(l => l.Disponivel == true).ToList();
            return livrosDiposniveis;
        }
        return null;
    }
    public int AddLivro(string nomeLivro, string isbn)
    {
        if (nomeLivro != null && isbn != null)
        {
            var livro = new Livro() { Name = nomeLivro, Isbn = isbn };
            Livros?.Add(livro);
            return 1;
        }
        return 0;
    }
    public int AddUser(string name)
    {
        if (name != null)
        {
            var user = new User() { Name = name };
            Users?.Add(user);
            return 1;
        }
        return 0;
    }
    public int RemoveLivro(int id)
    {
        if (Livros?.Count > 0)
        {
            var livro = Livros.Where(l => l.Id == id).First();
            if (livro != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return 0;
    }
    public int RemoveUser(int id)
    {
        if (Users?.Count > 0)
        {
            var user = Users.Where(l => l.Id == id).First();
            if (user != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return 0;
    }
    public void AddEmprestimo(int idLivro, int idUser)
    {
        //verificar se o livro e usuario existem
        // verificar se o livro está disponivel

        if (Livros != null && Users != null)
        {
            var livro = Livros.Find(l => l.Id == idLivro && l.Disponivel == true);
            var user = Users.Find(u => u.Id == idUser);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado ou já emprestado");
                return;
            }
            if (user == null)
            {
                Console.WriteLine("Usuario não encontrado");
                return;
            }
            var emprestimo = new Emprestimo(user, livro);
            Emprestimos?.Add(emprestimo);
            livro.Disponivel = false;
        }
    }
}
