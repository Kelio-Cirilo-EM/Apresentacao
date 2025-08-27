using System.Collections;

namespace Generics.classes
{
    public class GenericListPessoa<T> : IEnumerable where T : Pessoa
    {
        private readonly List<T> pessoaList = [];

        public virtual void Add(T obj)
        {
            pessoaList.Add(obj);
        }
        public IEnumerator GetEnumerator()
        {
            return pessoaList.GetEnumerator();
        }
    }
}
