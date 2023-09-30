using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

/*Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
 * Cada objeto dessa classe deve guardar os seguintes dados do aluno:
 * matrícula, nome, 2 notas de prova e 1 nota de trabalho.
 * Construa os seguintes métodos para esta classe:
 * métodos construtores, registrar nota de cada prova e trabalho,
 * calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
 *Teste na main, se atente para o que precisar ser public, private, parametros, retornos.. 
*/

namespace Exercicio01
{
    internal class Program
    {
        public static double notaProva1, notaProva2, notaTrabalho;
        public static string nome, disciplina, turma;
        public static int matricula, classe;
        public static List<int> matriculados = new();
        public static List<Alunos> alunos = new();
        public static ConsoleKeyInfo input;

        static void Main(string[] args)
        {
            do
            {
                MatricularAluno();
                Console.Clear();

                foreach (var elemento in alunos)
                {
                    Console.WriteLine($"Matrícula:\t{elemento.matricula}\n" +
                        $"Nome do Aluno:\t{elemento.nome}\n" +
                        $"Disciplina:\t{elemento.disciplina}\n" +
                        $"Prova 1:\t{elemento.notaProva1:F}\n" +
                        $"Prova 2:\t{elemento.notaProva2:F}\n" +
                        $"Trabalho:\t{elemento.notaTrabalho:F}\n\n" +
                        $"Média Final:\t{elemento.media:F}\n\n");
                }

                Console.WriteLine("\n\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.WriteLine("\nDeseja cadastrar os dados de um novo aluno? (S/N)");
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.N)
                {
                    break;
                }
                Console.Clear();

            } while (true);

        }

        private static void MatricularAluno()
        {
            Console.Clear();
            Console.WriteLine("Informe a Matricula.");
            matricula = int.Parse(Console.ReadLine());
            if (matriculados.Contains(matricula))
            {
                var buscaMatricula = alunos.FirstOrDefault(a => a.matricula == matricula);
                Console.WriteLine("Aluno já matriculado.\n" +
                    $"Matrícula:\t{buscaMatricula.matricula}\n" +
                    $"Nome:\t\t{buscaMatricula.nome}\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                matriculados.Add(matricula);
                Console.WriteLine("Informe o Nome.");
                nome = Console.ReadLine();
            }
            Console.WriteLine("\nInforme a disciplina.");
            disciplina = Console.ReadLine().ToLower();
            Console.WriteLine("Informe a Nota da Prova 1.");
            notaProva1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota da Prova 2.");
            notaProva2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do Trabalho.");
            notaTrabalho = double.Parse(Console.ReadLine());

            alunos.Add(new Alunos(matricula, nome, disciplina, notaProva1, notaProva2, notaTrabalho));
        }
    }
}