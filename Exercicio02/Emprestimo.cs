using Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Emprestimo
 * Propriedades:
		DataEmprestimo
        DataEstorno
		DataEstimadaEstorno
		Pessoa
		Livro

*/

namespace Exercicio02
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo{get; private set;}
        public DateTime DataEstorno { get; private set; }
        public DateTime DataEstimadaEstorno { get; private set; }
        public Pessoa Pessoa { get;  }
        public Livro Livro { get;  }

        public Emprestimo(Livro livro, Pessoa pessoa, DateTime dataEmprestimo, DateTime dataEstorno, DateTime dataEstimadaEstorno)
        {
            //Inserção manual de dados para inicialização
            this.Livro = livro;
            this.Pessoa = pessoa;
            this.DataEmprestimo = dataEmprestimo;
            this.DataEstorno = dataEstorno;
            this.DataEstimadaEstorno = dataEstimadaEstorno;
        }
        public Emprestimo(Livro livro, Pessoa pessoa, DateTime dataEmprestimo, DateTime dataEstimadaEstorno)
        {
            //Inserção manual de dados para inicialização
            this.Livro = livro;
            this.Pessoa = pessoa;
            this.DataEmprestimo = dataEmprestimo;
            //this.DataEstorno = dataEstorno;
            this.DataEstimadaEstorno = dataEstimadaEstorno;
        }
        /*public Emprestimo (Livro livro, Pessoa pessoa) 
        { 
            if (VerificarDisponibilidade(Livro.Codigo , livro))
            {
                this.Livro = livro;
                this.Pessoa = pessoa;
                this.DataEmprestimo = DateTime.Now;
                this.DataEstimadaEstorno = DataEmprestimo;
                this.DataEstimadaEstorno.AddDays(7);
            }
            Console.WriteLine("Livro indisponível.");
            //Inserções novas

        }

        internal void Devolver(Livro livro, Pessoa pessoa)
        {
            if(this.DataEstimadaEstorno > DateTime.Now)
            {
                var calculo = this.DataEstimadaEstorno.Date - DateTime.Now.Date;
                Console.WriteLine("Devolução atrasada. Será gerado uma multa.");

            }
        }

        public bool VerificarDisponibilidade(int codlivro, Livro livro)
        {
            if (codlivro == this.Livro)
            {
                return false;
            }
            return true;
        }*/
    }
}
