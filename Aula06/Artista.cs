using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
/*Na classe Artista teremos o Nome, o tempo de apresentação, 
a data de inicio, data de saída (que pode ser vazia) e se 
está atualmente ativo. Teremos também um método para exibir 
as informações e um para registrar a data de saída de algum 
artista e inativar seu cadastro.*/

namespace Aula06
{
    internal class Artista
    {
        public string Nome { get; set; }
        public int TempoApresentacao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataSaida { get; private set; }
        public bool Ativo { get; private set; }

        public Artista(string nome, int tempo, DateTime inicio, DateTime saida, bool ativo)
        {
            this.Nome = nome;
            this.TempoApresentacao = tempo;
            this.DataInicio = inicio;
            this.DataSaida = saida;
            this.Ativo = ativo;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nome:\t{this.Nome}");
            Console.WriteLine($"Tempo de Apresentação:\t{this.TempoApresentacao}");
            Console.WriteLine($"Data de início:\t{this.DataInicio}");
            Console.WriteLine($"Status atual:\t{this.Ativo}");
            if (this.Ativo == false) Console.WriteLine($"Data de Saída:\t{this.DataSaida}");
        }
    }
}
