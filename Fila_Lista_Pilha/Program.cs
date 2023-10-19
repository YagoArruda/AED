using System;
using System.IO;
using System.Text;
using System.Diagnostics;

class Program
{
    private static int tam = 10;
    public static int[] fila = new int[tam];
    public static int countF = 0;

    public static int[] lista = new int[tam];
    public static int countL = 0;

    public static int[] pilha = new int[tam];
    public static int countP = 0;

    public static void Main(string[] args)
    {
        int op = 0;

        do
        {

            do
            {
                Console.Clear();

                Console.WriteLine("Selecione o metodo:");
                Console.WriteLine("1 - Fila");
                Console.WriteLine("2 - Lista");
                Console.WriteLine("3 - Pilha");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());
            }
            while (op > 3 || op < 0);

            do
            {
                switch (op)
                {
                    case 1:
                        op = filaOps();
                        break;
                    case 2:
                        op = listaOps();
                        break;
                    case 3:
                        op = pilhaOps();
                        break;
                }
            }
            while (op > 1);

        }
        while (op != 0);

    }

    //Inserir
    public static void inserir(int ref count, int[] vetor)
    {
        if (count < vetor.Length)
        {
            Console.WriteLine("Digite o numero: ");
            fvetor[count] = int.Parse(Console.ReadLine());
            count++;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Sem espaço!");
        }
    }
    //Show
    public static void show(int ref count, int[] vetor)
    {
        Console.Clear();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{vetor[i]}/");
        }
        Console.WriteLine("");
    }


    //Fila
    public static int filaOps()
    {
        Console.Clear();

        int fop = 0;

        do
        {
            Console.WriteLine("--- Fila ---");
            Console.WriteLine($"Tamanho: {countF}/{fila.Length}");
            Console.WriteLine("1 - Adicionar Numero");
            Console.WriteLine("2 - Remover Numero");
            Console.WriteLine("3 - Mostrar Fila");
            Console.WriteLine("4 - Sair");

            fop = int.Parse(Console.ReadLine());

            if (fop == 4)
            {
                fop = -1;
            }

            switch (fop)
            {
                case 1:
                    filaAdd();
                    break;
                case 2:
                    filaRemove();
                    break;
                case 3:
                    filaShow();
                    break;
            }
        }
        while (fop != -1);

        return fop;

    }
    public static void filaAdd()
    {
        if (countF < fila.Length)
        {
            Console.WriteLine("Digite o numero: ");
            fila[countF] = int.Parse(Console.ReadLine());
            countF++;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Fila cheia!");
        }
    }

    public static void filaRemove()
    {
        if (countF > 0)
        {
            for (int i = 0; i < countF - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            countF--;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Fila vazia!");
        }
    }

    public static void filaShow()
    {
        Console.Clear();

        for (int i = 0; i < countF; i++)
        {
            Console.Write($"{fila[i]}/");
        }
        Console.WriteLine("");
    }

    //Lista
    public static int listaOps()
    {
        Console.Clear();

        int fop = 0;

        do
        {
            Console.WriteLine("--- Lista ---");
            Console.WriteLine($"Tamanho: {countL}/{lista.Length}");
            Console.WriteLine("1 - Adicionar Numero");
            Console.WriteLine("2 - Remover Numero");
            Console.WriteLine("3 - Mostrar Fila");
            Console.WriteLine("4 - Sair");

            fop = int.Parse(Console.ReadLine());

            if (fop == 4)
            {
                fop = -1;
            }

            switch (fop)
            {
                case 1:
                    listaAdd();
                    break;
                case 2:
                    listaRemove();
                    break;
                case 3:
                    listaShow();
                    break;
            }
        }
        while (fop != -1);

        return fop;

    }
    public static void listaAdd()
    {
        if (countL < lista.Length)
        {
            Console.WriteLine("Digite o numero: ");
            lista[countL] = int.Parse(Console.ReadLine());
            countL++;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Pilha cheia!");
        }
    }

    public static void listaRemove()
    {
        if (countL > 0)
        {
            int remov = 0;

            for (int i = 0; i < countL; i++)
            {
                Console.Write($"{i}: {lista[i]}/");
            }
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Posição do numero a ser removido: ");
                remov = int.Parse(Console.ReadLine());
            }
            while (remov < 0 || remov > lista.Length);

            for (int i = remov - 1; i < countL - 1; i++)
            {
                lista[i] = lista[i + 1];
            }
            countL--;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Lista vazia!");
        }
    }

    public static void listaShow()
    {
        Console.Clear();

        for (int i = 0; i < countL; i++)
        {
            Console.Write($"{lista[i]}/");
        }
        Console.WriteLine("");
    }

    //Pilha
    public static int pilhaOps()
    {
        Console.Clear();

        int fop = 0;

        do
        {
            Console.WriteLine("--- Pilha ---");
            Console.WriteLine($"Tamanho: {countP}/{pilha.Length}");
            Console.WriteLine("1 - Adicionar Numero");
            Console.WriteLine("2 - Remover Numero");
            Console.WriteLine("3 - Mostrar Fila");
            Console.WriteLine("4 - Sair");

            fop = int.Parse(Console.ReadLine());

            if (fop == 4)
            {
                fop = -1;
            }

            switch (fop)
            {
                case 1:
                    pilhaAdd();
                    break;
                case 2:
                    pilhaRemove();
                    break;
                case 3:
                    pilhaShow();
                    break;
            }
        }
        while (fop != -1);

        return fop;

    }
    public static void pilhaAdd()
    {
        if (countP < pilha.Length)
        {
            Console.WriteLine("Digite o numero: ");
            pilha[countP] = int.Parse(Console.ReadLine());
            countP++;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Pilha cheia!");
        }
    }

    public static void pilhaRemove()
    {
        if (countP > 0)
        {
            countP--;

            Console.Clear();
        }
        else
        {
            Console.WriteLine("Pilha vazia!");
        }
    }

    public static void pilhaShow()
    {
        Console.Clear();

        for (int i = 0; i < countP; i++)
        {
            Console.Write($"{pilha[i]}/");
        }
        Console.WriteLine("");
    }

}