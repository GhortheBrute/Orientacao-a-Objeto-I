/*Enúnciado 2
 * Faça um programa para controle de empréstimo de livros, com as classes Emprestimo, Livro e Pessoa.
 * Faça uma classe de teste implementando a criação de 2 Pessoas, 5 livros e 4 emprestimos.
 * 
 * Pessoa
 * Atributos, minimo 3
 * Métodos construtores

 * Livro
 * Atributos, minimo 3
 * Métodos construtores

 * Emprestimo
 * Propriedades:
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
using System.Net.Http.Json;

namespace Exercicio02
{
	internal class Program
	{
        public static List<Emprestimo> emprestimos = new ();
        public static List<Pessoa> pessoas = new();
        public static List<Livro> livros = new();
        public static ConsoleKeyInfo input;
        public static int codCliente, codLivro;
		static void Main(string[] args)
		{
            AdicionarManual();
            do
            {
                //emprestar livro
                do
                {
                    //confirma código do cliente
                    Console.WriteLine("Digite o código do cliente.");
                    codCliente = int.Parse(Console.ReadLine());
                    if (codCliente == 1 || codCliente == 2) break;
                    Console.WriteLine("Cliente não cadastrado.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                } while (true);

                do
                {
                    Console.WriteLine("Informe o código do livro.");
                    codLivro = int.Parse(Console.ReadLine());
                    if (codLivro < 1 || codLivro > 5)
                    {
                        Console.WriteLine("Livro não cadastrado.\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        if (AchaLivro(codLivro))
                        {
                            Console.WriteLine("Livro já emprestado. Deseja emprestar outro livro.? (S/N)");
                            input = Console.ReadKey();
                            if (input.Key = ConsoleKey.N) break;
                        }
                        
                        break;
                    }
                    
                } while (true);

                Console.WriteLine("Deseja realizar um novo empréstimo? (S/N)");
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.N) break;
                
            } while (true);


            


            
        }
        
        static bool AchaLivro(int codLivro)
        {
            var achaLivro = emprestimos.FirstOrDefault(x => x.livro == codLivro);
            return achaLivro != null;
        }

        static void AdicionarManual()
        {
            Pessoa pessoa1 = new()
            {
                matricula = 1,
                nome = "Patricia",
                genero = "feminino",
                idade = 23
            };

            Pessoa pessoa2 = new()
            {
                matricula = 2,
                nome = "Marcos",
                genero = "masculino",
                idade = 43
            };
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);

            Livro livro1 = new()
            {
                codigo = 1,
                nome = "O Guia do Mochileiro das Galáxias Vol 1",
                autor = "Douglas Adams",
                editora = "Sextante",
                genero = "Ficção"
            };

            Livro livro2 = new()
            {
                codigo = 2,
                nome = "O Senhor dos Anéis: O Retorno do Rei",
                autor = "J R R Tolkien",
                editora = "Livraria Martins Fontes Editora LTDA",
                genero = "Aventura"
            };

            Livro livro3 = new()
            {
                codigo = 3,
                nome = "HENCH",
                autor = "Natalie Zina Walschots",
                editora = "Melhoramentos",
                genero = "Aventura"
            };

            Livro livro4 = new()
            {
                codigo = 4,
                nome = "Um amor de gato",
                autor = "Melinda Metz",
                editora = "Record",
                genero = "Romance"
            };

            Livro livro5 = new()
            {
                codigo = 5,
                nome = "O Diário de Hass Vol 1",
                autor = "H F Pessoa",
                editora = "H F Pessoa",
                genero = "Ficção"
            };
            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3); 
            livros.Add(livro4);
            livros.Add(livro5);

            Emprestimo emprestimo1 = new()
            {
                livro = 5,
                pessoa = 2,
                dataEmprestimo = new DateOnly(2023, 09, 22),
                dataEstimadaEstorno = new DateOnly(2023, 10, 01),
                dataEstorno = new DateOnly(2023, 10, 01)
            };


            Emprestimo emprestimo2 = new()
            {
                livro = 4,
                pessoa = 1,
                dataEmprestimo = new DateOnly(2023, 09, 28),
                dataEstimadaEstorno = new DateOnly(2023, 10, 05)

            };

            Emprestimo emprestimo3 = new()
            {
                livro = 3,
                pessoa = 2,
                dataEmprestimo = new DateOnly(2023, 09, 30),
                dataEstimadaEstorno = new DateOnly(2023, 10, 07),

            };

            Emprestimo emprestimo4 = new()
            {
                livro = 2,
                pessoa = 1,
                dataEmprestimo = new DateOnly(2023, 09, 24),
                dataEstimadaEstorno = new DateOnly(2023, 10, 02),
                dataEstorno = new DateOnly(2023, 10, 01)
            };

            Emprestimo emprestimo5 = new()
            {
                livro = 1,
                pessoa = 2,
                dataEmprestimo = new DateOnly(2023, 10, 01),
                dataEstimadaEstorno = new DateOnly(2023, 10, 11),

            };
            emprestimos.Add(emprestimo1);
            emprestimos.Add(emprestimo2);
            emprestimos.Add(emprestimo3);
            emprestimos.Add(emprestimo4);
            emprestimos.Add(emprestimo5);
        }

	}
}