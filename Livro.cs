using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class Livro
    {
         public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Disponível: {Disponivel}");
        }
    }
}