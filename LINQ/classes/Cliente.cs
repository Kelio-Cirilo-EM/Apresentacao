namespace LINQ.classes
{
    public class Cliente
    {
        public Cliente() { }

        public Cliente(long id, string nome, int idade, List<Pedido> pedidos)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Pedidos = pedidos;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Pedido> Pedidos { get; set; } = [];
    }
}
