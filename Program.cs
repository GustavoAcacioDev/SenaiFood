using System;

namespace SenaiFood
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente gustavo = new Cliente();
            gustavo.Nome = "Gustavo";
            gustavo.EnderecoAtual = "Av. Paulista";

            gustavo.MostrarDados();


            Restaurante restaurante = new Restaurante();
            System.Console.WriteLine("Em que restaurante voce deseja pedir?\n 1-Papa Pizzaria");
            string dados = Console.ReadLine();

            System.Console.WriteLine( restaurante.MostrarDados(dados) );

            Pedido pedido = new Pedido();
            System.Console.WriteLine("O que voce deseja pedir?\n");

            

        }
    }
}
