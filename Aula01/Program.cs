using Aula01;

namespace POOIAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fogao fogao1 = new()
            {
                bocas = 5,
                forno = true,
                tipo = "pé",
                marca = "Eletrolux",
                cor = "preto"
            };

            Console.WriteLine(fogao1);

            //int nome = 0;

            //Garrafa garrafa1= new Garrafa();
            //garrafa1.cor = "preto";
            //garrafa1.material = "plastico";
            //garrafa1.termica = true;
            //garrafa1.capacidade = 750;

            //Garrafa garrafa2 = new ();
            //garrafa2.cor = "rosa";

            //Garrafa garrafa3 = new()
            //{
            //    cor = "preto",
            //    capacidade = 0,
            //    termica = true,
            //    material = "plastico"

            //};
        }
    }
}