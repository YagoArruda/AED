using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"inicio");

        int tam = 4;
        int[] baseDeDados = new int[tam];
        int[] baseOrdenada = new int[tam];
        //int[] contagem = new int[tam];

        baseDeDados[0] = 1;
        baseDeDados[1] = 5;
        baseDeDados[2] = 9;
        baseDeDados[3] = 4;
        //gerarVetor(baseDeDados);
        int maior = baseDeDados[0];
        for (int i = 1; i < baseDeDados.Length; i++)
        {
            if (baseDeDados[i] > maior)
            {
                maior = baseDeDados[i];
                Console.WriteLine($"maior:{maior}");
            }
        }
        maior++;
        int[] contagem = new int[maior];
        int[] pos = new int[maior];

        for (int i = 0; i < baseDeDados.Length; i++)
        {
            contagem[baseDeDados[i]] += 1;
        }
        for (int i = 0; i < contagem.Length; i++)
        {
            Console.WriteLine($"{i}/{contagem[i]}");
        }
        Console.WriteLine($"---Fim-Contagem---");

        int somador = 0;
        for (int i = 0; i < pos.Length; i++)
        {

            pos[i] = somador;

            somador += contagem[i];
            //pos[contagem[i]] += 1;
        }
        for (int i = 0; i < pos.Length; i++)
        {
            Console.WriteLine($"{i}/{pos[i]}");
        }
        Console.WriteLine($"---Fim-Pos---");

        for (int i = 0; i < baseDeDados.Length; i++)
        {
            //baseOrdenada[i] = baseDeDados[pos[i]];
            baseOrdenada[pos[baseDeDados[i]]] = baseDeDados[i];
            pos[baseDeDados[i]] += 1;
        }
        for (int i = 0; i < baseOrdenada.Length; i++)
        {
            Console.WriteLine($"{i}/{baseOrdenada[i]}");
        }
        /*
                for (int i = 0; i < baseDeDados.Length; i++)
                {
                    Console.Write($"{contagem[i]} / {pos[contagem[i]]}");
                }
        */
        Console.WriteLine($"fim");
    }

    public static void gerarVetor(int[] vetor)
    {

        Random rd = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rd.Next(1, 75);
        }

    }
}