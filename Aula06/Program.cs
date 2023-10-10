/*Vamos criar um sistema que represente um circo.
Neste sistema teremos a classe pai Artista e seus filhos 
Malabarista, Equilibrista e Palhaço.
Na classe Artista teremos o Nome, o tempo de apresentação, 
a data de inicio, data de saída (que pode ser vazia) e se 
está atualmente ativo. Teremos também um método para exibir 
as informações e um para registrar a data de saída de algum 
artista e inativar seu cadastro.
Crie testes dos seus objetos filhos.*/

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palhaco palhaco1 = new("Patati", 10, new DateTime(2013, 09, 30), new DateTime(2043, 12, 31), true);
            Malabarista malabarista1 = new("Patata", 9, new DateTime(2012, 06, 14), new DateTime(2043, 12, 31), true);
            Equilibrista equilibrista1 = new("Gonzaga", 1, new DateTime(2022, 12, 01), new DateTime(2023, 01, 01), false);

            palhaco1.ImprimirPalhaco();
            malabarista1.ImprimirMalabarista();
            equilibrista1.ImprimirEquilibrista();
        }
    }
}