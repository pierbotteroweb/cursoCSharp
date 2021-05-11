using System;
using System.Globalization;

namespace Course
{
    class Program{
        static void Main(string[] args){
            sbyte x = 127;
            int y = 86;
            string z = "23";
            int k = 2147483647;
            long w = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float flutuante = 4.5f;
            double duplo = 4.5;
            double saldo = 100357.844565;
            string nome = "Pier Bottero";
            object obj1 = "Valor string de obj1";
            object bjj2 = 4.6;
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            long maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;

            Console.WriteLine("Valor minimo de var tipo int: "+minInt);
            Console.WriteLine("Valor maximo de var tipo int: "+maxInt);
            Console.WriteLine("Valor minimo de var tipo sbyte: "+minSbyte);
            Console.WriteLine("Valor máximo de var tipo long: "+maxLong);
            Console.WriteLine("Valor máximo de var tipo decimal: " + maxDecimal);


            Console.WriteLine(z + x + y);
            Console.WriteLine(x + y + z);
            Console.WriteLine(x);
            x++;
            Console.WriteLine(x);
            Console.WriteLine(k);
            Console.WriteLine(w);
            Console.WriteLine("Boolean "+completo);
            Console.WriteLine("Char Genero "+genero + " decladado com aspas simples");
            Console.WriteLine("Letra (com cod UTF) "+letra + " decladado com aspas simples");
            Console.WriteLine("Numero Float (valor declarado com f no final) "+flutuante);
            Console.WriteLine("Numero Double (não precisa do f no final "+duplo);
            Console.WriteLine("String "+nome+" declarado com aspas duplas");
            Console.WriteLine("Um valor string tem seu conteudo imutavel, mas pode se atribuir uma outra string a variável");
            nome = "Emerson Bottero";
            Console.WriteLine("Variavel nome que recebou outro valor "+nome);
            Console.WriteLine("Conteudo de variavel generica tipo object: "+obj1);
            Console.WriteLine("Conteudo de variavel genérica tipo object: "+bjj2);
            Console.WriteLine("Texto de comando Console.WriteLine, onde a linha é quebrada");
            Console.Write("Texto de comando Console.Write, sem quebra de linha - ");
            Console.Write("Mais um texto de comando Console.Write, na mesma linha do comando anterior");
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("Variavle tipo double: "+saldo);
            Console.WriteLine("Variavle tipo double com duas casas decimais: " + saldo.ToString("F2"));
            Console.WriteLine("Variavle tipo double com quatro casas decimais: " + saldo.ToString("F4"));
            Console.WriteLine("Usando . como separador, eliminando config locais: " + saldo.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("==============USANDO PLACEHOLDERS==========");
            Console.WriteLine("{0} tem {1} de idade e possui saldo de R$ {2:F2} em conta.", nome, z, saldo);
            Console.WriteLine("==============USANDO INTERPOLAÇÃO==========");
            Console.WriteLine($"{nome} tem {z} de idade e possui saldo de R$ {saldo:F2} em conta.");
            Console.WriteLine("==============USANDO CONCATENAÇÃO==========");
            Console.WriteLine(nome+" tem " +z+" de idade e possui saldo de R$ "+saldo.ToString("f2")+" em conta.");

        }
    }
}
