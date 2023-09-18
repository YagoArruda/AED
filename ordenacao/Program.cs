using System;
using System.IO;

class Program2
{
    public static void Main(string[] args)
    {
        int[] nums = { 3, 4, 5, 7, 9, 8, 6, 1, 2, 0 };

        int op = 0;

        do
        {
            Console.WriteLine("1 - BubbleSort");
            Console.WriteLine("2 - SelectionSort");
            Console.WriteLine("3 - InsertionSort");
            Console.Write("Metodo de ordenação desejado: ");
            op = int.Parse(Console.ReadLine());
        }
        while (op < 1 || op > 3);

        op--;
        switch (op)
        {
            case 0:
                Console.WriteLine("BubbleSort");
                bubleSort(nums);
                break;
            case 1:
                Console.WriteLine("SelectionSort");
                selectionSort(nums);
                break;
            case 2:
                Console.WriteLine("InsertionSort");
                insertionSort(nums);
                break;
        }

        imprimir(nums);

    }


    public static void bubleSort(int[] vet)
    {

        int aux = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            for (int j = 0; j < vet.Length; j++)
            {
                if (vet[i] < vet[j])
                {
                    aux = vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                }
            }
        }

    }


    public static void selectionSort(int[] vet)
    {
        int aux = 0;
        int pos = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            for (int j = i+1; j < vet.Length; j++)
            {
                pos = 0;
                if (vet[i] > vet[j])
                {
                    pos = j;
                }

                if (j <= vet.Length - 1 && pos != -1)
                {/*
                    aux = vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                    */
                }
            }

            aux = vet[i];
            vet[i] = vet[pos];
            vet[pos] = aux;
        }
    }

    public static void insertionSort(int[] vet)
    {
        int aux = 0;
        int pos = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            for (int j = i + 1; j <= 0; j--)
            {
                pos = -1;
                if (vet[i] > vet[j])
                {
                    pos = j;
                }

                if (pos != -1)
                {
                    aux = vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                }
            }
        }
    }

    public static void imprimir(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i]);
        }
    }
}