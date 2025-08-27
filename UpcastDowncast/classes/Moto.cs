namespace UpcastDowncast.classes
{
    public class Moto : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando moto...");
        }
        public virtual void Empinar()
        {
            Console.WriteLine("Empinando moto...");
        }
    }
}
