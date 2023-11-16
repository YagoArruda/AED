using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        int op = 0;
        fila filaDinamica = new fila();
        
        do
        {
            do
            {
                Console.WriteLine("<--> Opções <-->");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Ver todos");
                Console.WriteLine("4 - Estado atual");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());
            }
            while (op < 0 || op > 4);

            Console.WriteLine("-----");

            switch (op)
            {
                case 1:
                    Console.Write("Valor a ser adicionado: ");
                    filaDinamica.Adicionar(int.Parse(Console.ReadLine()));
                    Console.Write("");
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    int aux = filaDinamica.Remover();
                    if (aux != int.MinValue)
                    {
                        Console.WriteLine($"Valor removido: {aux}");
                    }
                    break;
                case 3:
                    Console.Clear();
                    filaDinamica.ExibirFila();
                    break;
                case 4:
                    Console.Clear();
                    if (filaDinamica.Vazia())
                    {
                        Console.WriteLine("A fila está vazia");
                    }
                    else
                    {
                        Console.WriteLine("A fila não está vazia");
                    }
                    break;
            }
        }
        while (op != 0);
    }
}

class fila
{
    class valor
    {
        public int ValorAtual;
        public valor proximo;

        public valor(int entrada)
        {
            ValorAtual = entrada;
            proximo = null;
        }
    }

    valor primeiro;
    valor ultimo;

    public fila()
    {
        primeiro = null;
        ultimo = null;
    }

    public void Adicionar(int dado)
    {
        valor novoValor = new valor(dado);

        if (ultimo == null)
        {
            primeiro = novoValor;
            ultimo = novoValor;
        }
        else
        {
            ultimo.proximo = novoValor;
            ultimo = novoValor;
        }
    }

    public int Remover()
    {
        if (primeiro == null)
        {
            Console.WriteLine("A fila está vazia.");
        }
        else
        {
            int valorRetirado = primeiro.ValorAtual;
            primeiro = primeiro.proximo;

            if (primeiro == null)
            {
                ultimo = null;
            }

            return valorRetirado;
        }

        return int.MinValue;
    }

    public void ExibirFila()
    {
        valor atual = primeiro;

        while (atual != null)
        {
            Console.Write($"{atual.ValorAtual} ");
            atual = atual.proximo;
        }

        Console.WriteLine();
    }

    public bool Vazia()
    {
        return primeiro == null;
    }
}