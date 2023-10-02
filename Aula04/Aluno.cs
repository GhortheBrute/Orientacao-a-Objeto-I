using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Aluno
    {
        private string nome;
        public string Matricula { get; private set; }
        public double Nota1 { get; private set; }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if(value.Length > 0)
                {
                    nome = value;
                }
            }
        }
    }
}
