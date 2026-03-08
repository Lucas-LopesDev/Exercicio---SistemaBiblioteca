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

        biblioteca.AddEmprestimo(1, 2);



    }
}
