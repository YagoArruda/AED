using System;
using System.IO;
using System.Text;
using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        //Inicializa os vetores com os valores originais e o dos ordenados
        int tam = 500;
        int[] baseDeDados = new int[tam];
        int[] baseOrdenada = new int[tam];

        //Preenche o vetor 
        gerarVetor(baseDeDados);

        //Inicia a contagem do tempo de execução
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //Determina o maior elemento do vetor
        int maior = baseDeDados[0];
        for (int i = 1; i < baseDeDados.Length; i++)
        {
            if (baseDeDados[i] > maior)
            {
                maior = baseDeDados[i];
            }
        }

        //Inicializa os vetores de contagem e posição
        maior++;
        int[] contagem = new int[maior];
        int[] pos = new int[maior];

        //Conta quantas vezes cada valor aparece
        for (int i = 0; i < baseDeDados.Length; i++)
        {
            contagem[baseDeDados[i]] += 1;
        }

        //Calcula a posição de cada valor
        int somador = 0;
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = somador;

            somador += contagem[i];
        }

        //Coloca os valores em suas posições de acordo com a posição (Ordena)
        for (int i = 0; i < baseDeDados.Length; i++)
        {
            baseOrdenada[pos[baseDeDados[i]]] = baseDeDados[i];
            pos[baseDeDados[i]] += 1;
        }

        //Finaliza a contagem do tempo de execução
        stopwatch.Stop();
        long tempoDecorridoMs = stopwatch.ElapsedMilliseconds;

        //Imprime o vetor original
        for (int i = 0; i < baseDeDados.Length; i++)
        {
            Console.Write($"{baseDeDados[i]}/");
        }
        Console.WriteLine();

        //Imprime o vetor ordenado
        for (int i = 0; i < baseOrdenada.Length; i++)
        {
            Console.Write($"{baseOrdenada[i]}/");
        }
        Console.WriteLine();

        //Imprime o tempo de execução
        Console.WriteLine("Tempo de execução: " + tempoDecorridoMs + " milissegundos");
    }

    //Preenche o vetor recebido até o seu limite
    public static void gerarVetor(int[] vetor)
    {

        Random rd = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rd.Next(1, 76);
        }

    }
}