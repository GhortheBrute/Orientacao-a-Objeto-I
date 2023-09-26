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
            Fogao fogao2 = new()
            {
                bocas = 2,
                forno = false,
                tipo = "Embutido",
                marca = "Consul",
                cor = "preto"
            };
            Fogao fogao3 = new()
            {
                bocas = 1,
                forno = false,
                tipo = "Embutido",
                marca = "Schiffer",
                cor = "Inox"
            };
            Fogao fogao4 = new()
            {
                bocas = 6,
                forno = true,
                tipo = "pé",
                marca = "Brastemp",
                cor = "Branco"
            };
            Fogao fogao5 = new()
            {
                bocas = 4,
                forno = true,
                tipo = "pé",
                marca = "Eletrolux",
                cor = "Inox"
            };

            //Console.WriteLine(fogao1);

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