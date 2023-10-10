using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Palhaco : Artista
    {
        public Palhaco(string nome, int tempo, DateTime inicio, DateTime saida, bool ativo) : base(nome, tempo, inicio, saida, ativo)
        {
            
        }
        public void ImprimirPalhaco()
        {
            Console.WriteLine("\nPalhaco");
            base.Imprimir();
        }
    }
}
