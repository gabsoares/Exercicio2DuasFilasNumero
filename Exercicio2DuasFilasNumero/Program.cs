namespace Exercicio2DuasFilasNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaNumero f1 = new();
            FilaNumero f2 = new();
            FilaNumero fAux = new();

            f1.Push(new(1));
            f1.Push(new(2));
            f1.Push(new(31));
            f1.Push(new(0));

            f2.Push(new(3));
            f2.Push(new(5));
            f2.Push(new(4));
            f2.Push(new(5));

            //int opc = 0, quantidadeLivros = 0, opcTransferir;
            //do
            //{
            //    Console.Clear();

            //    Console.WriteLine("****MENU PRINCIPAL****");
            //    Console.WriteLine("Digite 1 para ver se as filas são do mesmo tamanho, caso não mostrará a maior.");
            //    Console.WriteLine("Digite 2 para ver o maior e o menor valor e a média entre eles");
            //    Console.WriteLine("Digite 3 para escolher f1 ou f2 para transferir para fAux");
            //    Console.WriteLine("Digite 4 para ver o total de números impares");
            //    Console.WriteLine("Digite 5 para ver o total de números pares");
            //    Console.WriteLine("Digite 0 para sair");
            //    Console.Write("Opção desejada:< > \b\b\b");
            //    opc = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    switch (opc)
            //    {
            //        case 1:
            //          Console.WriteLine(MaiorFila());
            //            break;
            //        case 2:
            //          Console.WriteLine($"Maior valor: {f1.VerificarMaiorElementoPilha}()");
            //          Console.WriteLine($"Menor valor: {f1.VerificarMenorElementoPilha()}");
            //          Console.WriteLine($"Média: {(f1.VerificarMaiorElementoPilha() + f1.VerificarMenorElementoPilha()) / 2}");
            //            break;
            //        case 3:
            //          Console.WriteLine(Qual pilha deseja transferir para auxiliar? Opção 1 - para (p1 - pAux) | Opção 2 - para (p2 - pAux))
            //          opcTransferir = int.Parse(Console.ReadLine())
            //          Console.WriteLine("***Fila auxiliar***")
            //          TransferirFila(opcTransferir)
            //            break;
            //        case 4:
            //          f1.GetImpares();
            //          Console.WriteLine();
            //          f2.GetImpares();
            //            break;
            //        case 5:
            //          f1.GetPares();
            //          Console.WriteLine();
            //          f2.GetPares();
            //            break;
            //        default:
            //            break;
            //    }
            //} while (opc != 0);

            string MaiorFila()
            {
                if (f1.VerificarTamanho() == f2.VerificarTamanho())
                {
                    return "O tamanho das fila são iguais.";
                }
                else if (f1.VerificarTamanho() > f2.VerificarTamanho())
                {
                    return "A fila 1 é maior";
                }
                else
                {
                    return "A fila 2 é maior";
                }
            }

            void TransferirFila(int opc)
            {
                Numero aux = new(0);
                Numero aux2 = new(0);
                FilaNumero f_temp = new();
                switch (opc)
                {
                    case 1:
                        aux = f1.Pop();
                        f_temp.Push(aux);

                        aux2 = f_temp.Pop();
                        fAux.Push(aux);

                        fAux.RunOver();
                        break;
                    case 2:
                        aux = f2.Pop();
                        f_temp.Push(aux);

                        aux2 = f_temp.Pop();
                        fAux.Push(aux);

                        fAux.RunOver();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
