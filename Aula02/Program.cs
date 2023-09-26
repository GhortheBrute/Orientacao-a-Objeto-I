using Aula02;
using System.Runtime.CompilerServices;

namespace POOIAula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso Haltere10 = new Peso()
            {
                tipo = "Haltere",
                cor = "Preto",
                kilos = 10,
                revestimento = "Borracha"
            };
            Peso Anilha5 = new Peso()
            {
                tipo = "Anilha",
                cor = "Preto",
                kilos = 5,
                revestimento = "Sem"
            };
            List<Peso> pesos = new();
            pesos.Add("Teste");
        }

        

    }
}
