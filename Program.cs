
using desafio;

Biblioteca biblioteca = new Biblioteca();

    Livro l1 = new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", AnoPublicacao = 1954, Disponivel = true };
    Livro l2 = new Livro { Titulo = "Harry Potter", Autor = "J.K. Rowling", AnoPublicacao = 1997, Disponivel = true };
    biblioteca.AdicionarLivro(l1);
            biblioteca.AdicionarLivro(l2);

            Usuario u1 = new Usuario("Carlos", 21);
    Usuario u2 = new Usuario("Ana", 19);

    biblioteca.RegistrarUsuario(u1);
            biblioteca.RegistrarUsuario(u2);

            Funcionario f1 = new Funcionario { Nome = "João", Cargo = "Atendente" };
    biblioteca.ContratarFuncionario(f1);

            f1.RegistrarEmprestimo(biblioteca, u1, l1);
            f1.RegistrarEmprestimo(biblioteca, u2, l2);

            Console.WriteLine("\n== Histórico do Carlos ==");
            u1.MostrarHistorico();

            Console.WriteLine("\n== Empréstimos registrados ==");
            foreach (var e in biblioteca.Emprestimos)
            {
                e.MostrarDetalhes();
            }

