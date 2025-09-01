using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Emprestimo> Historico { get; set; }

        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Historico = new List<Emprestimo>();
        }

        public void MostrarHistorico()
        {
            foreach (var e in Historico)
            {
                Console.WriteLine($"{e.LivroEmprestado.Titulo} - {e.DataEmprestimo.ToShortDateString()}");
            }
        }
    }
}