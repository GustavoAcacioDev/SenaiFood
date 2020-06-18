namespace SenaiFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(string NomeFantasia){
            
            if(NomeFantasia == "Papa Pizzaria"){

                string Endereco = "Av. Paulista. 962";
                string dados = $"Nome do restaurante: {NomeFantasia}\n Endereço: {Endereco}";
                return dados;

            }else{
                
                return "Esse restaurante é inválido";

            }
            
        }
    }    
}