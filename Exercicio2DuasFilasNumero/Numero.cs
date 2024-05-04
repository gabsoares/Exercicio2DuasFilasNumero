namespace Exercicio2DuasFilasNumero
{
    internal class Numero
    {
        int valor;
        Numero? proximo;

        public Numero(int valor)
        {
            this.valor = valor;
            this.proximo = null;
        }

        public void setNext(Numero aux)
        {
            this.proximo = aux;
        }

        public Numero? getNext()
        {
            return this.proximo;
        }

        public int getValor()
        {
            return this.valor;
        }

        public override string? ToString()
        {
            return $"{this.valor}";
        }
    }
}
