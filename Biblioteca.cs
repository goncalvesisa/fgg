using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class Biblioteca
    {

        
        private List<Livro> catalogo;
        public List<Emprestimo> Emprestimos { get; set; }
        private List<Usuario> usuarios;
        private List<Funcionario> funcionarios;

        public Biblioteca()
        {
            catalogo = new List<Livro>();
            Emprestimos = new List<Emprestimo>();
            usuarios = new List<Usuario>();
            funcionarios = new List<Funcionario>();


            
        }

        public void AdicionarLivro(Livro livro)
        {
            catalogo.Add(livro);
        }

        public void RegistrarUsuario(Usuario u)
        {
            usuarios.Add(u);
        }

        public void ContratarFuncionario(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public void MostrarCatalogo()
        {
            foreach (var l in catalogo)
            {
                l.ExibirInformacoes();
            }

            
        }
        
    }
}