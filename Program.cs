using System;

class Exercicio01
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números (n): ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        // Entrada de dados
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        // Saída em ordem inversa
        Console.WriteLine("\nNúmeros em ordem inversa:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine(); // Quebra de linha final
    }
}


/*Exercicio2
using System;

class Exercicio02
{
   // static void Main()
    {
        Console.Write("Digite a quantidade de números (n): ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor para a posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        // Lógica para encontrar o maior
        int maior = vetor[0];
        int posicao = 0;

        for (int i = 1; i < n; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posicao = i;
            }
        }

        Console.WriteLine($"\nO maior número inserido foi: {maior}");
        Console.WriteLine($"Ele está na posição: {posicao} do vetor.");
    }
} */



/* exercicio 3
using System;

class Exercicio03 {
    static void Main() {
        Console.Write("Digite n: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++) {
            Console.Write($"Valor {i}: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        int menor = vetor[0];
        int pos = 0;
        for (int i = 1; i < n; i++) {
            if (vetor[i] < menor) {
                menor = vetor[i];
                pos = i;
            }
        }
        Console.WriteLine($"Menor: {menor} na posição {pos}");
    }
}*/


/* exercicio 4
using System;

class Exercicio04 {
    static void Main() {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] v = new int[n];
        for (int i = 0; i < n; i++) v[i] = int.Parse(Console.ReadLine()!);

        int m1 = int.MinValue, m2 = int.MinValue;
        int p1 = -1, p2 = -1;

        for (int i = 0; i < n; i++) {
            if (v[i] > m1) {
                m2 = m1; p2 = p1;
                m1 = v[i]; p1 = i;
            } else if (v[i] > m2) {
                m2 = v[i]; p2 = i;
            }
        }
        Console.WriteLine($"1º Maior: {m1} (Pos {p1}), 2º Maior: {m2} (Pos {p2})");
    }
}*/

/* exercicio 5
using System;

class Exercicio05
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números (n): ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        // Inicializa maior e menor com o primeiro elemento
        int maior = vetor[0];
        int menor = vetor[0];

        // Único laço para encontrar ambos
        for (int i = 1; i < n; i++)
        {
            if (vetor[i] > maior) maior = vetor[i];
            if (vetor[i] < menor) menor = vetor[i];
        }

        Console.WriteLine($"\nMaior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}

}*/

/* exercicio 6
\using System;

class Exercicio06
{
    static void Main()
    {
        Console.Write("Digite a quantidade de idades (n): ");
        int n = int.Parse(Console.ReadLine()!);
        int[] idades = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite a {i + 1}ª idade: ");
            idades[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("\nClassificação das idades:");
        foreach (int idade in idades)
        {
            string categoria;
            if (idade >= 60) categoria = "idoso";
            else if (idade >= 18) categoria = "adulto";
            else if (idade >= 13) categoria = "adolescente";
            else if (idade >= 10) categoria = "pré-adolescente";
            else categoria = "criança";

            Console.WriteLine($"- {idade} anos: {categoria}");
        }
    }
}
/* exercicio 7 
using System;

class Exercicio07 {
    static void Main() {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] v = new int[n];
        int soma = 0, qtd = 0;
        long mult = 1;

        for (int i = 0; i < n; i++) {
            v[i] = int.Parse(Console.ReadLine()!);
            if (v[i] % 2 == 0) {
                soma += v[i];
                mult *= v[i];
                qtd++;
            }
        }
        if (qtd == 0) mult = 0;
        Console.WriteLine($"Soma: {soma}, Mult: {mult}, Qtd: {qtd}");
    }
}*/
/* exercicio 8
using System;

class Exercicio08 {
    static void Main() {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine()!);
        double[] v = new double[n];
        for (int i = 0; i < n; i++) v[i] = double.Parse(Console.ReadLine()!);

        Console.Write("Constante: ");
        double k = double.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Resultado {i}: {v[i] * k}");
        }
    }
}