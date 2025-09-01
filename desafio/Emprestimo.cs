using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class Emprestimo
    {
         public Livro LivroEmprestado { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Livro: {LivroEmprestado.Titulo}, Usuário: {Usuario.Nome}, Devolução: {DataDevolucao.ToShortDateString()}");
        }
    }
}