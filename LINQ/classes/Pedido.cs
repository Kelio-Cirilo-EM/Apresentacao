namespace LINQ.classes
{
    public class Pedido
    {
        public Pedido() { }

        public Pedido(string produto, decimal valor)
        {
            Produto = produto;
            Valor = valor;
        }

        public string Produto { get; set; }
        public decimal Valor { get; set; }
    }
}
