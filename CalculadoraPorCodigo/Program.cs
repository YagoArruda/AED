using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int op;
        do
        {
            do
            {
                Console.WriteLine("--- Opções ---");
                Console.WriteLine("1 - escrever formula");
                Console.WriteLine("2 - formula teste: 3 + 5 * (7 - 2) / 4");
                Console.WriteLine("0 - sair");
                op = int.Parse(Console.ReadLine());
            }
            while (op < 0 || op > 2);

            string formula = "3 + 5 * (7 - 2) / 4";
            if (op == 1)
            {
                Console.WriteLine("Digite a formula: ");
                formula = Console.ReadLine();
            }

            string formula2 = "";

            pilha formulaFinal = new pilha();
            pilha pilhaAux = new pilha();

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i].ToString() == "+" || formula[i].ToString() == "-" || formula[i].ToString() == "*" || formula[i].ToString() == "/" || formula[i].ToString() == "(" || formula[i].ToString() == ")")
                {
                    if (formula[i].ToString() == ")")
                    {

                        while (pilhaAux.ultimo.ValorAtual != '(')
                        {
                            if (pilhaAux.ultimo.ValorAtual != '(')
                            {
                                char aux = pilhaAux.Remover();
                                formulaFinal.Adicionar(aux);
                            }
                        }

                        pilhaAux.Remover();

                    }
                    else
                    {
                        if (formula[i].ToString() == "*" || formula[i].ToString() == "/")
                        {

                            if (pilhaAux.ultimo.ValorAtual.ToString() != "-" && pilhaAux.ultimo.ValorAtual.ToString() != "+")
                            {
                                formulaFinal.Adicionar(pilhaAux.Remover());
                                pilhaAux.Adicionar(formula[i]);
                            }
                            else
                            {
                                pilhaAux.Adicionar(formula[i]);
                            }

                        }
                        else
                        {
                            pilhaAux.Adicionar(formula[i]);
                        }

                    }
                }
                else if (int.TryParse(formula[i].ToString(), out int result))
                {
                    formulaFinal.Adicionar(formula[i]);
                }
            }

            while (pilhaAux.ultimo != null)
            {
                char aux = pilhaAux.Remover();
                formulaFinal.Adicionar(aux);
            }

            if (op != 0)
            {
                formulaFinal.ExibirPilha();
                Console.WriteLine($"{resolver(formulaFinal)}");
            }

        }
        while (op != 0);

    }



    public static int resolver(pilha formula)
    {
        int resultado = 0;

        pilha aux = new pilha();

        while (formula.ultimo != null)
        {
            aux.Adicionar(formula.Remover());
        }
        character atual = aux.primeiro;

        while (atual.ValorAtual != null)
        {
            character num2Ref = atual.anterior;

            string num1 = atual.anterior.ValorAtual.ToString();
            string num2 = num2Ref.ValorAtual.ToString();

            switch (atual.ValorAtual.ToString())
            {
                case "-":
                    resultado += int.Parse(num1) - int.Parse(num2);
                    break;
                case "+":
                    resultado += int.Parse(num1) + int.Parse(num2);
                    break;
                case "*":
                    resultado += int.Parse(num1) * int.Parse(num2);
                    break;
                case "/":
                    resultado += int.Parse(num1) / int.Parse(num2);
                    break;
            }
            atual = atual.proximo;
        }

        /*
                for (int i = 0; i < formula.Length; i++)
                {
                    if (formula[i] == "-" || formula[i] == "+" || formula[i] == "*" || formula[i] == "/")
                    {
                        if (i >= 2)
                        {
                            switch (formula[i])
                            {
                                case "-":
                                    resultado += int.Parse(formula[i - 2]) - int.Parse(formula[i - 1]);
                                    break;
                                case "+":
                                    resultado += int.Parse(formula[i - 2]) + int.Parse(formula[i - 1]);
                                    break;
                                case "*":
                                    resultado += int.Parse(formula[i - 2]) * int.Parse(formula[i - 1]);
                                    break;
                                case "/":
                                    resultado += int.Parse(formula[i - 2]) / int.Parse(formula[i - 1]);
                                    break;
                            }
                        }
                    }
                }
            */

        return resultado;
    }

}



class pilha
{
    public character primeiro;
    public character ultimo;

    public pilha()
    {
        primeiro = null;
        ultimo = null;
    }

    public void Adicionar(char dado)
    {
        character novoValor = new character(dado);

        if (ultimo == null)
        {
            primeiro = novoValor;
            ultimo = novoValor;
        }
        else
        {
            novoValor.anterior = ultimo;
            ultimo.proximo = novoValor;
            ultimo = novoValor;
        }

    }

    public char Remover()
    {

        if (primeiro == null)
        {
            Console.WriteLine("A pilha está vazia.");
        }
        else
        {
            char valorRetirado = ultimo.ValorAtual;
            ultimo = ultimo.anterior;

            if (ultimo == null)
            {
                primeiro = null;
            }

            return valorRetirado;
        }

        return '{';
    }

    public void ExibirPilha()
    {
        character atual = primeiro;

        while (atual != null)
        {
            Console.Write($"{atual.ValorAtual} ");
            atual = atual.proximo;
        }

        Console.WriteLine();
    }

    public bool Vazia()
    {
        return primeiro == null;
    }

    public string RetornarPilha()
    {
        string resultado = "";
        character atual = primeiro;

        while (atual != null)
        {
            resultado += atual.ValorAtual;
            atual = atual.proximo;
        }

        return resultado;
    }
}

public class character
{
    public char ValorAtual;
    public character proximo;
    public character anterior;

    public character(char entrada)
    {
        ValorAtual = entrada;
        proximo = null;
        anterior = null;
    }
}