using System.Security.Cryptography.X509Certificates;

namespace Aula03
{
    internal class Program
    {
        public static double notaProva1, notaProva2, notaTrabalho;
        public static char input;
        static void Main(string[] args)
        {
            //Console.WriteLine($"Método Somar:\t{Somar(1, 2)}");
            //Console.WriteLine($"Método Calcular Área Circulo:\t{CalcularAreaCirculo(30)}");
            do
            {
                MatricularAluno();
                RegistrarNota();
                Console.WriteLine($"Média Final:\t{CalcularMedia()}\n" +
                    $"Prova 1:\t{notaProva1:F}\n" +
                    $"Prova 2:\t{notaProva2:F}\n" +
                    $"Trabalho:\t{notaTrabalho:F}");
                Console.WriteLine("\n\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.WriteLine("Deseja cadastrar os dados de um novo aluno? S/N");
                input = Console.ReadKey();
                if (input == 's')
                {

                }
                

            }
            
        }
        private static void MatricularAluno()
        {
            int i = 0;
            do
            {
                Alunos alunoi = new Alunos();

                Console.WriteLine("Informe a Matricula.");
                alunoi.matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Nome.");
                alunoi.nome = Console.ReadLine();
                Console.WriteLine("Informe o número da classe.");
                alunoi.classe = int.Parse(Console.ReadLine());
                alunoi.disciplina = Console.ReadLine();
                alunoi.turma = Console.ReadKey().ToString();

            } while(true);
        }
        /* Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
         * Cada objeto dessa classe deve guardar os seguintes dados do aluno:
         * matrícula, nome, 2 notas de prova e 1 nota de trabalho.
         * Construa os seguintes métodos para esta classe:
         * métodos construtores,
         * registrar nota de cada prova e trabalho,
         * calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
         * Teste na main, se atente para o que precisar ser public, private, parametros, retornos.. 
        */

        private static void RegistrarNota() 
        {
            Console.WriteLine("Informe Nota da Prova 1.");
            notaProva1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe Nota da Prova 2.");
            notaProva2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe Nota do Trabalho.");
            notaTrabalho = double.Parse(Console.ReadLine());
            Console.Clear();
        }

        public static double CalcularMedia()
        {
            double resultado = Math.Round((((notaProva1 + notaProva2) * 2.5D + notaTrabalho * 2) / 6.5D), 2);
            return resultado;
        }
        //public static double Somar(double numero1, double numero2)
        //{
        //    double resultadoSoma = numero1 + numero2;
        //    return resultadoSoma;
        //}
        ///// <summary>
        ///// Realiza o cálculo da área de um círculo
        ///// </summary>
        ///// <param name="raio">Raio do círculo</param>
        ///// <returns></returns>

        //public static double CalcularAreaCirculo(double raio)
        //{
        //    double resultado = Math.PI * Math.Pow(2, raio);
        //    return resultado;
        //}
    }
}
/*Enúnciado 2
 * Pessoa
Atributos, minimo 3
Métodos construtores

Livro
Atributos, minimo 3
Métodos construtores

Emprestimo
Propriedades:
	DataEmprestimo
	DataEstorno
	DataEstimadaEstorno
	Pessoa
	Livro

Métodos construtores
Métodos encapsulamento:
	Emprestar()
	Devolver() retorna se houve atraso
*/