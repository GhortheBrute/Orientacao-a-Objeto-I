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
        public DateOnly dataEmprestimo;
        public DateOnly dataEstorno;
        public DateOnly dataEstimadaEstorno;
        public int pessoa;
        public int livro;

        internal void Emprestar() 
        { 

        }

        internal void Devolver()
        {

        }
    }
}
