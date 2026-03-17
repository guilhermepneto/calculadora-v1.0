/*
Versão 1.0

1- Nossa calculadora deve ter a possibilidade de somar dois números
2- Nossa calculadora deve ter a possibilidade de subtrair dois números
3- Nossa calculadora deve ter a possibilidade de multiplicar dois números
4- Nossa calculadora deve ter a possibilidade de dividir dois números
5- Nossa calculadora deve ter a possibilidade de realizar operações em continuidade

------------------------------------------------------------------------------------------

Versão 2.0

1- A calculadora deve produzir a tabulada do valor informado
2- Calculadora deve armazenar um histórico de operações*/

//Array

string[] histoperacoes = new string[100];
int contadoroper = 0;

while (true)
{
    Console.Clear();

    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Calculadora v2.0");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Selecione a operação desejada:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico");
    Console.WriteLine("S - Sair");
    string oper = Console.ReadLine();

    if (oper == "S" || oper == "s")
    {
        break;
    }

    if (oper != "1" && oper != "2" && oper != "3" && oper != "4" && oper != "5" && oper != "6")
    {
        Console.WriteLine("Opção inválida! Pressione ENTER para sair.");
        Console.ReadLine();
        continue;
    }

    if (oper == "5")
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Digite um número inteiro: ");
        string numdig = Console.ReadLine();

        int tab = Convert.ToInt32(numdig);

        Console.WriteLine("Informe o multiplicador máximo da tabuada: ");
        int multiplicadormax = Convert.ToInt32(Console.ReadLine());

        for (int iterador = 1; iterador <= multiplicadormax; iterador = iterador + 1)
        {
            string linhatabuada = $"{numdig} x {iterador} = {tab * iterador}";
            Console.WriteLine(linhatabuada);
        }

        Console.Write("Pressione ENTER para continuar");
        Console.ReadLine();
        continue;

    }

    if (oper == "6")
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("----------------------------------------------");

        for (int iterador = 0; iterador < histoperacoes.Length; iterador++)
        {
            if (histoperacoes[iterador] != null)
            {
                Console.WriteLine(histoperacoes[iterador]);
            }
        }
        Console.Write("Pressione ENTER para continuar");
        Console.ReadLine();
        continue;

    }


    Console.Write("Digite o primeiro número: ");
    string numero1 = Console.ReadLine();
    int num1 = Convert.ToInt32(numero1);

    Console.Write("Digite o segundo número: ");
    string numero2 = Console.ReadLine();
    int num2 = Convert.ToInt32(numero2);

    int resultado;
    string textoper;


    if (oper == "1")
    {
        resultado = num1 + num2;
        textoper = $"{num1} + {num2} = {resultado}";
    }
    else if (oper == "2")
    {
        resultado = num1 - num2;
        textoper = $"{num1} - {num2} = {resultado}";
    }
    else if (oper == "3")
    {
        resultado = num1 * num2;
        textoper = $"{num1} * {num2} = {resultado}";
    }
    else
    {
        resultado = num1 / num2;
        textoper = $"{num1} / {num2} = {resultado}";
    }

    if (contadoroper < histoperacoes.Length)
    {
        histoperacoes[contadoroper] = textoper;
        contadoroper++;
    }
    else
    {
        histoperacoes = new string[100];
        contadoroper = 0;

        histoperacoes[contadoroper] = textoper;
        contadoroper++;
    }

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();
}


