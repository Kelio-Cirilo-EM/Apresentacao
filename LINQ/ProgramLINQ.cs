using LINQ.classes;

namespace LINQ
{
    public class ProgramLINQ
    {
        static void Main(string[] args)
        {
            // LINQ

            // Fonte de dados
            List<int> numeros1 = [14, 12, 10, 8, 6, 4, 2];
            List<int> numeros2 = [3, 6, 9, 12, 15, 18, 21];
            List<string> frutas = ["maçã", "banana", "melancia", "manga", "mamão", "jabuticaba"];
            List<object> saladaDeFrutas = ["banana", 16, DateTime.Now];
            List<Cliente> clientes = [];
            clientes.Add(new Cliente
            {
                Id = 1,
                Nome = "Ruberson",
                Idade = 18,
                Pedidos = [
                new() { Produto = "Notebook", Valor = 3200 }
                ]
            });
            clientes.Add(new Cliente
            {
                Id = 2,
                Nome = "Egnalda",
                Idade = 25,
                Pedidos =
                [
                 new() { Produto = "Mouse", Valor = 150 },
                 new() { Produto = "Teclado", Valor = 200 }
                ]
            });

            // Consultas e métodos de extensão

            // Sintaxe de consulta LINQ
            IEnumerable<string> frutasComCaracterMaiorQue6 = from f in frutas
                                                             where f.Length > 6
                                                             select f;

            foreach (string f in frutasComCaracterMaiorQue6)
            {
                // Output: Melancia Jabuticaba
            }

            // Sintaxe de método
            IEnumerable<object> pedidosComValorMenorQue400 = clientes.SelectMany(c => c.Pedidos,
                (c, p) => new { c.Nome, p.Produto, p.Valor })
                .Where(p => p.Valor < 400);

            // Execução imediata || Execução adiada de streaming
            IEnumerable<int> intercecaoNumerosPares = numeros1.Intersect(numeros2)
                .Where(n => n % 2 == 0);

            Console.WriteLine("Antes de modificar a lista: ");
            foreach (int n in intercecaoNumerosPares)
            {
                Console.WriteLine(n);
            }

            numeros1.Add(16);
            numeros2.Add(16);

            Console.WriteLine("Depois de modificar a lista: ");
            foreach (int n in intercecaoNumerosPares)
            {
                Console.WriteLine(n);
            }

            // Execução adiada e sem streaming
            IEnumerable<int> numerosOrdenados = from n in numeros1
                                                orderby n
                                                select n;

            numeros1.Add(0);

            Console.WriteLine("Executando a consulta adiada :");
            foreach (int n in numerosOrdenados)
            {
                Console.WriteLine(n);
            }

            // Mais exemplos

            DateTime dataAnoMesDia = new(1986, 12, 5);

            string dataAnoMesDiaFormatada = dataAnoMesDia.DataExtensa(); // Método de extensão para formatação de datas
            // Output: sexta-feira, 05 de dezembro de 1986

            List<DateTime> formatoAnoMesDiaHoraMinutoSegundo = [];
            formatoAnoMesDiaHoraMinutoSegundo.Add(
                    new(2022, 10, 12, 16, 30, 0)
            );
            formatoAnoMesDiaHoraMinutoSegundo.Add(
                    new(2024, 12, 8, 18, 30, 0)
            );

            foreach (DateTime data in formatoAnoMesDiaHoraMinutoSegundo)
            {
                data.DataAnoMesDia(); // Método de extensão para formatação de datas 
                                      // Output: 12/10/2022      08 / 12 / 2024
            }

            IEnumerable<string> obterTipoString = saladaDeFrutas.OfType<string>();

            foreach (string str in obterTipoString)
            {
                // Output: banana
            }

            Dictionary<long, Cliente> dictionary = clientes.ToDictionary(c => c.Id);
            foreach (KeyValuePair<long, Cliente> kvp in dictionary)
            {
                Console.WriteLine
                    (
                     "Key {0}: id: {1}, nome: {2}, idade: {3}",
                    kvp.Key,
                    kvp.Value.Id,
                    kvp.Value.Nome,
                    kvp.Value.Idade
                    );
            }

            int somaIdade = clientes.Aggregate(
                0,
                (acc, cliente) => acc + cliente.Idade
                );

            Console.WriteLine(somaIdade);
        }
    }
}
