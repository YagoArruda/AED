using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        fila teste = new fila();

        int op = 0;
        do
        {
            op = teste.menu();
        }
        while (op != 0);

    }
}

public class fila
{
    private int[] dados;
    private int qtd = -1;

    public fila()
    {
        Console.WriteLine("Tamanho da fila: ");
        this.dados = new int[int.Parse(Console.ReadLine())];
        this.qtd = 0;
    }

    public void adicionar()
    {
        bool state = this.cheio();
        if (state == false)
        {
            Console.WriteLine("Valor a ser adicionado: ");
            this.dados[qtd] = int.Parse(Console.ReadLine());
            this.qtd++;
        }
    }

    public void remover()
    {
        bool state = this.vazio();
        if (state == false)
        {
            for (int i = 0; i < this.qtd - 1; i++)
            {
                this.dados[i] = this.dados[i + 1];
            }
            this.qtd--;
            Console.WriteLine("Primeiro da fila removido");
        }
    }

    public bool vazio()
    {
        if (this.qtd == 0)
        {
            Console.WriteLine("Fila Vazia!");
            return true;
        }
        return false;
    }

    public bool cheio()
    {
        if (this.qtd == this.dados.Length)
        {
            Console.WriteLine("Esta cheio!");
            return true;
        }

        return false;
    }

    public void ler()
    {
        Console.WriteLine($"Primeira posicao: {this.dados[0]}");
    }

    public int menu()
    {
        int op = 0;
        do
        {
            Console.Clear();

            Console.WriteLine("--- Fila ---");
            Console.WriteLine($"{this.qtd}/{this.dados.Length}");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Verificar vazio");
            Console.WriteLine("4 - Ler elemento");
            Console.WriteLine("0 - sair");
            op = int.Parse(Console.ReadLine());
        }
        while (op > 4 || op < 0);

        this.escolha(op);

        return op;
    }

    public void escolha(int op)
    {
        switch (op)
        {
            case 1:
                this.adicionar();
                break;
            case 2:
                this.remover();
                break;
            case 3:
                bool state = this.vazio();
                if (state == false)
                {
                    Console.WriteLine("Nao esta vazio!");
                }
                break;
            case 4:
                this.ler();
                break;
        }

        if(op != 1 && op != 0){
            this.esperarPressionar();
        }
    }

    public void esperarPressionar()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}