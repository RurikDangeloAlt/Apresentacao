using System;

namespace Apresentacao
{
    public class ClasseTest<T>
    {
        private T valor;

        public ClasseTest(T valor)
        {
            this.valor = valor;
        }

        public void ExibirValor()
        {
            Console.WriteLine($"Valor test: {valor}");
        }

        public T ObterValor()
        {
            return valor;
        }
    }
}
