using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        int atv = 0;
        do
        {
            Console.WriteLine("Nivelamento 2");
            Console.WriteLine("1 - carateristica do 3025");
            Console.WriteLine("2 - primo/perfeito");
            Console.WriteLine("3 - vetores");
            Console.WriteLine("4 - matriz");
            Console.WriteLine("5 - fatorial");
            Console.WriteLine("6 - x elevado a y");
            atv = int.Parse(Console.ReadLine());
        }
        while (atv < 1 || atv > 11);

        switch (atv)
        {
            case 1:
                for (int i = 1000; i < 9999; i++)
                {
                    int parte1 = i / 100;
                    int parte2 = i % 100;

                    int soma = parte1 + parte2;

                    if (soma * soma == i)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;

            case 2:
                int atv2 = 0;
                do
                {
                    Console.WriteLine("---primo/perfeito---");
                    Console.WriteLine("1 - primo");
                    Console.WriteLine("2 - perfeito");
                    atv2 = int.Parse(Console.ReadLine());
                }
                while (atv < 1 || atv > 2);

                if (atv2 == 1)
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    int divs = 0;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            divs++;
                        }
                    }

                    if (divs > 0)
                    {
                        Console.WriteLine("Não é primo");
                    }
                    else
                    {
                        Console.WriteLine("É primo");
                    }
                }
                else
                {
                    Console.WriteLine("-----");
                    for (int i = 1; i < 1000; i++)
                    {
                        int divisores = 1;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                divisores += j;
                            }
                        }
                        if (divisores == i)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

                break;

            case 3:
                int[] A = { 1, 2, 3, 4, 5 }, B = { 6, 7, 3, 4, 8 };
                Console.WriteLine("A - 1, 2, 3, 4, 5");
                Console.WriteLine("B - 6, 7, 3, 4, 8");

                int diferente = 0, igual = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (A[i] == B[i])
                    {
                        igual++;
                    }
                    else
                    {
                        diferente++;
                    }
                }

                int[] C = new int[igual], D = new int[diferente];

                igual = diferente = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (A[i] == B[i])
                    {
                        C[igual] = A[i];
                        igual++;
                    }
                    else
                    {
                        D[diferente] = A[i];
                        diferente++;
                    }

                }

                Console.Write("Iguais: ");
                for (int i = C.Length - 1; i >= 0; i--)
                {
                    Console.Write($"/ {C[i]}");
                }
                Console.WriteLine();
                Console.WriteLine("---");

                Console.Write("Diferentes (Presentes em A): ");
                for (int i = D.Length - 1; i >= 0; i--)
                {
                    Console.Write($"/ {D[i]}");
                }
                Console.WriteLine();
                Console.WriteLine("---");
                break;

            case 4:
                int[,] mat = new int[2, 3];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Digite um Numero inteiro: ");
                        mat[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();

                int somador = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        somador += mat[i, j];
                    }
                }

                Console.WriteLine($"Soma: {somador}");
                break;

            case 5:
                Console.WriteLine("Digite um numero: ");
                int num5 = int.Parse(Console.ReadLine());
                int fat = num5;

                fatorial(num5, ref fat);

                Console.WriteLine($"Fatorial: {fat}");
                break;

            case 6:
                Console.WriteLine("Digite o primeiro numero: ");
                int numX = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int numY = int.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {potencia(numX,numY)}");
                break;
        }
    }

    public static void fatorial(int num, ref int fat)
    {
        for (int i = 2; i < num; i++)
        {
            fat *= i;
        }
    }

    public static int potencia(int x, int y)
    {
        int res = x;
        for (int i = 0; i < y; i++)
        {
            res = res * x;
        }
        return res;
    }
}