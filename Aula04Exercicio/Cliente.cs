using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie um sistema que represente um Banco com contas bancárias que possuem saldos 
 * e vinculo a um Cliente e um Gerente. A pessoa pode realizar depósitos, 
 * saques e também consultar o saldo em tela.
 * O saque só poderá ser realizado caso haja saldo suficiente.
 * Crie testes na classe main.

*/
namespace Aula04Exercicio
{
    internal class Cliente
    {
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        //public string Endereco { get; private set; }
        public int Idade { get; private set; }
        public Cliente(string nome, string cpf, int idade)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
        }
        public void FazerAniversario()
        {
            Idade++;
        }
        private string cpf;
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value.ToString().Count() < 11)
                {
                    cpf = value;
                }
                Console.WriteLine("CPF não atribuído, quantidade de dígitos inválida.");
            }
        }
    }
}
