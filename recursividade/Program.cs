using System;
using System.IO;

class Program2
{
    public static void Main(string[] args)
    {
        Console.Clear();

        int atv = 0;
        do
        {
            Console.WriteLine("Atividade Com Recursividade");
            Console.WriteLine("1 - Fatorial");
            Console.WriteLine("2 - N-esimo de Fibonacci");
            Console.WriteLine("3 - Somar um vetor");
            Console.WriteLine("4 - Encontrar em um vetor");
            Console.WriteLine("5 - Multiplicação");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("7 - Ocorrencias de uma letra");
            Console.WriteLine("8 - Somar os pares de um vetor");
            Console.WriteLine("9 - Remover consoantes");
            Console.WriteLine("10 - Converter para binario");
            atv = int.Parse(Console.ReadLine());
        }
        while (atv < 1 || atv > 10);

        int entradaNum = 0, res = 0;
        switch (atv)
        {
            case 1:
                Console.Write("Digite um numero: ");
                entradaNum = int.Parse(Console.ReadLine());
                res = fat(entradaNum);
                Console.Write($"O fatorial de {entradaNum} é: {res} ");
                break;

            case 2:
                Console.Write("Digite a posição da sequencia de Fibonacci: ");
                int pos2 = int.Parse(Console.ReadLine());
                int res2 = fib(pos2);
                Console.WriteLine("----");
                Console.WriteLine($"O numero da sequencia que esta na posição {pos2} é: {res2}");
                break;

            case 3:
                Console.Write("Digite o tamanho do vetor: ");
                int[] vet1 = new int[int.Parse(Console.ReadLine())];

                for (int i = 0; i < vet1.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1} numero: ");
                    vet1[i] = int.Parse(Console.ReadLine());
                }

                int res3 = somarVet(vet1, 0);

                Console.Write($"A soma do vetor é: {res3} ");
                break;

            case 4:
                Console.Write("Digite o tamanho do vetor: ");
                int[] vetNums = new int[int.Parse(Console.ReadLine())];

                for (int i = 0; i < vetNums.Length; i++)
                {
                    Console.Write($"{i + 1}: ");
                    vetNums[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Digite o numero que deseja procurar: ");
                int numsRes = find(vetNums, int.Parse(Console.ReadLine()), 0);

                if (numsRes != -1)
                {
                    Console.WriteLine($"Posição do numero: {numsRes + 1}");
                }
                else
                {
                    Console.WriteLine("O numero não existe no vetor");
                }

                break;

            case 5:
                Console.Write("Digite o primeiro valor: ");
                int numA = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                int resMult = somaMultiplicada(numA, int.Parse(Console.ReadLine()));
                Console.WriteLine($"Resultado: {resMult}");
                break;

            case 6:
                Console.Write("Digite o primeiro valor: ");
                int numA2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                int resPote = pote(numA2, int.Parse(Console.ReadLine()));
                Console.WriteLine($"Resultado: {resPote}");
                break;

            case 7:
                Console.WriteLine("Digite uma frase: ");
                string fras = Console.ReadLine();
                Console.WriteLine("Digite uma letra: ");
                char let = char.Parse(Console.ReadLine());

                int encs = findLetter(fras, let, 0);

                Console.WriteLine($"{encs} Presença(s) de '{let}' em '{fras}'.");
                break;

            case 8:
                int[] vetPar = { 1, 2, 3, 4 };
                Console.WriteLine("Vetor: {1,2,3,4,5,6,7,8,9}");
                Console.WriteLine($" A soma dos pares resulta em: {somarVetPares(vetPar, 0)}");
                break;

            case 9:

                Console.WriteLine("Digite uma frase: ");
                string frass = Console.ReadLine();

                Console.WriteLine(removeLetter(frass, 0));

                break;

            case 10:

                Console.WriteLine("Digite um numero: ");
                string bin = binario(int.Parse(Console.ReadLine()));
                Console.WriteLine($"binario: {bin}");

                break;
        }
    }


    public static string binario(int n)
    {
        if (n < 2)
        {
            return n.ToString();
        }
        return binario(n / 2) + (n % 2).ToString();
    }

    public static string removeLetter(string frase, int pos)
    {
        if (pos >= frase.Length)
        {
            return "";
        }

        char[] vogs = { 'a', 'e', 'i', 'o', 'u' };
        int vos = 0;

        for (int i = 0; i < vogs.Length; i++)
        {
            if (frase[pos].ToString().ToLower() == vogs[i].ToString())
            {
                vos++;
            }
        }

        if (vos > 0)
        {
            return "" + removeLetter(frase, pos + 1);
        }
        else
        {
            return frase[pos] + removeLetter(frase, pos + 1);
        }


    }

    public static int somarVetPares(int[] vet, int pos)
    {

        if (pos == vet.Length)
        {
            return 0;
        }

        if (vet[pos] % 2 == 0)
        {
            Console.WriteLine(vet[pos]);
            return vet[pos] + somarVet(vet, pos + 1);
        }

        return 0 + somarVet(vet, pos + 1);
    }

    public static int findLetter(string frase, char letra, int pos)
    {

        if (pos >= frase.Length)
        {
            return 0;
        }

        if (frase[pos] == letra)
        {
            return 1 + findLetter(frase, letra, pos + 1);
        }
        else
        {
            return findLetter(frase, letra, pos + 1);
        }

    }

    public static int pote(int numA, int numB)
    {

        if (numB == 0)
        {
            return 1;
        }

        return numA * pote(numA, numB - 1);
    }

    public static int somaMultiplicada(int numA, int numB)
    {

        if (numB == 0)
        {
            return 0;
        }

        return numA + somaMultiplicada(numA, numB - 1);
    }

    public static int find(int[] vet, int num, int pos)
    {
        if (pos >= vet.Length)
        {
            return -1;
        }

        if (vet[pos] == num)
        {
            return pos;
        }

        return find(vet, num, pos + 1);
    }

    public static int fat(int num)
    {

        if (num == 1)
        {
            return 1;
        }

        return num * fat(num - 1);
    }

    public static int fib(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        int a = fib(n - 1);

        int b = fib(n - 2);

        return a + b;

    }

    public static int somarVet(int[] vet, int pos)
    {

        if (pos == vet.Length)
        {
            return 0;
        }

        return vet[pos] + somarVet(vet, pos + 1);
    }
}