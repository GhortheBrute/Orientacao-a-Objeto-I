using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Livro
 * Atributos, minimo 3
 * Métodos construtores

 */
namespace Exercicio02
{
    public class Livro
    {
        public int Codigo { get;  }
        public string Nome { get; }
        public string Genero { get;  }
        public string Autor { get;  }
        public string Editora { get; }

        public Livro(int codigo, string nome, string genero, string autor, string editora)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Genero = genero;
            this.Autor = autor;
            this.Editora = editora;
        }

        public void ImprimeLivro()
        {
            foreach(var item in Livro)
            {
                Console.WriteLine($"Código:\t{item.Codigo}\n" +
                    $"Título:\t{item.nome}"+
                    $"Autor:\t{item.autor}" +
                    $"Editora:\t{item.editora}" +
                    $"Gênero:\t{item.genero}");
                
            }
        }
    }
}
