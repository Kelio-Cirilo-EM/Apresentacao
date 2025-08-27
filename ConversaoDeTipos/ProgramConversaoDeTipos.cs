namespace ConversaoDeTipos
{
    public class ProgramConversaoDeTipos
    {
        static void Main(string[] args)
        {
            // Conversão de Tipos

            int numero1 = 10;
            int numero2 = 20;
            long soma = numero1 + numero2;  // Conversão implícita
            // Output: 30

            int idade = 22;
            byte idadeConvertida = (byte)idade; // Conversão explícita
            // Output: 22

            double numero3 = 14.50;
            int numero3Convertido = Convert.ToInt32(numero3); // Classe Convert
            // Output: 14

            string string1 = "123456";
            int string1Convertida = Int32.Parse(string1); // Método Parse
            // Output: 123456

            if (int.TryParse(string1, out int numero4)) // Método TryParse
            {
                // Output: 123456
            }
            else
            {
                // Falhou o TryParse!
            }
        }
    }
}
