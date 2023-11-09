using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {

        int atv = 0;

        do
        {

            Console.WriteLine("Atividades");
            Console.WriteLine("-----");
            Console.WriteLine("1 - Media de 5 idades");
            Console.WriteLine("2 - Par ou impar");
            Console.WriteLine("3 - Pessoas com mais de 18");
            Console.WriteLine("4 - Alto e baixo");
            Console.WriteLine("5 - Calculadora");
            Console.WriteLine("6 - Permitido ou negado");
            Console.WriteLine("7 - Troca de 'A' ou 'a' ");
            Console.WriteLine("8 - Reajuste de salario");
            Console.WriteLine("9 - Dados salvos em arquivo");
            Console.WriteLine("10 - IMC");
            Console.WriteLine("-----");
            atv = int.Parse(Console.ReadLine());

        }
        while (atv > 10 || atv < -1);


        switch (atv)
        {
            case 1:

                int media = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Idade do {i + 1}° aluno");
                    media += int.Parse(Console.ReadLine());
                }
                media /= 5;
                Console.WriteLine("-----");
                Console.WriteLine($"Media das idades: {media}");

                break;

            case 2:

                Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("-----");

                if ((num % 2) == 0)
                {
                    Console.WriteLine("O numero é PAR");
                }
                else
                {
                    Console.WriteLine("O numero é IMPAR");
                }

                break;

            case 3:
                int idade = 0;
                int count = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Idade da {i + 1}° ({i + 1}/10) pessoa: ");
                    idade = int.Parse(Console.ReadLine());

                    if (idade > 18)
                    {
                        count++;
                    }
                    Console.WriteLine("-----");
                }
                Console.WriteLine($"Pessoas com mais de 18 anos: {count}");

                break;

            case 4:
                int matriculaAlto = 0, matriculaBaixo = 0;
                double alturaAlto = double.MinValue, alturaBaixo = double.MaxValue;

                int auxMatricula = 0;
                double auxAltura = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Aluno {i + 1}/10:");
                    Console.WriteLine("Matricula:");
                    auxMatricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    auxAltura = double.Parse(Console.ReadLine());

                    if (alturaAlto < auxAltura)
                    {
                        matriculaAlto = auxMatricula;
                        alturaAlto = auxAltura;
                    }

                    if (alturaBaixo > auxAltura)
                    {
                        matriculaBaixo = auxMatricula;
                        alturaBaixo = auxAltura;
                    }
                    Console.WriteLine("-----");
                }
                Console.WriteLine("-----");
                Console.WriteLine("Aluno mais alto:");
                Console.WriteLine($"Matricula: {matriculaAlto}");
                Console.WriteLine($"Altura: {alturaAlto}");

                Console.WriteLine("-----");
                Console.WriteLine("Aluno mais baixo:");
                Console.WriteLine($"Matricula: {matriculaBaixo}");
                Console.WriteLine($"Altura: {alturaBaixo}");
                Console.WriteLine("-----");

                break;

            case 5:
                int num1 = 0, num2 = 0, op2 = 0, resultado = 0;

                do
                {
                    Console.WriteLine("Operações");
                    Console.WriteLine("-----");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Divisão");
                    Console.WriteLine("4 - Multiplicação");
                    Console.WriteLine("-----");
                    op2 = int.Parse(Console.ReadLine());
                }
                while (op2 > 4 || op2 < 1);

                Console.WriteLine("Digite o primeiro numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                num2 = int.Parse(Console.ReadLine());

                switch (op2)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 / num2;
                        break;
                    case 4:
                        resultado = num1 * num2;
                        break;
                }
                Console.WriteLine($"Resultado: {resultado}");

                break;

            case 6:
                int idadeUser = 0;
                Console.WriteLine("Idade:");
                idadeUser = int.Parse(Console.ReadLine());


                if (idadeUser >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Permissão concedida");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sem permissão");
                }

                break;

            case 7:
                string frase = "";
                Console.WriteLine("Digite uma frase");
                frase = Console.ReadLine();

                string aux = "";
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == 'A' || frase[i] == 'a')
                    {
                        aux += '&';
                    }
                    else
                    {
                        aux += frase[i];
                    }
                }
                frase = aux;
                Console.WriteLine($"Resultado: '{frase}'");

                break;

            case 8:
                double salario = 0;
                Console.WriteLine("Digite o valor do salario: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 1.700)
                {
                    salario += 300;
                }
                else
                {
                    salario += 200;
                }

                Console.WriteLine($"Salario com o reajuste: R$ {salario}");

                break;

            case 9:

                gravar();
                ler();

                break;

            case 10:
                int op = 0;

                do
                {
                    Console.WriteLine("-IMC-");
                    Console.WriteLine("1 - Novo cadastro");
                    Console.WriteLine("2 - Cadastros salvos");
                    Console.WriteLine("-----");
                    op = int.Parse(Console.ReadLine());
                }
                while (op > 2 || op < 1);
                Console.WriteLine("-----");

                if (op == 1)
                {
                    string path = @"IMC.txt";

                    if (!File.Exists(path))
                    {
                        ChecarArquivo();
                    }

                    StreamReader arquiv = new StreamReader(path);

                    int cadastrados = int.Parse(arquiv.ReadLine());
                    string[] imcs = new string[cadastrados + 1];

                    for (int i = 0; i < cadastrados; i++)
                    {
                        imcs[i] = arquiv.ReadLine();
                    }

                    arquiv.Close();

                    Console.WriteLine("Digite o nome: ");
                    string nomeImc = Console.ReadLine();
                    Console.WriteLine("Digite a idade: ");
                    int idadeImc = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o peso (kg): ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura (m): ");
                    double alturaImc = double.Parse(Console.ReadLine());

                    double imc = peso / (alturaImc * alturaImc);
                    Console.WriteLine($"IMC: {imc}");

                    StreamWriter escritor = new StreamWriter(path);
                    escritor.WriteLine(cadastrados + 1);

                    for (int i = 0; i < cadastrados; i++)
                    {
                        escritor.WriteLine(imcs[i]);
                    }
                    escritor.WriteLine($"{nomeImc}/{idadeImc}/{peso}/{alturaImc}");

                    escritor.Close();

                    Console.WriteLine("-----");
                }
                else
                {
                    StreamReader gravados = new StreamReader("IMC.txt");
                    int m = int.Parse(gravados.ReadLine());

                    for (int i = 0; i < m; i++)
                    {
                        string[] dado = gravados.ReadLine().Split("/");
                        Console.WriteLine($"Nome: {dado[0]} /Idade: {dado[1]} /Altura: {dado[2]} /IMC: {dado[3]}");

                        Console.WriteLine("-----");
                    }

                    gravados.Close();
                }

                break;
        }
    }

    public static void gravar()
    {

        StreamWriter gravador = new StreamWriter("Dados.txt");

        Console.WriteLine("Digite seu nome: ");
        gravador.WriteLine($"{Console.ReadLine()}");
        Console.WriteLine("Digite seu e-mail: ");
        gravador.WriteLine($"{Console.ReadLine()}");
        Console.WriteLine("Digite seu telefone: ");
        gravador.WriteLine($"{Console.ReadLine()}");
        Console.WriteLine("Digite seu RG ( MG-00.000.000): ");
        gravador.WriteLine($"{Console.ReadLine()}");

        gravador.Close();

    }

    public static void ler()
    {
        Console.WriteLine("-----");
        StreamReader leitor = new StreamReader("Dados.txt");
        string linha = leitor.ReadLine();
        Console.WriteLine("Dados gravados");
        Console.WriteLine($"nome: {linha}");
        Console.WriteLine($"e-mail: {leitor.ReadLine()}");
        Console.WriteLine($"telefone: {leitor.ReadLine()}");
        Console.WriteLine($"RG: {leitor.ReadLine()}");
        leitor.Close();
    }

    public static void ChecarArquivo()
    {
        string path = @"IMC.txt";

        if (File.Exists(path))
        {
            StreamReader arquiv = new StreamReader(path);
            arquiv.Close();
        }
        else
        {
            StreamWriter escritor = new StreamWriter(path);
            escritor.WriteLine("0");
            escritor.Close();
        }

    }

}