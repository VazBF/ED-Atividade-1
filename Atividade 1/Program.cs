namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args) {
            Random random = new Random();
           int x = 0;
            Pilha pilha1 = new Pilha();
            Pilha pilha2 = new Pilha();
            Pilha pilha3 = new Pilha();

            for (int i =0; i < 100; i++)
            {
                x = random.Next(1, 10);
                if (x <= 3)
                {
                    pilha1.push("" + x);
                }else if (x >= 7)
                {
                    pilha3.push("" + x);
                }
                else
                {
                    pilha2.push("" + x);
                }
            }
            for(int i = 0; i <= 100; i++)
            {
                if(i < 100)
                {
                    x = random.Next(1, 4);
                    if (!pilha1.isEmpyt() && !pilha1.isEmpyt() && !pilha1.isEmpyt())
                    {
                        switch (x)
                        {
                            case 1:
                                Console.WriteLine("Empilhando os numeros {0} e {1} na pilha 1", pilha2.getTop().getNome(), pilha3.getTop().getNome());
                                pilha1.push(pilha2.getTop().getNome());
                                pilha2.pop();
                                pilha1.push(pilha3.getTop().getNome());
                                pilha3.pop();
                                break;
                            case 2:
                                Console.WriteLine("Empilhando os numeros {0} e {1} na pilha 2", pilha1.getTop().getNome(), pilha3.getTop().getNome());
                                pilha2.push(pilha1.getTop().getNome());
                                pilha1.pop();
                                pilha2.push(pilha3.getTop().getNome());
                                pilha3.pop();
                                break;
                            case 3:
                                Console.WriteLine("Empilhando os numeros {0} e {1} na pilha 3", pilha1.getTop().getNome(), pilha2.getTop().getNome());
                                pilha3.push(pilha1.getTop().getNome());
                                pilha1.pop();
                                pilha3.push(pilha2.getTop().getNome());
                                pilha2.pop();
                                break;
                        }
                    }
                    else if (pilha1.isEmpyt())
                    {
                        Console.WriteLine("Programa encerrado pois a pilha 1 se encontra vazia");
                    }
                    else if (pilha2.isEmpyt())
                    {
                        Console.WriteLine("Programa encerrado pois a pilha 2 se encontra vazia");
                    }
                    else if (pilha3.isEmpyt())
                    {
                        Console.WriteLine("Programa encerrado pois a pilha 3 se encontra vazia");
                    }
                }
                else
                {
                    Console.WriteLine("\n\nO NUMERO MAXIMO DE SORTEIOS FOI ANTINGIDO\n\n");
                }
            }
            Console.WriteLine("----------Conteudo da pilha 1:---------- ");
            pilha1.imprimir();
            Console.WriteLine("----------Conteudo da pilha 2:---------- ");
            pilha2.imprimir();
            Console.WriteLine("----------Conteudo da pilha 3:---------- ");
            pilha3.imprimir();

        }
    }
}
