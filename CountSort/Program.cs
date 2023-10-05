using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int[] baseDeDados = new int[74];
        int[] contagem = new int[74];


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
            vetor[i] = rd.Next();
        }

    }
}