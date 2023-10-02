using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Exercicio
{
    internal class Gerente
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int Idade { get; set; }
        public int Agencia { get; set; }
        private long cpf;
        public long Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                if(value.ToString().Count() < 11)
                {
                    cpf = value;
                }
                Console.WriteLine("CPF não atribuído, quantidade de dígitos inválida.");
            }
        }
        public Gerente(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}
