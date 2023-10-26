using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
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
        for (int i = 0; i < this.qtd - 1; i++)
        {
            this.dados[i] = this.dados[i + 1];
        }
        this.qtd--;
    }

    public void vazio()
    {
        if (this.qtd == 0)
        {
            Console.WriteLine("Fila Vazia!");
        }
        else
        {
            Console.WriteLine("Nao esta Vazia!");
        }
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
            Console.WriteLine("--- Fila ---");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Verificar vazio");
            Console.WriteLine("4 - Ler elemento");
            Console.WriteLine("0 - sair");
            op = int.Parse(Console.ReadLine());
        }
        while (op > 5 || op < 0);

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
                this.vazio();
                break;
            case 4:
                this.ler();
                break;
        }
    }

}