using SistemaBiblioteca;

internal class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        var user1 = new User() { Id = 1, Name = "Lucas" };
        var user2 = new User() { Id = 2, Name = "Xandao" };

        var livro1 = new Livro() { Id = 1, Name = "Habitos Atomicos", Disponivel = true, Isbn = "12324askda" };
        var livro2 = new Livro() { Id = 2, Name = "David Goggins", Disponivel = true, Isbn = "122224asdskda" };
        var livro3 = new Livro() { Id = 3, Name = "Bitcoin", Disponivel = true, Isbn = "asdlakda" };

        Emprestimo emprestimo1 = new Emprestimo() { User = user1, Livro = livro1 };
        Emprestimo emprestimo2 = new Emprestimo() { User = user2, Livro = livro2 };
        livro1.Disponivel = false;
        livro2.Disponivel = false;

        biblioteca.Emprestimos?.AddRange(emprestimo1, emprestimo2);
        biblioteca.Users?.AddRange(user1, user2);
        biblioteca.Livros?.AddRange(livro1, livro2, livro3);

        Console.WriteLine("Emprestimos atuais:");
        biblioteca.GetEmpretimos();
        Console.WriteLine();
        Console.WriteLine("Usuarios cadastrados:");
        biblioteca.GetUsers();
        Console.WriteLine();
        Console.WriteLine("Livros disponiveis para emprestimo:");
        biblioteca.GetLivros();

    }
}
