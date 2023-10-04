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
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new(1, "Patricia", 23, "feminino");
            Pessoa pessoa2 = new(2, "Marcos", 43, "masculino");
            Livro livro1 = new(1, "O Guia do Mochileiro das Galáxias Vol 1", "Ficção", "Douglas Adams", "Sextante");
            Livro livro2 = new(2, "O Senhor dos Anéis: O Retorno do Rei", "Aventura", "J R R Tolkien", "Livraria Martins Fontes Editora LTDA");
            Livro livro3 = new(3, "HENCH", "Aventura", "Natalie Zina Walschots", "Melhoramentos");
            Livro livro4 = new(4, "Um amor de gato", "Romance", "Melinda Metz", "Record");
            Livro livro5 = new(5, "O Diário de Hass Vol 1", "Ficção", "H F Pessoa", "H F Pessoa");
            Emprestimo emprestimo1 = new(livro5, pessoa2, new DateTime(2023, 09, 22), new DateTime(2023, 10, 01), new DateTime(2023, 10, 01));
            Emprestimo emprestimo2 = new(livro4, pessoa1, new DateTime(2023, 09, 28), new DateTime(2023, 10, 05));
            ImprimeLivro();
        }
        

        /*static void AdicionarManual()
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

        }*/

    }
}