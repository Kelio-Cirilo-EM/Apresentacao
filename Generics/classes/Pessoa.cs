namespace Generics.classes
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public void MostrarInformacaoPessoa()
        {
            Console.WriteLine("Nome: " + Nome + ", " + "Idade: " + Idade);
        }
    }
}
