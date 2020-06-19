namespace SenaiFood
{
    public class Pedido
    {
        public string Iten1 { get; set; } 
        public string Iten2 { get; set; }
        public string Cliente { get; set; }

        public string Restaurante { get; set; }
        public string FormaDePagamento { get; set; }
        public bool PedidoPago;

        public Pedido(string _Iten1){
            this.Iten1 = _Iten1;
            System.Console.WriteLine($"Voce pediu um(a) {Iten1}");
        }
        public Pedido(string _Iten1, string _Iten2){
            this.Iten1 = _Iten1;
            this.Iten2 = _Iten2;
            System.Console.WriteLine($"Voce pediu um(a) {Iten1} e um(a) {Iten2}");
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