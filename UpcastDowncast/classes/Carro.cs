namespace UpcastDowncast.classes
{
    public class Carro : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando carro...");
        }
        public virtual void AbrirPortaMalas()
        {
            Console.WriteLine("Abrindo porta-malas...");
        }
    }
}
