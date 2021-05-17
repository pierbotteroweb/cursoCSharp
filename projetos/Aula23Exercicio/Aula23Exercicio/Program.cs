using System;
using System.Globalization;

namespace Aula23Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("SAIDA");
            Console.WriteLine($"Nome: {fullname}");
            Console.WriteLine($"Quartos: {quartos}");
            Console.WriteLine($"Preço do produto: {preco:F2}");
            Console.WriteLine($"Ultimo nome: {lastname}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura:F2}");
            

        }
    }
}
