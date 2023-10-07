using System;
using System.IO;
using System.Text;

using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //Gerar um vetor Aleatorio
        int tamanho = 50;
        int[] vet = new int[tamanho];
        gerarVetor(tamanho, vet);

        mergeSort(0, vet.Length, vet);

        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine(vet[i]);
        }

        stopwatch.Stop();
        long tempoDecorridoMs = stopwatch.ElapsedMilliseconds;
        Console.WriteLine("Tempo de execução: " + tempoDecorridoMs + " milissegundos");
    }

    public static void mergeSort(int inicio, int fim, int[] vetor)
    {
        if (fim > inicio)
        {
            int meio = (inicio + fim) / 2;

            mergeSort(0, meio, vetor);
            mergeSort(meio + 1, fim, vetor);

            intercalar(vetor, inicio, fim);
        }
    }

    public static void intercalar(int[] vetor, int inicio, int fim)
    {
        //Selection Sort n2-1
        int aux;

        for (int i = 0; i < fim - 1; i++)
        {
            int index = i;

            for (int j = i; j < fim; j++)
            {
                if (vetor[index] > vetor[j])
                {
                    index = j;
                }
            }

            aux = vetor[i];
            vetor[i] = vetor[index];
            vetor[index] = aux;
        }
    }

    public static void gerarVetor(int tamanho, int[] vetor)
    {
        Random rand = new Random();

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = rand.Next(0, 100);
        }
    }
}