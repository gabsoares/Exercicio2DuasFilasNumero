namespace Exercicio2DuasFilasNumero
{
    internal class FilaNumero
    {
        Numero? head, tail;

        public FilaNumero()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                this.tail = aux;
            }
        }

        public Numero Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head)
                {
                    head = tail = null;
                }
                else
                {
                    return this.head;
                }
            }
            return null;
        }

        public void RunOver()
        {
            Numero aux = this.head;
            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);
            }
        }

        public int VerificarTamanho()
        {
            Numero aux = head;
            int tamanho = 0;
            if (!IsEmpty())
            {
                while (aux != null)
                {
                    aux = aux.getNext();
                    tamanho++;
                }
                return tamanho;
            }
            return 0;
        }

        public int VerificarMaiorElementoPilha()
        {
            Numero aux = head;
            int valor = 0, valorAux = 0;
            if (!IsEmpty())
            {
                valor = valorAux = aux.getValor();
                do
                {
                    aux = aux.getNext();
                    if (aux != null)
                    {
                        valor = aux.getValor();
                    }

                    if (valor > valorAux)
                    {
                        valorAux = valor;
                    }
                } while (aux != null);
                return valorAux;
            }
            return 0;
        }

        public int VerificarMenorElementoPilha()
        {
            Numero aux = head;
            int valor = 0, valorAux = 0;
            if (!IsEmpty())
            {
                valor = valorAux = aux.getValor();
                do
                {
                    aux = aux.getNext();
                    if (aux != null)
                    {
                        valor = aux.getValor();
                    }

                    if (valor < valorAux)
                    {
                        valorAux = valor;
                    }
                } while (aux != null);
                return valorAux;
            }
            return 0;
        }

        public void GetImpares()
        {
            Numero aux = head;
            int quantidade = 0, valoresImpares;
            if (!IsEmpty())
            {
                Console.Write("Os valores ímpares são: ");
                do
                {
                    if (aux != null)
                    {
                        if (aux.getValor() % 2 != 0 && head != null)
                        {
                            valoresImpares = aux.getValor();
                            quantidade++;
                            Console.Write(valoresImpares + " ");
                        }
                        aux = aux.getNext();
                    }
                } while (aux != null);
            }
        }

        public void GetPares()
        {
            Numero aux = head;
            int quantidade = 0, valoresPares;
            if (!IsEmpty())
            {
                Console.Write("Os valores ímpares são: ");
                do
                {
                    if (aux != null)
                    {
                        if (aux.getValor() % 2 == 0 && head != null)
                        {
                            valoresPares = aux.getValor();
                            quantidade++;
                            Console.Write(valoresPares + " ");
                        }
                        aux = aux.getNext();
                    }
                } while (aux != null);
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
