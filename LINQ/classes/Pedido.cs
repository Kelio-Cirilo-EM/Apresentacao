namespace LINQ.classes
{
    public class Pedido
    {
        public Pedido() { }

        public Pedido(string nome, decimal valor)
        {
            Produto = nome;
            Valor = valor;
        }

        public string Produto { get; set; }
        public decimal Valor { get; set; }
    }
}
