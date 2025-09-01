using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class Funcionario
    {
         public string Nome { get; set; }
        public string Cargo { get; set; }

        public void RegistrarEmprestimo(Biblioteca biblioteca, Usuario usuario, Livro livro)
        {
            if (livro.Disponivel = false)
            {
                Console.WriteLine("Livro não está disponível!");
                return;
            }

            Emprestimo emp = new Emprestimo();
            emp.LivroEmprestado = livro;
            emp.Usuario = usuario;
            emp.DataEmprestimo = DateTime.Now;
            emp.DataDevolucao = DateTime.Now.AddDays(7);

            usuario.Historico.Add(emp);
            livro.Disponivel = false;

            biblioteca.Emprestimos.Add(emp);

            Console.WriteLine($"Empréstimo registrado por {Nome} para {usuario.Nome}");
        }
    }
}