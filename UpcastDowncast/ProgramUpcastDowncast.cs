using UpcastDowncast.classes;

namespace UpcastDowncast
{
    public class ProgramUpcastDowncast
    {
        static void Main(string[] args)
        {
            // Upcast e Downcast

            Veiculo veiculoCarro = new Carro(); // Upcast
            Veiculo veiculoMoto = new Moto(); // Upcast

            veiculoCarro.Ligar();
            veiculoMoto.Ligar();

            Carro carro = (Carro)veiculoCarro; // Downcast sem operador as e is
            carro.Ligar();
            carro.AbrirPortaMalas();

            Moto? moto = veiculoMoto as Moto; // Downcast com operador as
            if (moto != null)
            {
                moto.Ligar();
                moto.Empinar();
            }
            else
            {
                // Falhou o Downcast com as!
            }

            if (veiculoMoto is Moto m) // Downcast com operador is
            {
                m.Ligar();
                m.Empinar();
            }
            else
            {
                // Falhou o Downcast com is!
            }
        }
    }
}
