using System;

class Program {
    static void Main() {

Console.Write("Quantidade n: ");
int n = int.Parse(Console.ReadLine());
int[] v = new int[n];

for (int i = 0; i < n; i++) v[i] = int.Parse(Console.ReadLine());

int maior = v[0], pos = 0;
for (int i = 1; i < n; i++) {
    if (v[i] > maior) {
        maior = v[i];
        pos = i;
    }
}
Console.WriteLine($"Maior: {maior} na posição {pos}");
    }
}
