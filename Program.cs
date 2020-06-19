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
            restaurante.NomeFantasia = "Papa Pizzaria";

            System.Console.WriteLine( restaurante.MostrarDados("Papa Pizzaria"));

            Pedido pedido = new Pedido("Coca");
            pedido.Restaurante = restaurante.NomeFantasia;
            System.Console.WriteLine($"Voce pediu uma {pedido.Iten1} no {restaurante.NomeFantasia}");

            pedido.PedidoPago = false;

            System.Console.WriteLine(pedido.EntregarPedido());

            System.Console.WriteLine("===============================================================");

            Pedido pedido2 = new Pedido("Coca", "Breadstick");
            pedido.Restaurante = restaurante.NomeFantasia;
            System.Console.WriteLine($"Voce pediu uma {pedido2.Iten1} e um {pedido2.Iten2} no {restaurante.NomeFantasia}");


            pedido2.PedidoPago = true;

            System.Console.WriteLine(pedido2.EntregarPedido());
            


            

        }
    }
}
