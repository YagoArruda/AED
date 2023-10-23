using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();

        Console.WriteLine("Tamanho da Lista: ");
        int[] lista = new int[int.Parse(Console.ReadLine())];

        Console.Clear();

        int op = 0;
        int qtd = 0;

        do
        {
            do
            {

                Console.WriteLine("--- Lista ---");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento localizado");
                Console.WriteLine("3 - Remover elementos");
                Console.WriteLine("4 - Percorrer lista");
                Console.WriteLine("5 - Verificar vazio");
                Console.WriteLine("6 - Localizar elemento");
                Console.WriteLine("7 - Concatenar listas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("--- --- ---");
                op = int.Parse(Console.ReadLine());
            }
            while (op > 7 || op < 0);

            switch (op)
            {
                case 1:
                    inserir(lista, ref qtd);
                    break;
                case 2:
                    remover(lista, ref qtd);
                    break;
                case 3:
                    removerTodos(ref qtd);
                    break;
                case 4:
                    lerTodos(lista, ref qtd);
                    break;
                case 5:
                    vazio(qtd);
                    break;
                case 6:
                    localizar(lista, ref qtd);
                    break;
                case 7:
                    lista = concatenar(ref lista, ref qtd);
                    break;
            }

        }
        while (op != 0);

    }

    public static void inserir(int[] lista, ref int qtd)
    {
        Console.Clear();
        if (qtd < lista.Length)
        {
            Console.WriteLine("Valor a ser inserido: ");
            lista[qtd] = int.Parse(Console.ReadLine());
            qtd++;
        }
        else
        {
            Console.WriteLine("Lista cheia!");
        }
    }

    public static void remover(int[] lista, ref int qtd)
    {
        Console.Clear();
        if (qtd > 0)
        {
            int val = 0;
            do
            {
                Console.WriteLine("Posicao a ser apagada: ");
                val = int.Parse(Console.ReadLine());
            }
            while (val < 0 || val > qtd);
            Console.WriteLine($"Elemento na posicao {val}: {lista[val - 1]}, apagado");


            for (int i = val; i < qtd - 1; i++)
            {
                lista[i] = lista[i + 1];
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

    public static void removerTodos(ref int qtd)
    {
        qtd = 0;
    }

    public static void lerTodos(int[] lista, ref int qtd)
    {
        if (qtd > 0)
        {
            Console.Write($"qtd: {qtd}: ");
            for (int i = 0; i < qtd; i++)//qtd
            {
                Console.Write($"{lista[i]}/");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }

    }

    public static void localizar(int[] lista, ref int qtd)
    {
        Console.WriteLine("Elemento a ser localizado: ");
        int val = int.Parse(Console.ReadLine());
        int count = 0;

        if (qtd > 0)
        {
            for (int i = 0; i < qtd; i++)
            {
                if (lista[i] == val)
                {
                    Console.WriteLine($"Posicao: {i + 1}/{qtd} elemento: {lista[i]}");
                    count++;
                    break;
                }
            }

            if (count <= 0)
            {
                Console.WriteLine("Elemento nao encontrado!");
            }
        }
        else
        {
            Console.WriteLine("Lista vazia!");
        }

    }

    public static int[] concatenar(ref int[] lista, ref int qtd)
    {
        Console.WriteLine("Tamanho da 2° Lista: ");
        int[] lista2 = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Quantos valores serão preenchidos: ");
        int qtd2 = int.Parse(Console.ReadLine());
        int countqtd2 = 0;

        for (int i = 0; i < qtd2; i++)
        {
            Console.WriteLine($"Digite o {i + 1}° valor: ");
            lista2[i] = int.Parse(Console.ReadLine());
            countqtd2++;
        }

        int val = 0;

        if (qtd + qtd2 > lista.Length)
        {
            val = (qtd + qtd2) + ((lista.Length + lista2.Length) - (qtd + qtd2));
        }
        else
        {
            val = lista.Length;
        }

        int[] lista3 = new int[lista.Length];
        for (int i = 0; i < lista.Length; i++)
        {
            lista3[i] = lista[i];
        }

        Array.Resize(ref lista, val);

        for (int i = 0; i < val; i++)
        {
            if (i < qtd)
            {
                lista[i] = lista3[i];
            }
            else if (i >= qtd && i - qtd < qtd2)
            {
                lista[i] = lista2[i - qtd];
            }

        }
        qtd += countqtd2;
        Console.WriteLine("");

        return lista;
    }

}