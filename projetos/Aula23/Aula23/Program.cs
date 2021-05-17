using System;
using System.Globalization;

namespace Aula23 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executar a linha de comando int n1 = Console.ReadLine(); vai dar erro");
            Console.WriteLine("pois o que é recebido via cmd.Readline é sempre string.");
            Console.WriteLine("Para receber um inteiro via Cmd.Readline, é necessário");
            Console.WriteLine("converter o valor  para inteiro usando int.Parse");
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"int n1 = int.Parse(Console.ReadLine()); | n1 = {n1}");

            Console.WriteLine("Digitando um valor diferente de um inteiro, dará um exception error");
            Console.WriteLine("");
            Console.WriteLine("O mesmo problema do int vai ocorrer se fizermos char ch = Console.ReadLine()");
            Console.WriteLine("Nesse caso usamos char.Parse char ch = char.Parse(Console.ReadLine())");
            Console.WriteLine("Digite uma letra qualquer: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine($"char ch = char.Parse(Console.ReadLine()) | ch = {ch}");
            Console.WriteLine("");
            Console.WriteLine("Para que um numero double seja atribuido usamos double.Parse double db = double.Parse(Console.ReadLine())");
            Console.WriteLine("Digite um número fracionario separado por ponto: ");
            Console.WriteLine("Exemplo 4.23");
            double db = double.Parse(Console.ReadLine());
            Console.WriteLine($"double db = double.Parse(Console.ReadLine()) | db = {db}");
            Console.WriteLine("Como nosso idioma está para português, precisamos usar o separador ','");
            Console.WriteLine("Para que a saída seja no formato correto.");
            Console.WriteLine("Agora digite um número fracionario separado por virgula: ");
            db = double.Parse(Console.ReadLine());
            Console.WriteLine($"double db = double.Parse(Console.ReadLine()) | db = {db}");
            Console.WriteLine("");
            Console.WriteLine("Outra alternativa seria utilizar o CultureInfo.InvariantCulture");
            Console.WriteLine("do objeto System.Globalization");
            Console.WriteLine("digite um número fracionario separado por ponto: ");
            db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"double db = double.Parse(Console.ReadLine() CultureInfo.InvariantCulture) | db = {db}");
            Console.WriteLine("");
            Console.WriteLine("Usa se a mesma logica do Parse quando atribuimos valores contidos em listas,");
            Console.WriteLine("Cada valor com o Parse correspondente ao tipo de variavel destino:");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome, sexo (um char), idade e altura, tudo na mesma linha:");
            string[] vet = Console.ReadLine().Split(" ");
            Console.WriteLine("string[] vet = Console.ReadLine().Split(' ')");
            string nome = vet[0];
            Console.WriteLine("string nome = vet[0];");
            char sexo = char.Parse(vet[1]);
            Console.WriteLine("char sexo = char.Parse(vet[1]);");
            int idade = int.Parse(vet[2]);
            Console.WriteLine("int idade = int.Parse(vet[2]);");
            double altura = double.Parse(vet[3]);
            Console.WriteLine("double altura = double.Parse(vet[3]);");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
        }
    }
}
