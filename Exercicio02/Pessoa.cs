using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * Pessoa
 * Atributos, minimo 3
 * Métodos construtores
 * */

namespace Exercicio02
{
    internal class Pessoa
    {
        public int Matricula { get;  }
        public string Nome { get;  }
        public int Idade { get;  }
        public string Genero { get;  }

        public Pessoa(int matricula, string nome, int idade, string genero)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Idade = idade;
            this.Genero = genero;
        }
    }
}
