using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome completo: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa? ");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preco de um PC: ");
        float preco = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Entre com seu último nome, idade e altura: ");
        string[] vet = Console.ReadLine().Split(' ');
        string sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        float alt = float.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(quartos); 
        Console.WriteLine(preco.ToString("f4", CultureInfo.InvariantCulture));
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine((alt.ToString("f2", CultureInfo.InvariantCulture)));

    }
}