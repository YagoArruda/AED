using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();

        Console.WriteLine("Tamanho da fila: ");
        int[] fila = new int[int.Parse(Console.ReadLine())];

        Console.Clear();

        int op = 0;
        int qtd = 0;

        do
        {
            do
            {
                Console.WriteLine("--- Fila ---");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Verificar vazio");
                Console.WriteLine("4 - Ler elemento");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("--- --- ---");
                op = int.Parse(Console.ReadLine());
            }
            while (op > 4 || op < 0);

            switch (op)
            {
                case 1:
                    inserir(fila, ref qtd);
                    break;
                case 2:
                    remover(fila, ref qtd);
                    break;
                case 3:
                    vazio(qtd);
                    break;
                case 4:
                    ler(fila, qtd);
                    break;
            }

        }
        while (op != 0);

    }

    public static void inserir(int[] fila, ref int qtd)
    {
        Console.Clear();
        if (qtd < fila.Length)
        {
            Console.WriteLine("Valor a ser inserido: ");
            fila[qtd] = int.Parse(Console.ReadLine());
            qtd++;
        }
        else
        {
            Console.WriteLine("Fila cheia!");
        }
    }

    public static void remover(int[] fila, ref int qtd)
    {
        Console.Clear();
        if (qtd > 0)
        {
            for (int i = 0; i < qtd - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            qtd--;
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }
    }

    public static void vazio(int qtd)
    {
        Console.Clear();
        if (qtd == 0)
        {
            Console.WriteLine("Esta vazio!");
        }
        else
        {
            Console.WriteLine("Nao esta vazio!");
        }
    }

    public static void ler(int[] fila, int qtd)
    {
        Console.Clear();
        if (qtd > 0)
        {
            Console.WriteLine($"Primeiro elemento: {fila[0]}");
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }
    }
}