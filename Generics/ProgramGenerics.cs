using Generics.classes;
using System.Collections;

namespace Generics
{
    public class ProgramGenerics
    {
        static void Main(string[] args)
        {
            // Genérics

            ArrayList objetos = [
                20, // Boxing
                "Mundo",
                true, // Boxing
                new Pessoa(),
                ];

            foreach (object item in objetos)
            {
                if (item is int i) // Unboxing
                {
                    // Output: 20
                }
                else if (item is bool b) // Unboxing
                {
                    // Output: True
                }
                else if (item is object o)
                {
                    // Output: Mundo Generics.classes.Pessoa
                }
            }

            int day = 18;
            int month = 08;
            int year = 2024;

            string stringInteporlada = $"A data é: {day}/{month}/{year}"; // Boxing

            List<string> listaNomes = ["João", "Júlia"];
            List<object> listaObject = ["Hudson", 16]; // int Boxing
            GenericListPessoa<Pessoa> listaPessoa = [];

            listaPessoa.Add(new Pessoa
            {
                Nome = "Roberto",
                Idade = 32
            });

            foreach (string nome in listaNomes)
            {
                // Output: João Júlia
            }
            foreach (object objeto in listaObject)
            {
                // Output: Hudson 16
            }
            foreach (object objeto in listaObject)
            {
                if (objeto is string s) // Unboxing
                {
                    // Output: Hudson
                }
                else
                {
                    // Falhou o Unboxing!
                }
            }
            foreach (Pessoa pessoa in listaPessoa)
            {
                pessoa.MostrarInformacaoPessoa();
            }
        }
    }
}
