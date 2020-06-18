namespace SenaiFood
{
    public class Pedido
    {
        public string[] Itens;

        public string Cliente { get; set; }

        public string Restaurante { get; set; }
        public string FormaDePagamento { get; set; }
        public bool PedidoPago;

        public string PedidoRestaurante(){
            
            return "Voce pediu uma coca";
        }
        public string PedidoRestaurante(string Coca){
            
            return "Voce pediu uma coca, e uma pizza de mussarela";
        }
        public string PedidoRestaurante(string Coca, string Pizza){
            
            return "Voce pediu uma coca, e uma pizza de mussarela";
        }
        public string EntregarPedido(){
            if(PedidoPago == false){
                return "Esperando pagamento!";
            }else{
                return "Pagamento realizado! O seu pedido está sendo feito pelo restaurante e logo sairá para entrega";
            }
        }
        
    }
}