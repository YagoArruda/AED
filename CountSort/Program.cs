using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int tam = 2;
        int[] baseDeDados = new int[tam];
        int[] contagem = new int[tam];
gerarVetor(baseDeDados);

        for (int i = 0; i < baseDeDados.Length + 1; i++)
        {
            contagem[i--] += 1;
        }

        for (int i = 0; i < baseDeDados.Length + 1; i++)
        {
            Console.Write($"{baseDeDados[i]} /");
        }

    }

    public static void gerarVetor(int[] vetor)
    {

        Random rd = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rd.Next(1,75);
        }

    }
}