namespace SenaiFood
{
    public class Cliente
    {
         public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public string MostrarDados(){

            string dados = $" Nome: {Nome}\n Endereço de entrega: {EnderecoAtual}";
            System.Console.WriteLine(dados);

            return dados;

        }
    }
}