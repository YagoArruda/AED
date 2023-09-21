using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int[] vet = { 23, 15, 6, 9, 13 };

        mergeSort(0, vet.Length, vet);

        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine(vet[i]);
        }
    }

    public static void mergeSort(int inicio, int fim, int[] vetor)
    {
        int meio = (inicio + fim) / 2;

        if(meio == 0){
            return;
        }

        mergeSort(0, meio, vetor);
        mergeSort(meio + 1, fim, vetor);

        intercalar(vetor, inicio, fim);

        return;
    }

    public static void intercalar(int[] vetor, int inicio, int fim)
    {
        int aux;
        //somente para teste 
        for (int i = 0; i < fim - 1; i++)
        {
            for (int j = i; j < fim; j++)
            {
                if (vetor[i] > vetor[j])
                {
                    aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
            }
        }
    }


    /*
        public static void subInt(int inicio, int fim,int[] novo, int[] original){
            for(int i = 0; i < fim; i++){
                novo[i] = original[i];
            }
        }

        */


}