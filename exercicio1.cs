using System;

class exercicio1 {
    static void Main() {
        Console.Write("Digite a quantidade de números (n): ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++) {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros em ordem inversa:");
        for (int i = n - 1; i >= 0; i--) {
            Console.Write(vetor[i] + " ");
        }
    }
}
